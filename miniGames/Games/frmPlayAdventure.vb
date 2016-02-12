Public Class frmPlayAdventure

    Private Sub frmPlayAdventure_Load(sender As Object, e As EventArgs) Handles Me.Load
        'display instruction message to user
        lblPlayAdventure.Text = "Read the scenario provided and make your decision by clicking the button that contains your desired choice. " & _
                                "The next scenario will be displayed. If your decision leads to an ending outcome, a 'Game Over' or 'You've Won' " & _
                                "message will be displayed. You may either then exit the game or start a new one. You may also save your game " & _
                                "progress at any point during the game."
    End Sub



    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'close the How To Play instruction window
        Me.Hide()
        'show the main menu
        frmMain.Show()

    End Sub
End Class
