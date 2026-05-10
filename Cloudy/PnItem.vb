Imports System.IO
Imports System.Diagnostics

Public Class PnItem

    Public ItemList As List(Of PnItem) = New List(Of PnItem)



    Private IsFolder_ As Boolean = False

    Public Property IsFolder As Boolean
        Set(value As Boolean)
            IsFolder_ = value

            If (IsFolder_) Then
                ' Folder
                IconImage = My.Resources.Resources.Folder
                AddHandler lblNama.DoubleClick, AddressOf folderItem_Click

            Else
                ' File
                AddHandler lblNama.DoubleClick, AddressOf fileItem_Click

            End If

            AddHandler lblNama.Click, AddressOf Item_Click

            ItemLocation = ItemLocation
        End Set
        Get
            Return IsFolder_
        End Get
    End Property

    Private ItemLocation_ As String = ""

    Public Property ItemLocation As String
        Set(value As String)
            ItemLocation_ = value

            If (ItemLocation_ <> "") Then
                If (Not IsFolder And ItemLocation_ <> "" And File.Exists(ItemLocation_)) Then
                    FileItem = New FileInfo(ItemLocation_)

                ElseIf (IsFolder) Then
                    FolderItem = New DirectoryInfo(ItemLocation_)

                End If
            End If
        End Set
        Get
            Return ItemLocation_
        End Get
    End Property

    Private FolderItem_ As DirectoryInfo = Nothing

    Public Property FolderItem As DirectoryInfo
        Set(value As DirectoryInfo)
            FolderItem_ = value

            ItemName = FolderItem_.Name

            ItemDateTime = FolderItem_.LastWriteTime
        End Set
        Get
            Return FolderItem_
        End Get
    End Property

    Private FileItem_ As FileInfo = Nothing

    Public Property FileItem As FileInfo
        Set(value As FileInfo)
            FileItem_ = value

            ItemName = FileItem_.Name

            Dim fileIcon As Icon
            fileIcon = Icon.ExtractAssociatedIcon(FileItem_.FullName)
            IconImage = fileIcon.ToBitmap()

            ItemDateTime = FileItem_.LastWriteTime
        End Set
        Get
            Return FileItem_
        End Get
    End Property

    Private IsSelectable_ As Boolean = False

    Public Property IsSelectable As Boolean
        Set(value As Boolean)
            IsSelectable_ = value

            chkbxSelect.Visible = IsSelectable_
        End Set
        Get
            Return IsSelectable_
        End Get
    End Property

    Private IsSelected_ As Boolean = False

    Public Property IsSelected As Boolean
        Set(value As Boolean)
            IsSelected_ = value
        End Set
        Get
            Return IsSelected_
        End Get
    End Property


    Private ItemName_ As String = "..."

    Public Property ItemName As String
        Set(value As String)
            ItemName_ = value

            lblNama.Text = ItemName_
        End Set
        Get
            Return ItemName_
        End Get
    End Property

    Private IconImage_ As Image = Nothing

    Private Property IconImage As Image
        Set(value As Image)
            IconImage_ = value

            pbIcon.Image = IconImage_
        End Set
        Get
            Return IconImage_
        End Get
    End Property

    Private ItemDateTime_ As DateTime = DateTime.MinValue

    Public Property ItemDateTime As DateTime
        Set(value As DateTime)
            ItemDateTime_ = value

            lblDateTime.Text = ItemDateTime_.ToString("d MMM yyyy HH:mm")
        End Set
        Get
            Return ItemDateTime_
        End Get
    End Property

    Private Sub folderItem_Click(sender As Object, e As EventArgs)
        Dim frm As FormMenu
        frm = New FormMenu()
        frm.IsFolder = True

        Dim separator As Char
        separator = Path.DirectorySeparatorChar
        Dim title As String

        title = ItemLocation.Split(New String() {$"{separator}bin{separator}Debug{separator}"}, StringSplitOptions.RemoveEmptyEntries)(1)
        title = title.Replace(separator, " > ")

        frm.Title = title

        frm.DirectoryPath = ItemLocation

        Dim parent As FormMenu
        parent = Me.FindForm()
        frm.ClipboardValue = parent.ClipboardValue

        frm.ShowDialog()

    End Sub

    Private Sub fileItem_Click(sender As Object, e As EventArgs)
        Try
            Dim startInfo As New ProcessStartInfo(ItemLocation_)
            startInfo.UseShellExecute = True

            Process.Start(startInfo)
        Catch ex As Exception
            MessageBox.Show("Failed, please try again.")
        End Try
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If File.Exists(ItemLocation) OrElse Directory.Exists(ItemLocation) Then
            Dim fileList As New Specialized.StringCollection()
            fileList.Add(ItemLocation)

            Clipboard.SetFileDropList(fileList)

            Dim frm As FormMenu
            frm = Me.FindForm()

            frm.Toast("Successfully copied file.")
        End If
    End Sub

    Private Sub pbMore_Click(sender As Object, e As EventArgs) Handles pbMore.Click
        Dim frm As FormMenu
        frm = Me.FindForm()
        If (frm.ItemOpenBefore IsNot Nothing And frm.ItemOpenBefore IsNot Me) Then
            frm.ItemOpenBefore.ReverseMoreVisibility()
        End If

        frm.ItemOpenBefore = Me

        ReverseMoreVisibility()
    End Sub

    Private Sub Item_Click(sender As Object, e As EventArgs)
        Dim parent As FormMenu
        parent = Me.FindForm()

        If (parent.PrevClickedItem IsNot Nothing) Then
            parent.PrevClickedItem.SetClicked(False)
        End If

        parent.PrevClickedItem = Me
        Me.SetClicked(True)
    End Sub

    Public Sub SetClicked(isClicked As Boolean)
        If (isClicked) Then
            Me.BackColor = Color.Teal
        Else
            Me.BackColor = Color.FromArgb(64, 64, 64)
        End If
    End Sub

    Public Sub ReverseMoreVisibility()
        pnMore.Visible = Not pnMore.Visible

        If (pnMore.Visible) Then
            ' Open more
            Me.Size = New Size(0, pnMain.Size.Height + 146 + pnLine.Size.Height)

        Else
            ' Close more
            Me.Size = New Size(0, pnMain.Size.Height + pnLine.Size.Height)
        End If
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Dim frm As FormInput
        frm = New FormInput()

        If (IsFolder) Then
            frm.Title = "Rename folder"
            frm.InputLabel = "Folder Name"
            frm.InputText = ItemName
        Else
            frm.Title = "Rename file"
            frm.InputLabel = "File Name"
            frm.InputText = Path.GetFileNameWithoutExtension(ItemName)
        End If

        frm.InputButton = "Save"


        If (frm.ShowDialog() = DialogResult.OK) Then
            If (IsFolder) Then
                ' Rename folder
                If (Directory.Exists(Path.Combine(FolderItem.Parent.FullName, frm.InputText))) Then
                    MessageBox.Show($"Folder dengan nama {frm.InputText} sudah ada, tolong gunakan nama lain")
                Else
                    My.Computer.FileSystem.RenameDirectory(ItemLocation, frm.InputText)
                    refreshForm()
                End If

            Else
                ' Rename file
                If (File.Exists(Path.Combine(FileItem.Directory.FullName, frm.InputText + FileItem.Extension))) Then
                    MessageBox.Show($"File dengan nama {frm.InputText} sudah ada, tolong gunakan nama lain")
                Else
                    My.Computer.FileSystem.RenameFile(ItemLocation, frm.InputText + FileItem.Extension)
                    refreshForm()
                End If

            End If


        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialogResult As DialogResult
        dialogResult = MessageBox.Show($"Are you sure you want to delete {ItemName}?", "Delete Item", MessageBoxButtons.YesNo)

        If (dialogResult = DialogResult.Yes) Then
            DeleteItem()

            refreshForm()
        End If
    End Sub

    Public Sub DeleteItem()
        If (IsFolder) Then
            ' Delete folder
            My.Computer.FileSystem.DeleteDirectory(ItemLocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        Else
            ' Delete file
            My.Computer.FileSystem.DeleteFile(ItemLocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If


    End Sub


    Private Sub chkbxSelect_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxSelect.CheckedChanged
        IsSelected = chkbxSelect.Checked
    End Sub

    Private Sub refreshForm()
        Dim parent As FormMenu
        parent = Me.FindForm()
        parent.RefreshList()
    End Sub


    Private Sub PnItem_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, lblNama.MouseEnter
        Dim parent As FormMenu
        parent = Me.FindForm()

        Try
            If (parent.PrevClickedItem IsNot Me) Then
                Me.BackColor = Color.DarkSlateGray
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PnItem_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, lblNama.MouseLeave
        Dim parent As FormMenu
        parent = Me.FindForm()

        Try
            If (parent.PrevClickedItem IsNot Me) Then
                Me.BackColor = Color.FromArgb(64, 64, 64)
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class
