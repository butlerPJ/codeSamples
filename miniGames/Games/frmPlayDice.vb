Public Class frmPlayDice

    Private Sub frmPlayDice_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Display instructions to user
        lblPlayDice.Text = "Select how many sides you want on your dice from the drop down menu. When you are ready, click the 'Roll The Dice' button." & _
            "Take turns with your friends and see who can be the first to make it to a specified number."
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'close the How To Play window
        Me.Hide()
        'show the main menu
        frmMain.Show()
    End Sub
End Class
