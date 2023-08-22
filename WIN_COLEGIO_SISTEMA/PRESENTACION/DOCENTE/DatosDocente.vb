Imports System.Data.SqlClient
Public Class DatosDocente

    Dim idUsuarioDocente As String
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Public Property UsuarioDocente() As String
        Get
            Return idUsuarioDocente
        End Get
        Set(ByVal value As String)
            idUsuarioDocente = value
        End Set
    End Property
    Private Sub DatosDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosDocente()
    End Sub

    Private Sub CargarDatosDocente()
        Dim usdocente As String = UsuarioDocente()
        Dim sql As String = "SELECT DocenteID,Apellidos,Nombres,Dni,FechaNacimiento,Telefono FROM DOCENTE where UsuarioID='" & usdocente & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmDocenteDat As New SqlCommand(sql, cnn)
        rs = cmDocenteDat.ExecuteReader()
        While rs.Read()
            Dim fecha As String
            fecha = Format(CDate(rs(4).ToString), "yyyy-MM-dd")
            txtiddocente.Text = rs(0).ToString
            txtapellidos.Text = rs(1).ToString
            txtnombres.Text = rs(2).ToString
            txtdni.Text = rs(3).ToString
            txtfechanacimiento.Text = fecha
            txttelefono.Text = rs(5).ToString
        End While
        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class