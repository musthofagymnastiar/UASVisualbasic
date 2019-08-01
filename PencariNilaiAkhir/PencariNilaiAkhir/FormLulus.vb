Imports MySql.Data.MySqlClient
Public Class FormLulus

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub FormLulus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub

    Sub tampilgrid()
        Call bukaDB()
        da = New MySqlDataAdapter("select id, nim, nama from datasiswa WHERE `datasiswa`.`status` = 1 ", conn)
        ds = New DataSet
        da.Fill(ds, "datasiswa")
        DataGridView1.DataSource = ds.Tables("datasiswa")
        DataGridView1.Enabled = True
    End Sub
End Class