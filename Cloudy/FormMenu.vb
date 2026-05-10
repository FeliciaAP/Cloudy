Imports System.IO

Public Class FormMenu
    Public ItemOpenBefore As PnItem

    Private DirectoryPath_ As String = Path.Combine(Application.StartupPath, "CloudyServer")

    Public Property DirectoryPath As String
        Set(value As String)
            DirectoryPath_ = value
        End Set
        Get
            Return DirectoryPath_
        End Get
    End Property

    Private PrevClickedItem_ As PnItem

    Public Property PrevClickedItem As PnItem
        Set(value As PnItem)
            PrevClickedItem_ = value
        End Set
        Get
            Return PrevClickedItem_
        End Get
    End Property

    Private ClipboardValue_ As Specialized.StringCollection = New Specialized.StringCollection()

    Public Property ClipboardValue As Specialized.StringCollection
        Set(value As Specialized.StringCollection)
            ClipboardValue_ = value

            Try
                Clipboard.SetFileDropList(ClipboardValue_)
            Catch ex As Exception

            End Try
        End Set
        Get
            Return ClipboardValue_
        End Get
    End Property

    Private IsFolder_ As Boolean = False

    Public Property IsFolder As Boolean
        Set(value As Boolean)
            IsFolder_ = value

            If (IsFolder_) Then
                ' Folder
                pbHeaderIcon.Image = My.Resources.Resources.Left_Arrow
                pbHeaderIcon.Cursor = Cursors.Hand
                AddHandler pbHeaderIcon.Click, AddressOf backArrow_Click
            Else
                ' Main menu
                pbHeaderIcon.Image = My.Resources.Resources.Cloud
                pbHeaderIcon.Cursor = Cursors.Arrow
                RemoveHandler pbHeaderIcon.Click, AddressOf backArrow_Click

            End If
        End Set
        Get
            Return IsFolder_
        End Get
    End Property


    Private Title_ As String = "Cloudy"

    Public Property Title As String
        Set(value As String)
            Title_ = value

            lblTitle.Text = Title_
        End Set
        Get
            Return Title_
        End Get
    End Property

    Private Sub lblAddText_Click(sender As Object, e As EventArgs) Handles lblAddText.Click
        pnAddMore.Visible = Not pnAddMore.Visible

        pnFooter.Size = New Size(0, 0)

        'If (pnAddMore.Visible) Then
        'pnFooter.Size = New Size(pnAddMore.Size.Width, pnAddMore.Size.Height)
        'Else
        'pnFooter.Size = New Size(pbAddMore.Size.Width, pbAddMore.Size.Height)
        'End If
    End Sub

    Private Sub backArrow_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub lblAddFolder_Click(sender As Object, e As EventArgs) Handles lblAddFolder.Click
        Dim frm As FormInput
        frm = New FormInput()
        frm.Title = "Add Folder"
        frm.InputLabel = "Folder Name"
        frm.InputButton = "Add"


        If (frm.ShowDialog() = DialogResult.OK) Then
            Directory.CreateDirectory(Path.Combine(DirectoryPath, frm.InputText))

            RefreshList()
            pnAddMore.Visible = False
        End If


    End Sub

    Private Sub lblAddFile_Click(sender As Object, e As EventArgs) Handles lblAddFile.Click
        Dim openFileDialog As OpenFileDialog
        openFileDialog = New OpenFileDialog()
        openFileDialog.Multiselect = True

        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            addNewItems(openFileDialog.FileNames)

            RefreshList()
            pnAddMore.Visible = False
        End If
    End Sub

    Public Sub RefreshList()
        'Debug.WriteLine("Clipboard has file drop list: " & Clipboard.ContainsFileDropList().ToString())
        'ItemList = pnMain.Controls.OfType(Of PnItem)().ToList()
        chkbxIsSelectable.Checked = False

        pnMain.Controls.Clear()

        For Each folder As String In Directory.GetDirectories(DirectoryPath)
            addFolder(folder)
        Next

        For Each file As String In Directory.GetFiles(DirectoryPath)
            addFile(file)
        Next

        lblNoItem.Visible = False

        If (pnMain.Controls.Count = 0) Then
            lblNoItem.Visible = True
        End If
    End Sub

    Private Sub addFolder(path As String)
        Dim pn As PnItem
        pn = New PnItem()
        pn.IsFolder = True
        pn.ItemLocation = path
        pn.Dock = DockStyle.Top
        pn.AutoSize = False
        pnMain.Controls.Add(pn)
        pn.BringToFront()
        pn.Focus()
    End Sub

    Private Sub addFile(path As String)
        Dim pn As PnItem
        pn = New PnItem()
        pn.IsFolder = False
        pn.ItemLocation = path
        pn.Dock = DockStyle.Top
        pn.AutoSize = False
        pnMain.Controls.Add(pn)
        pn.BringToFront()
        pn.Focus()
    End Sub

    ' Tambahin file dan folder yang ada di filePaths
    Private Sub addNewItems(filePaths() As String)
        Dim count As Integer
        count = 0

        For Each location As String In filePaths
            Dim loading As FormLoading
            loading = New FormLoading()
            loading.ProgressFile = $"Uploading ({count}/{filePaths.Count()})"
            loading.Show()
            loading.Refresh()


            If (Directory.Exists(location)) Then
                ' Folder
                Dim folderPath As String
                Dim folderInfo As DirectoryInfo

                folderInfo = New DirectoryInfo(location)
                folderPath = folderInfo.FullName

                Dim newPath As String
                newPath = System.IO.Path.Combine(DirectoryPath, folderInfo.Name)

                ' Cek apabila item sudah exist
                If (Directory.Exists(newPath)) Then
                    Dim folderCount As Integer
                    Dim isNameFound As Boolean
                    folderCount = 1
                    isNameFound = True

                    While isNameFound
                        folderPath = $"{folderInfo.Name} ({folderCount})"
                        newPath = Path.Combine(DirectoryPath, folderPath)

                        If Not Directory.Exists(newPath) Then
                            isNameFound = False
                        End If
                        folderCount += 1
                    End While
                End If



                Dim sourceFolder As DirectoryInfo
                Dim targetFolder As String
                sourceFolder = New DirectoryInfo(location)
                targetFolder = newPath
                My.Computer.FileSystem.CopyDirectory(sourceFolder.FullName, targetFolder, True)

            Else
                ' File
                Dim filePath As String
                Dim fileExtension As String
                Dim fileNameWithoutExtension As String
                Dim fileInfo As FileInfo

                fileInfo = New FileInfo(location)
                filePath = fileInfo.FullName ' "D:\College\Semester 6\Pemrograman Visual Basic.NET\Kelompok\Cloudy\Cloudy\bin\Debug\CloudyServer\Blue circle.png"
                fileExtension = System.IO.Path.GetExtension(location) ' .png
                fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(location) ' Blue Circle.png

                Dim newPath As String
                newPath = System.IO.Path.Combine(DirectoryPath, fileInfo.Name)

                ' Cek apabila item sudah exist
                If (File.Exists(newPath)) Then
                    Dim fileCount As Integer
                    Dim isNameFound As Boolean
                    fileCount = 1
                    isNameFound = True

                    While isNameFound
                        filePath = $"{fileNameWithoutExtension} ({fileCount}){fileExtension}"
                        newPath = Path.Combine(DirectoryPath, filePath)

                        If Not File.Exists(newPath) Then
                            isNameFound = False
                        End If
                        fileCount += 1
                    End While
                End If



                Dim sourceFile As FileInfo
                Dim targetFile As String
                sourceFile = New FileInfo(location)
                targetFile = newPath
                File.Copy(sourceFile.FullName, targetFile, True)



            End If

            loading.Close()

            count += 1

        Next
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub

    Public Sub Toast(ToastMessage As String)
        lblToast.Text = ToastMessage
        lblToast.Visible = True
        timerToast.Interval = 2000
        timerToast.Start()
    End Sub

    Private Sub timerToast_Tick(sender As Object, e As EventArgs) Handles timerToast.Tick
        lblToast.Visible = False
        timerToast.Stop()
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        RefreshList()
    End Sub

    Private Sub pbPaste_Click(sender As Object, e As EventArgs) Handles pbPaste.Click

        If (Clipboard.ContainsFileDropList()) Then
            Dim isError As Boolean
            isError = False

            Dim fileList As New Specialized.StringCollection()
            fileList = ClipboardValue

            For Each path As String In fileList
                Try
                    addNewItems(New String() {path})
                Catch ex As Exception
                    isError = True
                    MessageBox.Show($"Couldn't locate file: {path}")
                End Try
            Next

            If (isError = False) Then
                Toast("Successfully pasted file(s)")
                RefreshList()
            Else
                Toast("No file can be pasted.")
            End If

        Else
            Toast("No file can be pasted.")
        End If
    End Sub

    Private Sub pbCopy_Click(sender As Object, e As EventArgs) Handles pbCopy.Click

        Dim itemList As New Specialized.StringCollection()

        If (chkbxIsSelectable.Checked = True) Then
            ' Multiple select on
            For Each uc As UserControl In pnMain.Controls
                Dim item As PnItem
                item = DirectCast(uc, PnItem)

                If (item.IsSelected) Then
                    itemList.Add(item.ItemLocation)
                End If
            Next
        ElseIf (PrevClickedItem IsNot Nothing) Then
            ' Multiple select off
            itemList.Add(PrevClickedItem.ItemLocation)
        End If

        If (itemList.Count = 0) Then
            Return
        End If

        Clipboard.SetFileDropList(itemList)

        ClipboardValue = Clipboard.GetFileDropList()

        Toast("Successfully copied file(s)")

        'Toast("Successfully copied file(s)")
    End Sub

    Private Sub chkbxIsSelectable_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxIsSelectable.CheckedChanged
        Dim checked As Boolean
        checked = chkbxIsSelectable.Checked

        pbCopy.Visible = checked
        pbDelete.Visible = checked

        changeSelectable(checked)
    End Sub

    Private Sub changeSelectable(isSelectable As Boolean)
        For Each uc As UserControl In pnMain.Controls
            Dim item As PnItem
            item = DirectCast(uc, PnItem)

            item.IsSelectable = isSelectable

            If (isSelectable) Then
                Me.PrevClickedItem = Nothing
                item.SetClicked(False)
            Else
                item.chkbxSelect.Checked = False
            End If
        Next
    End Sub

    Private Sub pbDelete_Click(sender As Object, e As EventArgs) Handles pbDelete.Click
        Dim dialogResult As DialogResult
        dialogResult = MessageBox.Show($"Are you sure you want to delete all selected items?", "Delete Item", MessageBoxButtons.YesNo)

        If (dialogResult = DialogResult.Yes) Then
            For Each uc As UserControl In pnMain.Controls
                Dim item As PnItem
                item = DirectCast(uc, PnItem)

                If (item.IsSelected) Then
                    item.DeleteItem()
                End If
            Next

            RefreshList()

            Toast("Successfully deleted file(s)")
        End If



    End Sub

    Private Sub FormMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control And e.KeyCode = Keys.V) Then
            pbPaste_Click(Nothing, Nothing)

        ElseIf (e.Control And e.KeyCode = Keys.C) Then
            pbCopy_Click(Nothing, Nothing)

        ElseIf (e.KeyCode = Keys.Delete) Then
            If (chkbxIsSelectable.Checked) Then
                pbDelete_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Public Sub SetClipboardValues(clipboardList As Specialized.StringCollection)
        Clipboard.SetFileDropList(clipboardList)
    End Sub
End Class
