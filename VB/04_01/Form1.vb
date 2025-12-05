
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=DAM209\SQLEXPRESS;Initial Catalog=VideojuegosDB;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVideojuego()
        LoadGenero()
    End Sub


    Private Sub LoadVideojuego()
        Dim query As String = "SELECT * FROM Videojuego"

        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub LoadGenero()
        Dim query As String = "SELECT * FROM Genero"

        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
    End Sub


End Class
