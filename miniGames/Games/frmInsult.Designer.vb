<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsult
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.cboAdj = New System.Windows.Forms.ComboBox()
        Me.lblAdj = New System.Windows.Forms.Label()
        Me.btnInsult = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 47)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Enter your name"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Silver
        Me.txtInput.Location = New System.Drawing.Point(154, 52)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 8
        '
        'cboAdj
        '
        Me.cboAdj.BackColor = System.Drawing.Color.Silver
        Me.cboAdj.FormattingEnabled = True
        Me.cboAdj.Location = New System.Drawing.Point(25, 114)
        Me.cboAdj.Name = "cboAdj"
        Me.cboAdj.Size = New System.Drawing.Size(121, 21)
        Me.cboAdj.TabIndex = 9
        '
        'lblAdj
        '
        Me.lblAdj.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdj.Location = New System.Drawing.Point(161, 97)
        Me.lblAdj.Name = "lblAdj"
        Me.lblAdj.Size = New System.Drawing.Size(103, 47)
        Me.lblAdj.TabIndex = 10
        Me.lblAdj.Text = "Adjective Selection"
        '
        'btnInsult
        '
        Me.btnInsult.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInsult.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsult.ForeColor = System.Drawing.Color.Lime
        Me.btnInsult.Location = New System.Drawing.Point(285, 33)
        Me.btnInsult.Name = "btnInsult"
        Me.btnInsult.Size = New System.Drawing.Size(112, 39)
        Me.btnInsult.TabIndex = 11
        Me.btnInsult.Text = "Insult Me"
        Me.btnInsult.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Lime
        Me.btnClear.Location = New System.Drawing.Point(403, 33)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 39)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Maroon
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutput.Font = New System.Drawing.Font("Chiller", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txtOutput.Location = New System.Drawing.Point(25, 146)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(490, 224)
        Me.txtOutput.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "&Exit"
        '
        'frmInsult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(544, 381)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInsult)
        Me.Controls.Add(Me.lblAdj)
        Me.Controls.Add(Me.cboAdj)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInsult"
        Me.Text = "Sticks and Stones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents cboAdj As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdj As System.Windows.Forms.Label
    Friend WithEvents btnInsult As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
End Class
