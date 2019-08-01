Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("KOLOM USERNAME BELUM ANDA ISI", MsgBoxStyle.Critical, "WARNING !")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("KOLOM PASSWORD BELUM ANDA ISI", MsgBoxStyle.Critical, "WARNING !")
            TextBox2.Focus()
        End If

        Call bukaDB()

        Dim txtbusername As String
        Dim txtbpassword As String

        txtbusername = TextBox1.Text
        txtbpassword = TextBox2.Text

        Dim str As String
        str = "SELECT * FROM admin WHERE username = '" + txtbusername + "' AND password= '" + txtbpassword + "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            If rd.Item("level") = "Admin" Then
                FormMenu.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
            End If
        Else
            MsgBox("Proses Login Gagal!", MsgBoxStyle.Critical, "Konfirmasi!!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If

    End Sub
End Class