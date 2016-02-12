<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDice
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
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblArrows = New System.Windows.Forms.Label()
        Me.cBoxDice = New System.Windows.Forms.ComboBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Ravie", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.Color.DarkRed
        Me.lblHead.Location = New System.Drawing.Point(131, 42)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(228, 36)
        Me.lblHead.TabIndex = 3
        Me.lblHead.Text = "Pick A Dice"
        '
        'lblArrows
        '
        Me.lblArrows.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrows.ForeColor = System.Drawing.Color.DarkRed
        Me.lblArrows.Location = New System.Drawing.Point(105, 78)
        Me.lblArrows.Name = "lblArrows"
        Me.lblArrows.Size = New System.Drawing.Size(279, 51)
        Me.lblArrows.TabIndex = 4
        Me.lblArrows.Text = "Use the arrows on your keyboard to select a die"
        Me.lblArrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cBoxDice
        '
        Me.cBoxDice.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cBoxDice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxDice.FormattingEnabled = True
        Me.cBoxDice.Location = New System.Drawing.Point(134, 132)
        Me.cBoxDice.Name = "cBoxDice"
        Me.cBoxDice.Size = New System.Drawing.Size(216, 21)
        Me.cBoxDice.TabIndex = 5
        Me.cBoxDice.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(183, 166)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(116, 26)
        Me.btnRoll.TabIndex = 6
        Me.btnRoll.Text = "Roll The Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblNumbers
        '
        Me.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumbers.Font = New System.Drawing.Font("Ravie", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbers.ForeColor = System.Drawing.Color.Lime
        Me.lblNumbers.Location = New System.Drawing.Point(71, 205)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(336, 245)
        Me.lblNumbers.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'frmDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(490, 459)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.cBoxDice)
        Me.Controls.Add(Me.lblArrows)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDice"
        Me.Text = "Roll The Dice"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblArrows As System.Windows.Forms.Label
    Friend WithEvents cBoxDice As System.Windows.Forms.ComboBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
End Class
