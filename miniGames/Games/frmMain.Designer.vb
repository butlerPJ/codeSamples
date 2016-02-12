<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDice = New System.Windows.Forms.Label()
        Me.lblInsult = New System.Windows.Forms.Label()
        Me.lblAdventure = New System.Windows.Forms.Label()
        Me.btnDice = New System.Windows.Forms.Button()
        Me.btnInsult = New System.Windows.Forms.Button()
        Me.btnAdventure = New System.Windows.Forms.Button()
        Me.btnPlayDice = New System.Windows.Forms.Button()
        Me.btnPlayInsult = New System.Windows.Forms.Button()
        Me.btnPlayAdventure = New System.Windows.Forms.Button()
        Me.btnDeveloper = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gBoxDice = New System.Windows.Forms.GroupBox()
        Me.gBoxInsult = New System.Windows.Forms.GroupBox()
        Me.gBoxAdventure = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gBoxDice.SuspendLayout()
        Me.gBoxInsult.SuspendLayout()
        Me.gBoxAdventure.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "&About"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'lblDice
        '
        Me.lblDice.BackColor = System.Drawing.Color.SlateGray
        Me.lblDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDice.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDice.Location = New System.Drawing.Point(30, 26)
        Me.lblDice.Name = "lblDice"
        Me.lblDice.Size = New System.Drawing.Size(179, 61)
        Me.lblDice.TabIndex = 1
        Me.lblDice.Text = "Roll The Dice"
        Me.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInsult
        '
        Me.lblInsult.BackColor = System.Drawing.Color.Teal
        Me.lblInsult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInsult.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsult.Location = New System.Drawing.Point(248, 26)
        Me.lblInsult.Name = "lblInsult"
        Me.lblInsult.Size = New System.Drawing.Size(179, 61)
        Me.lblInsult.TabIndex = 4
        Me.lblInsult.Text = "Insult Generator"
        Me.lblInsult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdventure
        '
        Me.lblAdventure.BackColor = System.Drawing.Color.SteelBlue
        Me.lblAdventure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdventure.Font = New System.Drawing.Font("Playbill", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdventure.Location = New System.Drawing.Point(30, 26)
        Me.lblAdventure.Name = "lblAdventure"
        Me.lblAdventure.Size = New System.Drawing.Size(179, 61)
        Me.lblAdventure.TabIndex = 7
        Me.lblAdventure.Text = "Choose Your Own Adventure"
        Me.lblAdventure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDice
        '
        Me.btnDice.BackColor = System.Drawing.Color.SlateGray
        Me.btnDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDice.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDice.Location = New System.Drawing.Point(275, 15)
        Me.btnDice.Name = "btnDice"
        Me.btnDice.Size = New System.Drawing.Size(132, 41)
        Me.btnDice.TabIndex = 2
        Me.btnDice.Text = "Let's Get Rolling"
        Me.btnDice.UseVisualStyleBackColor = False
        '
        'btnInsult
        '
        Me.btnInsult.BackColor = System.Drawing.Color.Teal
        Me.btnInsult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInsult.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsult.Location = New System.Drawing.Point(50, 15)
        Me.btnInsult.Name = "btnInsult"
        Me.btnInsult.Size = New System.Drawing.Size(132, 41)
        Me.btnInsult.TabIndex = 5
        Me.btnInsult.Text = "Insult Me"
        Me.btnInsult.UseVisualStyleBackColor = False
        '
        'btnAdventure
        '
        Me.btnAdventure.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdventure.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdventure.Location = New System.Drawing.Point(275, 15)
        Me.btnAdventure.Name = "btnAdventure"
        Me.btnAdventure.Size = New System.Drawing.Size(132, 41)
        Me.btnAdventure.TabIndex = 8
        Me.btnAdventure.Text = "Adventure Time!"
        Me.btnAdventure.UseVisualStyleBackColor = False
        '
        'btnPlayDice
        '
        Me.btnPlayDice.BackColor = System.Drawing.Color.SlateGray
        Me.btnPlayDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayDice.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayDice.Location = New System.Drawing.Point(275, 60)
        Me.btnPlayDice.Name = "btnPlayDice"
        Me.btnPlayDice.Size = New System.Drawing.Size(132, 41)
        Me.btnPlayDice.TabIndex = 3
        Me.btnPlayDice.Text = "How To Play"
        Me.btnPlayDice.UseVisualStyleBackColor = False
        '
        'btnPlayInsult
        '
        Me.btnPlayInsult.BackColor = System.Drawing.Color.Teal
        Me.btnPlayInsult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayInsult.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayInsult.Location = New System.Drawing.Point(50, 60)
        Me.btnPlayInsult.Name = "btnPlayInsult"
        Me.btnPlayInsult.Size = New System.Drawing.Size(132, 41)
        Me.btnPlayInsult.TabIndex = 6
        Me.btnPlayInsult.Text = "How To Play"
        Me.btnPlayInsult.UseVisualStyleBackColor = False
        '
        'btnPlayAdventure
        '
        Me.btnPlayAdventure.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPlayAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayAdventure.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAdventure.Location = New System.Drawing.Point(275, 60)
        Me.btnPlayAdventure.Name = "btnPlayAdventure"
        Me.btnPlayAdventure.Size = New System.Drawing.Size(132, 41)
        Me.btnPlayAdventure.TabIndex = 9
        Me.btnPlayAdventure.Text = "How To Play"
        Me.btnPlayAdventure.UseVisualStyleBackColor = False
        '
        'btnDeveloper
        '
        Me.btnDeveloper.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnDeveloper.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeveloper.Location = New System.Drawing.Point(71, 391)
        Me.btnDeveloper.Name = "btnDeveloper"
        Me.btnDeveloper.Size = New System.Drawing.Size(156, 46)
        Me.btnDeveloper.TabIndex = 10
        Me.btnDeveloper.Text = "About The Developer"
        Me.btnDeveloper.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExit.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(286, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 46)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit App"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'gBoxDice
        '
        Me.gBoxDice.Controls.Add(Me.lblDice)
        Me.gBoxDice.Controls.Add(Me.btnPlayDice)
        Me.gBoxDice.Controls.Add(Me.btnDice)
        Me.gBoxDice.Location = New System.Drawing.Point(32, 27)
        Me.gBoxDice.Name = "gBoxDice"
        Me.gBoxDice.Size = New System.Drawing.Size(450, 110)
        Me.gBoxDice.TabIndex = 12
        Me.gBoxDice.TabStop = False
        '
        'gBoxInsult
        '
        Me.gBoxInsult.Controls.Add(Me.btnInsult)
        Me.gBoxInsult.Controls.Add(Me.btnPlayInsult)
        Me.gBoxInsult.Controls.Add(Me.lblInsult)
        Me.gBoxInsult.Location = New System.Drawing.Point(32, 145)
        Me.gBoxInsult.Name = "gBoxInsult"
        Me.gBoxInsult.Size = New System.Drawing.Size(450, 110)
        Me.gBoxInsult.TabIndex = 13
        Me.gBoxInsult.TabStop = False
        '
        'gBoxAdventure
        '
        Me.gBoxAdventure.Controls.Add(Me.lblAdventure)
        Me.gBoxAdventure.Controls.Add(Me.btnPlayAdventure)
        Me.gBoxAdventure.Controls.Add(Me.btnAdventure)
        Me.gBoxAdventure.Location = New System.Drawing.Point(32, 265)
        Me.gBoxAdventure.Name = "gBoxAdventure"
        Me.gBoxAdventure.Size = New System.Drawing.Size(450, 110)
        Me.gBoxAdventure.TabIndex = 14
        Me.gBoxAdventure.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 452)
        Me.Controls.Add(Me.gBoxAdventure)
        Me.Controls.Add(Me.gBoxInsult)
        Me.Controls.Add(Me.gBoxDice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeveloper)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Choose A Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gBoxDice.ResumeLayout(False)
        Me.gBoxInsult.ResumeLayout(False)
        Me.gBoxAdventure.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDice As System.Windows.Forms.Label
    Friend WithEvents lblInsult As System.Windows.Forms.Label
    Friend WithEvents lblAdventure As System.Windows.Forms.Label
    Friend WithEvents btnDice As System.Windows.Forms.Button
    Friend WithEvents btnInsult As System.Windows.Forms.Button
    Friend WithEvents btnAdventure As System.Windows.Forms.Button
    Friend WithEvents btnPlayDice As System.Windows.Forms.Button
    Friend WithEvents btnPlayInsult As System.Windows.Forms.Button
    Friend WithEvents btnPlayAdventure As System.Windows.Forms.Button
    Friend WithEvents btnDeveloper As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gBoxDice As System.Windows.Forms.GroupBox
    Friend WithEvents gBoxInsult As System.Windows.Forms.GroupBox
    Friend WithEvents gBoxAdventure As System.Windows.Forms.GroupBox

End Class
