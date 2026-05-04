<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbHeaderIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnFooter = New System.Windows.Forms.Panel()
        Me.pbAddMore = New System.Windows.Forms.PictureBox()
        Me.lblAddText = New System.Windows.Forms.Label()
        Me.pnContainer = New System.Windows.Forms.Panel()
        Me.lblNoItem = New System.Windows.Forms.Label()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pnAddMore = New System.Windows.Forms.Panel()
        Me.lblAddFile = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Panel()
        Me.lblAddFolder = New System.Windows.Forms.Label()
        Me.pnHeader.SuspendLayout()
        CType(Me.pbHeaderIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFooter.SuspendLayout()
        CType(Me.pbAddMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pbAddMore.SuspendLayout()
        Me.pnContainer.SuspendLayout()
        Me.pnAddMore.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnHeader
        '
        Me.pnHeader.Controls.Add(Me.lblTitle)
        Me.pnHeader.Controls.Add(Me.pbHeaderIcon)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Padding = New System.Windows.Forms.Padding(10)
        Me.pnHeader.Size = New System.Drawing.Size(740, 70)
        Me.pnHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(42, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(688, 50)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Cloudy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbHeaderIcon
        '
        Me.pbHeaderIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbHeaderIcon.Image = Global.Cloudy.My.Resources.Resources.Cloud
        Me.pbHeaderIcon.Location = New System.Drawing.Point(10, 10)
        Me.pbHeaderIcon.Name = "pbHeaderIcon"
        Me.pbHeaderIcon.Size = New System.Drawing.Size(32, 50)
        Me.pbHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHeaderIcon.TabIndex = 0
        Me.pbHeaderIcon.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 1)
        Me.Panel1.TabIndex = 1
        '
        'pnFooter
        '
        Me.pnFooter.AutoSize = True
        Me.pnFooter.Controls.Add(Me.pnAddMore)
        Me.pnFooter.Controls.Add(Me.pbAddMore)
        Me.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnFooter.Location = New System.Drawing.Point(0, 542)
        Me.pnFooter.MinimumSize = New System.Drawing.Size(0, 70)
        Me.pnFooter.Name = "pnFooter"
        Me.pnFooter.Padding = New System.Windows.Forms.Padding(10)
        Me.pnFooter.Size = New System.Drawing.Size(740, 132)
        Me.pnFooter.TabIndex = 3
        '
        'pbAddMore
        '
        Me.pbAddMore.Controls.Add(Me.lblAddText)
        Me.pbAddMore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddMore.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbAddMore.Image = Global.Cloudy.My.Resources.Resources.Blue_circle
        Me.pbAddMore.Location = New System.Drawing.Point(680, 10)
        Me.pbAddMore.Name = "pbAddMore"
        Me.pbAddMore.Size = New System.Drawing.Size(50, 112)
        Me.pbAddMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddMore.TabIndex = 0
        Me.pbAddMore.TabStop = False
        '
        'lblAddText
        '
        Me.lblAddText.BackColor = System.Drawing.Color.Transparent
        Me.lblAddText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddText.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddText.Location = New System.Drawing.Point(0, 0)
        Me.lblAddText.Name = "lblAddText"
        Me.lblAddText.Size = New System.Drawing.Size(50, 112)
        Me.lblAddText.TabIndex = 1
        Me.lblAddText.Text = "+"
        Me.lblAddText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnContainer
        '
        Me.pnContainer.Controls.Add(Me.lblNoItem)
        Me.pnContainer.Controls.Add(Me.pnMain)
        Me.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnContainer.Location = New System.Drawing.Point(0, 71)
        Me.pnContainer.Name = "pnContainer"
        Me.pnContainer.Size = New System.Drawing.Size(740, 471)
        Me.pnContainer.TabIndex = 4
        '
        'lblNoItem
        '
        Me.lblNoItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNoItem.ForeColor = System.Drawing.Color.Silver
        Me.lblNoItem.Location = New System.Drawing.Point(0, 0)
        Me.lblNoItem.Name = "lblNoItem"
        Me.lblNoItem.Size = New System.Drawing.Size(740, 471)
        Me.lblNoItem.TabIndex = 2
        Me.lblNoItem.Text = "Tidak ada item."
        Me.lblNoItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoItem.Visible = False
        '
        'pnMain
        '
        Me.pnMain.AutoScroll = True
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(740, 471)
        Me.pnMain.TabIndex = 3
        '
        'pnAddMore
        '
        Me.pnAddMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnAddMore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnAddMore.Controls.Add(Me.lblAddFile)
        Me.pnAddMore.Controls.Add(Me.lblLine2)
        Me.pnAddMore.Controls.Add(Me.lblAddFolder)
        Me.pnAddMore.Location = New System.Drawing.Point(466, 6)
        Me.pnAddMore.Name = "pnAddMore"
        Me.pnAddMore.Size = New System.Drawing.Size(208, 113)
        Me.pnAddMore.TabIndex = 1
        Me.pnAddMore.Visible = False
        '
        'lblAddFile
        '
        Me.lblAddFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddFile.ForeColor = System.Drawing.Color.White
        Me.lblAddFile.Location = New System.Drawing.Point(0, 57)
        Me.lblAddFile.Name = "lblAddFile"
        Me.lblAddFile.Padding = New System.Windows.Forms.Padding(5)
        Me.lblAddFile.Size = New System.Drawing.Size(206, 54)
        Me.lblAddFile.TabIndex = 3
        Me.lblAddFile.Text = "Add File"
        Me.lblAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLine2
        '
        Me.lblLine2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLine2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLine2.Location = New System.Drawing.Point(0, 56)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(206, 1)
        Me.lblLine2.TabIndex = 2
        '
        'lblAddFolder
        '
        Me.lblAddFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddFolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAddFolder.ForeColor = System.Drawing.Color.White
        Me.lblAddFolder.Location = New System.Drawing.Point(0, 0)
        Me.lblAddFolder.Name = "lblAddFolder"
        Me.lblAddFolder.Padding = New System.Windows.Forms.Padding(5)
        Me.lblAddFolder.Size = New System.Drawing.Size(206, 56)
        Me.lblAddFolder.TabIndex = 0
        Me.lblAddFolder.Text = "Add Folder"
        Me.lblAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 674)
        Me.Controls.Add(Me.pnContainer)
        Me.Controls.Add(Me.pnFooter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnHeader)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cloudy"
        Me.pnHeader.ResumeLayout(False)
        CType(Me.pbHeaderIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFooter.ResumeLayout(False)
        CType(Me.pbAddMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pbAddMore.ResumeLayout(False)
        Me.pnContainer.ResumeLayout(False)
        Me.pnAddMore.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnHeader As Panel
    Friend WithEvents pbHeaderIcon As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnFooter As Panel
    Friend WithEvents pbAddMore As PictureBox
    Friend WithEvents lblAddText As Label
    Friend WithEvents pnContainer As Panel
    Friend WithEvents lblNoItem As Label
    Friend WithEvents pnMain As Panel
    Friend WithEvents pnAddMore As Panel
    Friend WithEvents lblAddFile As Label
    Friend WithEvents lblLine2 As Panel
    Friend WithEvents lblAddFolder As Label
End Class
