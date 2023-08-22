Imports System.Data.SqlClient
Public Class Login
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdIniciarSesion_Click(sender As Object, e As EventArgs) Handles cmdIniciarSesion.Click
        Me.Validar()
        txtusuario.Text = ""
        txtcontraseña.Text = ""

    End Sub

    Private Sub Validar()
        Dim idusuario As String
        Dim rol As String
        If txtusuario.Text.Trim() = "" Or txtcontraseña.Text.Trim() = "" Then
            MessageBox.Show("Error, Datos Inválidos")
            Return
        End If
        Dim sql As String = "EXEC ValidarSesion @usuario='" & txtusuario.Text.Trim & "',@contraseña='" & txtcontraseña.Text.Trim & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmValidacionLogin As New SqlCommand(sql, cnn)
        rs = cmValidacionLogin.ExecuteReader()
        While rs.Read()
            idusuario = rs(0).ToString
            rol = rs(1).ToString

            If idusuario.Equals("") Or rol.Equals("") Then
            MessageBox.Show("Error, Datos Inválidos", Err.Description)
                cnn.Close()
            Else
                If rol.Equals("DOCENTE") Then
                    MessageBox.Show("BIENVENIDO")
                    Dim MenuDocent As New MenuDocente
                    MenuDocent.idUsuari = idusuario
                    Me.Hide()
                    MenuDocent.Show()
                    ''cnn.Close()
                ElseIf rol.Equals("APODERADO") Then
                    MessageBox.Show("BIENVENIDO")
                    Dim MenuApod As New MenuApoderado
                    MenuApod.UserApoderado = idusuario
                    Me.Hide()
                    MenuApod.Show()
                    '' cnn.Close()
                Else
                    MessageBox.Show("BIENVENIDO")
                    Dim MenuAlum As New MenuAlumno
                    MenuAlum.AlumnoIDGeneral = idusuario
                    Me.Hide()
                    MenuAlum.Show()
                    ''cnn.Close()
                End If
        End If
        End While
        cnn.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontraseña.KeyPress
        ' Verifica si la tecla presionada es un número o la tecla BackSpace (borrar)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un número ni BackSpace, cancela la entrada de caracteres
            MessageBox.Show("Solo Se Aceptan Numeros")
            e.Handled = True
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        txtusuario.Text = txtusuario.Text.ToUpper()
        txtusuario.SelectionStart = txtusuario.Text.Length
    End Sub
End Class