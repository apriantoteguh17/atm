﻿Imports System.Data.SqlClient
Module Connection
    Dim con As SqlConnection

    Public Sub createConnection()

        con = New SqlConnection
        con.ConnectionString = "Data Source=MYCOMP\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=true;"
        'con.ConnectionString = "Data Source = ALLAH-88CB53937\Admin;Database Name=MedicalStore;Userid=Admin;password=maverick;"
        con.Open()

    End Sub

    Private Sub checkConnection()

        If con Is Nothing OrElse con.State = ConnectionState.Closed Then
            createConnection()
        End If

    End Sub

    Public Function getDataReader(ByVal SQL As String) As SqlDataReader

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        Return dr

    End Function

    Public Function getDataTable(ByVal SQL As String) As DataTable

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        Dim table As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(table)
        Return table

    End Function

    Public Sub executeQuery(ByVal SQL As String)

        checkConnection()
        Dim cmd As New SqlCommand(SQL, con)
        cmd.ExecuteNonQuery()

    End Sub

  End Module
