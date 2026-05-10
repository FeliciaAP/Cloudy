<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.txbInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.pnFooter = New System.Windows.Forms.Panel()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.pnMain.SuspendLayout()
        Me.pnFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.txbInput)
        Me.pnMain.Controls.Add(Me.lblInput)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnMain.Location = New System.Drawing.Point(10, 10)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(549, 32)
        Me.pnMain.TabIndex = 1
        '
        'txbInput
        '
        Me.txbInput.BackColor = System.Drawing.Color.DimGray
        Me.txbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbInput.ForeColor = System.Drawing.Color.White
        Me.txbInput.Location = New System.Drawing.Point(135, 0)
        Me.txbInput.Name = "txbInput"
        Me.txbInput.Size = New System.Drawing.Size(414, 32)
        Me.txbInput.TabIndex = 2
        '
        'lblInput
        '
        Me.lblInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInput.ForeColor = System.Drawing.Color.White
        Me.lblInput.Location = New System.Drawing.Point(0, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(135, 32)
        Me.lblInput.TabIndex = 1
        Me.lblInput.Text = "Nama Text"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnFooter
        '
        Me.pnFooter.Controls.Add(Me.btnInput)
        Me.pnFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFooter.Location = New System.Drawing.Point(10, 42)
        Me.pnFooter.Name = "pnFooter"
        Me.pnFooter.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnFooter.Size = New System.Drawing.Size(549, 54)
        Me.pnFooter.TabIndex = 2
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInput.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Location = New System.Drawing.Point(456, 10)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Padding = New System.Windows.Forms.Padding(5)
        Me.btnInput.Size = New System.Drawing.Size(93, 44)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Add"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 106)
        Me.Controls.Add(Me.pnFooter)
        Me.Controls.Add(Me.pnMain)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormInput"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input"
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.pnFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents lblInput As Label
    Friend WithEvents txbInput As TextBox
    Friend WithEvents pnFooter As Panel
    Friend WithEvents btnInput As Button
End Class
