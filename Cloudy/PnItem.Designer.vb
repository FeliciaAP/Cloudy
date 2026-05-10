<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PnItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnLine = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pbMore = New System.Windows.Forms.PictureBox()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.chkbxSelect = New System.Windows.Forms.CheckBox()
        Me.pnFooter = New System.Windows.Forms.Panel()
        Me.pnMore = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.pnMain.SuspendLayout()
        CType(Me.pbMore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter.SuspendLayout()
        Me.pnMore.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnLine
        '
        Me.pnLine.BackColor = System.Drawing.Color.Gray
        Me.pnLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnLine.Location = New System.Drawing.Point(0, 74)
        Me.pnLine.Name = "pnLine"
        Me.pnLine.Size = New System.Drawing.Size(716, 1)
        Me.pnLine.TabIndex = 4
        '
        'lblDateTime
        '
        Me.lblDateTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDateTime.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDateTime.Location = New System.Drawing.Point(515, 10)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblDateTime.Size = New System.Drawing.Size(161, 54)
        Me.lblDateTime.TabIndex = 6
        Me.lblDateTime.Text = "1 Jan 2026, 12:00"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNama
        '
        Me.lblNama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(82, 10)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblNama.Size = New System.Drawing.Size(433, 54)
        Me.lblNama.TabIndex = 4
        Me.lblNama.Text = "..."
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.lblNama)
        Me.pnMain.Controls.Add(Me.lblDateTime)
        Me.pnMain.Controls.Add(Me.pbMore)
        Me.pnMain.Controls.Add(Me.pbIcon)
        Me.pnMain.Controls.Add(Me.chkbxSelect)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnMain.Size = New System.Drawing.Size(716, 74)
        Me.pnMain.TabIndex = 3
        '
        'pbMore
        '
        Me.pbMore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbMore.Image = Global.Cloudy.My.Resources.Resources.More
        Me.pbMore.Location = New System.Drawing.Point(676, 10)
        Me.pbMore.Margin = New System.Windows.Forms.Padding(4)
        Me.pbMore.Name = "pbMore"
        Me.pbMore.Size = New System.Drawing.Size(30, 54)
        Me.pbMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMore.TabIndex = 5
        Me.pbMore.TabStop = False
        '
        'pbIcon
        '
        Me.pbIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbIcon.Image = Global.Cloudy.My.Resources.Resources.Blue_circle
        Me.pbIcon.Location = New System.Drawing.Point(46, 10)
        Me.pbIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(36, 54)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 3
        Me.pbIcon.TabStop = False
        '
        'chkbxSelect
        '
        Me.chkbxSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkbxSelect.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkbxSelect.Location = New System.Drawing.Point(10, 10)
        Me.chkbxSelect.Name = "chkbxSelect"
        Me.chkbxSelect.Size = New System.Drawing.Size(36, 54)
        Me.chkbxSelect.TabIndex = 8
        Me.chkbxSelect.UseVisualStyleBackColor = True
        Me.chkbxSelect.Visible = False
        '
        'pnFooter
        '
        Me.pnFooter.Controls.Add(Me.pnMore)
        Me.pnFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnFooter.Location = New System.Drawing.Point(0, 74)
        Me.pnFooter.Name = "pnFooter"
        Me.pnFooter.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.pnFooter.Size = New System.Drawing.Size(716, 0)
        Me.pnFooter.TabIndex = 5
        '
        'pnMore
        '
        Me.pnMore.Controls.Add(Me.btnDelete)
        Me.pnMore.Controls.Add(Me.btnRename)
        Me.pnMore.Controls.Add(Me.btnCopy)
        Me.pnMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnMore.Location = New System.Drawing.Point(512, 0)
        Me.pnMore.Name = "pnMore"
        Me.pnMore.Size = New System.Drawing.Size(194, 0)
        Me.pnMore.TabIndex = 0
        Me.pnMore.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Gray
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(0, 88)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 44)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.Gray
        Me.btnRename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRename.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.ForeColor = System.Drawing.Color.White
        Me.btnRename.Location = New System.Drawing.Point(0, 44)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(194, 44)
        Me.btnRename.TabIndex = 1
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Gray
        Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(0, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(194, 44)
        Me.btnCopy.TabIndex = 0
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'PnItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.pnFooter)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.pnLine)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PnItem"
        Me.Size = New System.Drawing.Size(716, 75)
        Me.pnMain.ResumeLayout(False)
        CType(Me.pbMore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter.ResumeLayout(False)
        Me.pnMore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnLine As Panel
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents pbMore As PictureBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents pnMain As Panel
    Friend WithEvents pnFooter As Panel
    Friend WithEvents pnMore As Panel
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents chkbxSelect As CheckBox
    Friend WithEvents btnDelete As Button
End Class
