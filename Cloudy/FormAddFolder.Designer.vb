<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddFolder
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
        Me.lblNamaFolder = New System.Windows.Forms.Label()
        Me.txbAddText = New System.Windows.Forms.TextBox()
        Me.pnFooter = New System.Windows.Forms.Panel()
        Me.btnAddFolder = New System.Windows.Forms.Button()
        Me.pnMain.SuspendLayout()
        Me.pnFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.txbAddText)
        Me.pnMain.Controls.Add(Me.lblNamaFolder)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnMain.Location = New System.Drawing.Point(10, 10)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(549, 32)
        Me.pnMain.TabIndex = 1
        '
        'lblNamaFolder
        '
        Me.lblNamaFolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblNamaFolder.ForeColor = System.Drawing.Color.White
        Me.lblNamaFolder.Location = New System.Drawing.Point(0, 0)
        Me.lblNamaFolder.Name = "lblNamaFolder"
        Me.lblNamaFolder.Size = New System.Drawing.Size(135, 32)
        Me.lblNamaFolder.TabIndex = 1
        Me.lblNamaFolder.Text = "Nama Folder"
        Me.lblNamaFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txbAddText
        '
        Me.txbAddText.BackColor = System.Drawing.Color.DimGray
        Me.txbAddText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbAddText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbAddText.ForeColor = System.Drawing.Color.White
        Me.txbAddText.Location = New System.Drawing.Point(135, 0)
        Me.txbAddText.Name = "txbAddText"
        Me.txbAddText.Size = New System.Drawing.Size(414, 32)
        Me.txbAddText.TabIndex = 2
        '
        'pnFooter
        '
        Me.pnFooter.Controls.Add(Me.btnAddFolder)
        Me.pnFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFooter.Location = New System.Drawing.Point(10, 42)
        Me.pnFooter.Name = "pnFooter"
        Me.pnFooter.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnFooter.Size = New System.Drawing.Size(549, 54)
        Me.pnFooter.TabIndex = 2
        '
        'btnAddFolder
        '
        Me.btnAddFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFolder.Location = New System.Drawing.Point(456, 10)
        Me.btnAddFolder.Name = "btnAddFolder"
        Me.btnAddFolder.Padding = New System.Windows.Forms.Padding(5)
        Me.btnAddFolder.Size = New System.Drawing.Size(93, 44)
        Me.btnAddFolder.TabIndex = 0
        Me.btnAddFolder.Text = "Add"
        Me.btnAddFolder.UseVisualStyleBackColor = False
        '
        'FormAddFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 106)
        Me.Controls.Add(Me.pnFooter)
        Me.Controls.Add(Me.pnMain)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAddFolder"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Folder"
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.pnFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents lblNamaFolder As Label
    Friend WithEvents txbAddText As TextBox
    Friend WithEvents pnFooter As Panel
    Friend WithEvents btnAddFolder As Button
End Class
