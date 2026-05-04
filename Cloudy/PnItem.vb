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
                AddHandler lblNama.Click, AddressOf folderItem_Click

            Else
                ' File
                AddHandler lblNama.Click, AddressOf fileItem_Click

            End If
        End Set
        Get
            Return IsFolder_
        End Get
    End Property

    Private FileLocation_ As String = ""

    Public Property FileLocation As String
        Set(value As String)
            FileLocation_ = value

            If (FileLocation_ <> "" And File.Exists(FileLocation_)) Then
                FileItem = New FileInfo(FileLocation_)


            End If
        End Set
        Get
            Return FileLocation_
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
        End Set
        Get
            Return FileItem_
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

    Private Sub folderItem_Click(sender As Object, e As EventArgs)
        Dim frm As FormMenu
        frm = New FormMenu()
        frm.IsFolder = True
        frm.Title = ItemName
        frm.ItemList = ItemList

        If (frm.ShowDialog() = DialogResult.OK) Then
            ItemList = frm.ItemList
        End If
    End Sub

    Private Sub fileItem_Click(sender As Object, e As EventArgs)
        Try
            Dim startInfo As New ProcessStartInfo(FileLocation_)
            startInfo.UseShellExecute = True

            Process.Start(startInfo)
        Catch ex As Exception
            MessageBox.Show("Failed, please try again.")
        End Try
    End Sub

End Class
