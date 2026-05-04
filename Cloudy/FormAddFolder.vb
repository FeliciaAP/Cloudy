Public Class FormAddFolder
    Private FolderName_ As String = ""

    Public Property FolderName As String
        Set(value As String)
            FolderName_ = value
        End Set
        Get
            Return FolderName_
        End Get
    End Property

    Private Sub btnAddFolder_Click(sender As Object, e As EventArgs) Handles btnAddFolder.Click
        If (txbAddText.Text.Trim() <> "") Then
            FolderName_ = txbAddText.Text.Trim()
            Me.DialogResult = DialogResult.OK
            Close()
        End If
    End Sub
End Class