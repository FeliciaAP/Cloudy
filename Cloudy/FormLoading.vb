Imports System.ComponentModel
Imports System.Threading

Public Class FormLoading

    Private ProgressFile_ As String = "..."

    Public Property ProgressFile As String
        Set(value As String)
            ProgressFile_ = value

            lblJumlahLoading.Text = ProgressFile_
        End Set
        Get
            Return ProgressFile_
        End Get
    End Property
End Class