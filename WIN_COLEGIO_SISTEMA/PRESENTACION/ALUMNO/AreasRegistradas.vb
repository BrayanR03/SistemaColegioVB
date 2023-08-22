Imports System.Data.SqlClient

Public Class AreasRegistradas
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim idal As String

    Public Property AlumIDArea() As String
        Get
            Return idal
        End Get
        Set(value As String)
            idal = value
        End Set
    End Property
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub AreasRegistradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarAreas()
    End Sub

    Private Sub CargarAreas()
        Dim id As String = AlumIDArea()
        Dim sql As String = "EXEC AreasAlumno @idusuario='" & id & "'"
        Dim dtarea As New DataTable
        Dim daarea As New SqlDataAdapter(sql, cnn)
        daarea.Fill(dtarea)
        dgvAreasDatos.DataSource = dtarea
    End Sub
End Class