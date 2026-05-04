Public Class FormMenu
    Public ItemList As List(Of PnItem) = New List(Of PnItem)


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
        Dim frm As FormAddFolder
        frm = New FormAddFolder()

        If (frm.ShowDialog() = DialogResult.OK) Then
            Dim item As PnItem
            item = New PnItem()
            item.IsFolder = True
            item.ItemName = frm.FolderName
            item.Dock = DockStyle.Top
            pnMain.Controls.Add(item)
            item.BringToFront()
            item.Focus()

            refreshList()
            pnAddMore.Visible = False
        End If


    End Sub

    Private Sub lblAddFile_Click(sender As Object, e As EventArgs) Handles lblAddFile.Click
        Dim openFileDialog As OpenFileDialog
        openFileDialog = New OpenFileDialog()
        openFileDialog.Multiselect = True

        If (openFileDialog.ShowDialog() = DialogResult.OK) Then
            For Each location As String In openFileDialog.FileNames
                Dim item As PnItem
                item = New PnItem()
                item.FileLocation = location
                item.IsFolder = False

                item.Dock = DockStyle.Top
                pnMain.Controls.Add(item)
                item.BringToFront()
                item.Focus()
            Next

            refreshList()
            pnAddMore.Visible = False
        End If
    End Sub

    Private Sub refreshList()
        ItemList = pnMain.Controls.OfType(Of PnItem)().ToList()

        lblNoItem.Visible = False

        If (pnMain.Controls.Count = 0) Then
            lblNoItem.Visible = True
        End If
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As PnItem In ItemList
            pnMain.Controls.Add(item)
        Next

        refreshList()
    End Sub
End Class
