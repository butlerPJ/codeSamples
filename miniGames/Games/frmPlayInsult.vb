Public Class frmPlayInsult

    Private Sub frmPlayInsult_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPlayInsult.Text = "Enter your name in the textbox provided, then select from the dropbox the number of adjectives you want the " & _
                             "insults to contain. Once this is done, click the 'Insult Me' button and enjoy the fun! You may clear the app and " & _
                             "start over at any time by clicking the 'Clear' button"

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class
