Imports MySql.Data.MySqlClient
Public Class DaftarSiswa

    Private Sub DaftarSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilsiswa()
        Call tampilgrid()
        Call aturDGV()
        Label13.Visible = False
    End Sub

    Sub tampilsiswa()
        Call bukaDB()
        cmd = New MySqlCommand("select nim from siswa", conn)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item("nim"))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        cmd = New MySqlCommand("SELECT * from siswa WHERE nim='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Label3.Text = rd.Item("nama")
        Else
            MsgBox("Nim tidak terdaftar")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call bukaDB()
        Dim simpan As String = "insert into datasiswa values ('" & "''" & "','" & ComboBox1.SelectedItem & "','" & Label3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label13.Text & "')"
        cmd = New MySqlCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        Label10.Text = "DATA BERHASIL DI SIMPAN"
        Call tampilgrid()
    End Sub

    Sub aturDGV()
        Try
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "NIM"
            DataGridView1.Columns(2).HeaderText = "Nama Mahasiswa"
            DataGridView1.Columns(3).HeaderText = "Nilai UTS"
            DataGridView1.Columns(4).HeaderText = "Nilai UAS"
            DataGridView1.Columns(5).HeaderText = "Nilai Tugas"
            DataGridView1.Columns(6).HeaderText = "Nilai Akhir"
            DataGridView1.Columns(7).HeaderText = "Keterangan"
        Catch ex As Exception

        End Try
    End Sub

    Sub tampilgrid()
        Call bukaDB()
        da = New MySqlDataAdapter("select * from datasiswa", conn)
        ds = New DataSet
        da.Fill(ds, "datasiswa")
        DataGridView1.DataSource = ds.Tables("datasiswa")
        DataGridView1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = (TextBox1.Text * 50 / 100) + (TextBox2.Text * 30 / 100) + (TextBox3.Text * 20 / 100)

        If TextBox4.Text > 75 Then
            TextBox5.Text = "LULUS"
        Else
            TextBox5.Text = "TIDAK LULUS"
        End If

        If TextBox5.Text = "LULUS" Then
            Label13.Text = "1"
        Else
            Label13.Text = "2"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.Text = ""
        Label3.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class