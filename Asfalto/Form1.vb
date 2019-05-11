

Imports System.Drawing.Printing

Public Class Form1

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        'prova stampa
        Label4.Text = Lavori_corso1.Label1.Text

        '  PrintDocument1.PrinterSettings.Copies = 1
        '  PrintDocument1.Print()

        'prova stampa2
        ReportViewer1.PrintDialog()




    End Sub







    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        led.Top = Button1.Top
        Calcolo_materiale1.BringToFront()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        led.Top = Button2.Top
        Verifica_spessore1.BringToFront()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        led.Top = Button3.Top
        Lavori_corso1.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        led.Top = Button4.Top
        Cantiere_41.BringToFront()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        led.Top = Button5.Top
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        led.Top = Button6.Top
    End Sub

    Private Sub ButtonP1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonP1_GotFocus(sender As Object, e As EventArgs)


    End Sub



    Private Sub Lavori_corso1_Load(sender As Object, e As EventArgs) Handles Lavori_corso1.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonMat2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Label4.Text, Label4.Font, Brushes.Black, 100, 100)




    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
