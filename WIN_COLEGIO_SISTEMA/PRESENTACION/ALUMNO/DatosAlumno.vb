Imports System.Data.SqlClient

Public Class DatosAlumno
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim idalumuser As String

    Public Property AlumnoUserID() As String
        Get
            Return idalumuser
        End Get
        Set(value As String)
            idalumuser = value
        End Set
    End Property
    Private Sub DatosAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosAlumno()
    End Sub

    Private Sub CargarDatosAlumno()
        Dim id As String = AlumnoUserID()
        Dim sql As String = "SELECT AL.AlumnoID,al.Apellidos,Al.Nombres,al.Dni,al.FechaNacimiento,al.Telefono
                            FROM ALUMNO AL INNER JOIN USUARIOS US
                            ON AL.UsuarioID=US.UsuarioID
                            WHERE US.UsuarioID='" & id & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmAl As New SqlCommand(sql, cnn)
        rs = cmAl.ExecuteReader()
        While rs.Read()
            Dim fechita As String = rs(4).ToString
            fechita = Format(CDate(rs(4).ToString), "yyyy-MM-dd")
            txtid.Text = rs(0).ToString
            txtapellidos.Text = rs(1).ToString
            txtnombres.Text = rs(2).ToString
            txtdni.Text = rs(3).ToString
            txtfechanacimiento.Text = fechita
            txttelefono.Text = rs(5).ToString
        End While
        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class