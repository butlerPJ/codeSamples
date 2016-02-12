Public Class frmMain


    Private Sub btnDice_Click(sender As Object, e As EventArgs) Handles btnDice.Click
        frmDice.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        frmInsult.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdventure_Click(sender As Object, e As EventArgs) Handles btnAdventure.Click
        frmAdventure.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlayDice_Click(sender As Object, e As EventArgs) Handles btnPlayDice.Click
        frmPlayDice.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlayInsult_Click(sender As Object, e As EventArgs) Handles btnPlayInsult.Click
        frmPlayInsult.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlayAdventure_Click(sender As Object, e As EventArgs) Handles btnPlayAdventure.Click
        frmPlayAdventure.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs) Handles btnDeveloper.Click
        frmDeveloper.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmDeveloper.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()

    End Sub
End Class
