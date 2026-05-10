<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblJumlahLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblJumlahLoading
        '
        Me.lblJumlahLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumlahLoading.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahLoading.Location = New System.Drawing.Point(0, 0)
        Me.lblJumlahLoading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJumlahLoading.Name = "lblJumlahLoading"
        Me.lblJumlahLoading.Size = New System.Drawing.Size(404, 136)
        Me.lblJumlahLoading.TabIndex = 0
        Me.lblJumlahLoading.Text = "..."
        Me.lblJumlahLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 136)
        Me.Controls.Add(Me.lblJumlahLoading)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLoading"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblJumlahLoading As Label
End Class
