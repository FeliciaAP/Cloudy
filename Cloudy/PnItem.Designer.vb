<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.pbMore = New System.Windows.Forms.PictureBox()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnMain.SuspendLayout()
        CType(Me.pbMore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.lblNama)
        Me.pnMain.Controls.Add(Me.pbMore)
        Me.pnMain.Controls.Add(Me.pbIcon)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnMain.Size = New System.Drawing.Size(716, 70)
        Me.pnMain.TabIndex = 3
        '
        'lblNama
        '
        Me.lblNama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(46, 10)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblNama.Size = New System.Drawing.Size(630, 50)
        Me.lblNama.TabIndex = 4
        Me.lblNama.Text = "..."
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbMore
        '
        Me.pbMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbMore.Image = Global.Cloudy.My.Resources.Resources.More
        Me.pbMore.Location = New System.Drawing.Point(676, 10)
        Me.pbMore.Margin = New System.Windows.Forms.Padding(4)
        Me.pbMore.Name = "pbMore"
        Me.pbMore.Size = New System.Drawing.Size(30, 50)
        Me.pbMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMore.TabIndex = 5
        Me.pbMore.TabStop = False
        '
        'pbIcon
        '
        Me.pbIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbIcon.Image = Global.Cloudy.My.Resources.Resources.Blue_circle
        Me.pbIcon.Location = New System.Drawing.Point(10, 10)
        Me.pbIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(36, 50)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 3
        Me.pbIcon.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 1)
        Me.Panel1.TabIndex = 4
        '
        'PnItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnMain)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PnItem"
        Me.Size = New System.Drawing.Size(716, 70)
        Me.pnMain.ResumeLayout(False)
        CType(Me.pbMore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMain As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents pbMore As PictureBox
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
