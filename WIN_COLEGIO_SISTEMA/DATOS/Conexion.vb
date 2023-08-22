Imports System.Data.SqlClient
Public Class Conexion
    Private conexion As SqlConnection
    Private comandoSQL As SqlCommand
    Private daAdaptador As SqlDataAdapter
    Private dtTabla As DataTable


    Public Sub New()
        Me.conexion = New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    End Sub

    Public Sub AbrirConexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub
    Public Sub CerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
    Public Sub EjecutarInserrcionDatos(insertar As String)
        comandoSQL = New SqlCommand(insertar, conexion)
        comandoSQL.ExecuteNonQuery()
    End Sub
    Public Function EjecutarConsultaSQL(consulta As String) As DataTable
        dtTabla = New DataTable
        comandoSQL = New SqlCommand(consulta, conexion)
        daAdaptador = New SqlDataAdapter(comandoSQL)
        daAdaptador.Fill(dtTabla)
        Return dtTabla
    End Function

    Public Function EjecutarLecturaDatos(consulta As String) As Object
        comandoSQL = New SqlCommand(consulta, conexion)
        Return comandoSQL.ExecuteScalar()
    End Function
End Class

