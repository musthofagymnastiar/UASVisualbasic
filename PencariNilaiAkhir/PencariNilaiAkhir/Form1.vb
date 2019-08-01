Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = (TextBox1.Text * 50 / 100) + (TextBox2.Text * 30 / 100) + (TextBox3.Text * 20 / 100)

        If TextBox4.Text > 75 Then
            TextBox5.Text = "LULUS"
        Else
            TextBox5.Text = "TIDAK LULUS"
        End If

        If TextBox5.Text = "LULUS" Then
            Label6.Text = "1"
        Else
            Label6.Text = "2"
        End If
    End Sub
End Class
