Public Class frmDice

    Dim randomGen As Random
    Dim dice As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'load the dice options into the combo box
        cBoxDice.Items.Add("4")
        cBoxDice.Items.Add("6")
        cBoxDice.Items.Add("8")
        cBoxDice.Items.Add("10")
        cBoxDice.Items.Add("12")
        cBoxDice.Items.Add("20")

        cBoxDice.SelectedIndex = 0

    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        randomGen = New Random
        lblNumbers.Text = Convert.ToString(randomGen.Next(1, dice + 1))
    End Sub

    Private Sub cBoxDice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxDice.SelectedIndexChanged
        dice = Convert.ToInt32(cBoxDice.SelectedItem)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
