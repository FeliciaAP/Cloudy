Public Class FormInput
    Private Title_ As String = "Input"

    Public Property Title As String
        Set(value As String)
            Title_ = value

            Me.Text = Title_
        End Set
        Get
            Return Title_
        End Get
    End Property

    Private InputText_ As String = ""

    Public Property InputText As String
        Set(value As String)
            InputText_ = value

            txbInput.Text = InputText_
        End Set
        Get
            Return InputText_
        End Get
    End Property

    Private InputLabel_ As String = "Input"

    Public Property InputLabel As String
        Set(value As String)
            InputLabel_ = value

            lblInput.Text = InputLabel_
        End Set
        Get
            Return InputLabel_
        End Get
    End Property

    Private InputButton_ As String = "Add"

    Public Property InputButton As String
        Set(value As String)
            InputButton_ = value

            btnInput.Text = InputButton_
        End Set
        Get
            Return InputButton_
        End Get
    End Property

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If (txbInput.Text.Trim() <> "") Then
            InputText_ = txbInput.Text.Trim()
            Me.DialogResult = DialogResult.OK
            Close()
        End If
    End Sub
End Class