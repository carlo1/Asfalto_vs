Public Class calcolo_materiale
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonMat2_Click(sender As Object, e As EventArgs) Handles ButtonMat2.Click
        ButtonMat2.BackColor = Form1.Panel3.BackColor
        ButtonMat2.ForeColor = Form1.Label2.ForeColor
        ButtonMat1.BackColor = Form1.Button10.BackColor
        ButtonMat1.ForeColor = Form1.Button10.ForeColor
        ButtonMat3.BackColor = Form1.Button10.BackColor
        ButtonMat3.ForeColor = Form1.Button10.ForeColor
        ButtonMat4.BackColor = Form1.Button10.BackColor
        ButtonMat4.ForeColor = Form1.Button10.ForeColor






    End Sub

    Private Sub ButtonMat1_Click(sender As Object, e As EventArgs) Handles ButtonMat1.Click
        ButtonMat1.BackColor = Form1.Panel3.BackColor
        ButtonMat1.ForeColor = Form1.Label2.ForeColor
        ButtonMat2.BackColor = Form1.Button10.BackColor
        ButtonMat2.ForeColor = Form1.Button10.ForeColor
        ButtonMat3.BackColor = Form1.Button10.BackColor
        ButtonMat3.ForeColor = Form1.Button10.ForeColor
        ButtonMat4.BackColor = Form1.Button10.BackColor
        ButtonMat4.ForeColor = Form1.Button10.ForeColor


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Select()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
        If IsNumeric(TextBox1.Text) = False Then
            MessageBox.Show("Solo numeri")
        End If

        Dim numero1 As Double
        numero1 = TextBox1.Text

        'Dim num2 As Double

        'num2 = TextBox2.Text
        'Dim numero3 As Double
        'numero3 = TextBox3.Text

        Dim totale As Double



        'numero3 = TextBox3.Text
        totale = numero1 + 10
        TextBox_T.Text = totale





    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox_T.TextChanged

    End Sub
End Class
