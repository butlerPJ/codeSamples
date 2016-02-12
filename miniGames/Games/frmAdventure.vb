Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class frmAdventure
    'driver to use and the database file
    ' declare variables
    Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=game.accdb"
    Dim dbConnection As OleDbConnection
    Dim dbDataAdapter As OleDbDataAdapter
    Dim dbDataSet As DataSet
    Dim currentRow As Integer
    Dim savedGame As Integer

    ' if destination1 or 2 is empty, buttons are disabled as well as mnuSave

    Private Sub refreshButtons()
        With BindingContext(dbDataSet, "Story")
            If btnOne.Text = "" And btnTwo.Text = "" Then
                btnOne.Visible = False
                btnTwo.Visible = False
                mnuSave.Enabled = False
            End If
        End With

    End Sub

    Private Sub freshStart()
        ' construct connection object
        dbConnection = New OleDbConnection(CONNECTION_STRING)
        'open the connection
        dbConnection.Open()
        ' construct data adapter object
        ' select data from database
        dbDataAdapter = New OleDbDataAdapter("SELECT * FROM tblStory", dbConnection)
        'construct dataset to recieve all data from the database
        dbDataSet = New DataSet
        ' query the data and store in the dataset
        ' store data in a virtual table
        dbDataAdapter.Fill(dbDataSet, "Story")
        currentRow = 0
        mnuSave.Enabled = True

        If savedGame = 0 Then
            mnuLoad.Enabled = False
        Else
            mnuLoad.Enabled = True
        End If
        savedGame = 0
    End Sub
    Private Sub start()

        ' Display first row of data in lblOutput
        lblOutput.Text = Convert.ToString(dbDataSet.Tables("Story").Rows(currentRow).Item("plot"))
        ' Set button text to first row of data from database
        btnOne.Text = Convert.ToString(dbDataSet.Tables("Story").Rows(currentRow).Item("option1"))
        btnTwo.Text = Convert.ToString(dbDataSet.Tables("Story").Rows(currentRow).Item("option2"))
        ' set the picture to first image in database
        picBox.ImageLocation = Convert.ToString(dbDataSet.Tables("Story").Rows(currentRow).Item("image"))
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        ' set buttons to visible
        btnOne.Visible = True
        btnTwo.Visible = True


    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Dim writer As StreamWriter
        'construct a streamwriter object to target the selected file
        writer = File.CreateText("game.txt")
        'Write the contents of the game to streamwriter
        writer.Write(currentRow)
        writer.Flush()
        writer.Close()
        mnuLoad.Enabled = True
        savedGame = 0 + 1
        MessageBox.Show("Save Successful")



    End Sub

    Private Sub mnuLoad_Click(sender As Object, e As EventArgs) Handles mnuLoad.Click
        Dim reader As StreamReader
        'construct our stream reader (giving it the path of the file to read)
        reader = File.OpenText("game.txt")
        currentRow = Convert.ToInt32(reader.ReadToEnd)

        'release the text file
        reader.Close()
        start()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' display the about form
        frmDeveloper.Show()
    End Sub

    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        ' exit and close the application
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        ' start a new game
        freshStart()
        start()

    End Sub

    Private Sub frmAdventure_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' load the game on the first line of the database

        freshStart()
        start()
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        currentRow = Convert.ToInt32(dbDataSet.Tables("Story").Rows(currentRow).Item("destination1")) - 1
        start()
        refreshButtons()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click

        currentRow = Convert.ToInt32(dbDataSet.Tables("Story").Rows(currentRow).Item("destination2")) - 1
        start()
        refreshButtons()
    End Sub

    Private Sub frmAdventure_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' release the database
        dbConnection.Close()
        frmMain.Visible = True
    End Sub
End Class
