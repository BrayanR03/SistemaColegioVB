Imports System.Data.SqlClient

Public Class DatosApoderado
    Dim idu As String
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")

    Public Property idUSApod() As String
        Get
            Return idu
        End Get
        Set(ByVal value As String)
            idu = value
        End Set
    End Property

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub DatosApoderado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarApoderadoData()
    End Sub
    Private Sub CargarApoderadoData()
        Dim usdocente As String = idUSApod()
        Dim sql As String = "SELECT ApoderadoID,Apellidos,Nombres,Dni,FechaNacimiento,Telefono FROM APODERADO where UsuarioID='" & usdocente & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmDocenteDat As New SqlCommand(sql, cnn)
        rs = cmDocenteDat.ExecuteReader()
        While rs.Read()
            Dim fecha As String
            fecha = Format(CDate(rs(4).ToString), "yyyy-MM-dd")
            txtid.Text = rs(0).ToString
            txtapellidos.Text = rs(1).ToString
            txtnombres.Text = rs(2).ToString
            txtdni.Text = rs(3).ToString
            txtfechanacimiento.Text = fecha
            txttelefono.Text = rs(5).ToString
        End While
        cnn.Close()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class