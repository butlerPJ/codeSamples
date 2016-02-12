Public Class frmDeveloper

    Private Sub frmDeveloper_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAbout.Text = "PJ Butler/First Year IT Student/2014"
        picBox.Image = Image.FromFile("me.jpg")
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
