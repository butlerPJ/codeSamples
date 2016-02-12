Public Class frmInsult

    'declare global variables
    Dim randomGen As Random
    Dim adjNumber As Integer
    Dim aryAdj() As String = {"Clumsy ", "Reeking ", "Disgustulating ", "Slobbering ", "Puny ", "Gutless ", "Decrepit ", "Dilapidated ", "Crusty ", "Spineless "}
    Dim aryNoun() As String = {"Goblin", "Dirtbag", "Insect", "Creep", "Cesspool", "Jerk"}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'add adjectives to combo box
        cboAdj.Items.Add("1")
        cboAdj.Items.Add("2")
        cboAdj.Items.Add("3")
        'set combo box index to 1st adjective
        cboAdj.SelectedIndex = 0
        adjNumber = cboAdj.SelectedIndex
    End Sub

    'changes selected index
    Private Sub cboAdj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAdj.SelectedIndexChanged
        adjNumber = cboAdj.SelectedIndex
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all text boxes and resets combo box
        txtOutput.Clear()
        txtInput.Clear()
        cboAdj.SelectedIndex = 0
        adjNumber = cboAdj.SelectedIndex
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        'declare local variables
        randomGen = New Random
        Dim noun As String
        Dim adjHold As String = ""
        Dim txtHold As String
        Dim x As Integer = adjNumber

        'check to see if user has entered their name
        If (txtInput.Text = "") = False Then
            txtHold = txtOutput.Text
            txtOutput.Text = txtInput.Text & " is a "
            'randomly select an adjective from the array index
            Do
                'specify a range of the array length, randomly select a number from the range, apply selected number to array index, convert to string and place in adjHold
                adjHold = Convert.ToString(aryAdj(randomGen.Next(0, aryAdj.Length)))
                'append the variables to the output text
                txtOutput.AppendText(adjHold)

                'do loop until specified number of adjectives have been selected
                x = x - 1
            Loop Until x = -1
            noun = Convert.ToString(aryNoun(randomGen.Next(0, aryNoun.Length)))

            'append the selected noun to the output
            txtOutput.Text = txtOutput.Text & noun & "." & vbCrLf & txtHold
        Else
            MessageBox.Show("Please enter a name in the field provided")
        End If



    End Sub


End Class
