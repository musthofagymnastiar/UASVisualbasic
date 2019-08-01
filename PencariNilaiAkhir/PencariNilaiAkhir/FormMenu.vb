Public Class FormMenu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim logout As Integer = MsgBox("Apakah Anda Yakin Mau Keluar Dari Aplikasi Ini ?", MsgBoxStyle.YesNo)
        If logout = DialogResult.No Then

        ElseIf logout = DialogResult.Yes Then
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
    End Sub

    Private Sub DaftarSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSiswaToolStripMenuItem.Click
        DaftarSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub SiswaLulusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiswaLulusToolStripMenuItem.Click
        FormLulus.Show()
        Me.Hide()
    End Sub

    Private Sub MahasiswaTidakToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaTidakToolStripMenuItem.Click
        FormTidak.Show()
        Me.Hide()
    End Sub
End Class