﻿Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub bukaDB()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=nilaiakhirvb;"
            conn = New MySqlConnection(str)

            If conn.State = ConnectionState.Closed Then

                conn.Open()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

