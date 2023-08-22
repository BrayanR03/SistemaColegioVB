Public Class MenuDocente
    Dim idUsuarioLogin As String

    Public Property idUsuari() As String
        Get
            Return idUsuarioLogin
        End Get
        Set(ByVal value As String)
            idUsuarioLogin = value
        End Set
    End Property

    Private Sub CERRARSESIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        If Login Is Nothing Then
            Login = New Login()
        End If

        ' Muestra el formulario de inicio de sesión
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub DATOSDOCENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSDOCENTEToolStripMenuItem.Click
        Dim datosdocen As New DatosDocente()
        datosdocen.UsuarioDocente = idUsuari()
        datosdocen.Show()
    End Sub

    Private Sub MenuDocente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MessageBox.Show("Advertencia, Debes Cerrar Sesión")
            e.Cancel = True ' Cancela el cierre del formulario
        End If
    End Sub

    Private Sub REGISTRARASISTENCIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARASISTENCIASToolStripMenuItem.Click
        Dim asisdocente As New RegistrarAsistencia()
        asisdocente.DocenteUser = idUsuari()
        asisdocente.Show()
    End Sub

    Private Sub LISTAASISTENCIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTAASISTENCIASToolStripMenuItem.Click
        Dim ventlistaasistencia As New ListaAsistencias()
        ventlistaasistencia.ListaAsistenciaUsuarioDocente = idUsuari()
        ventlistaasistencia.Show()
    End Sub

    Private Sub REGISTRARNOTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARNOTASToolStripMenuItem.Click
        Dim ventregnotas As New RegistrarNotas()
        ventregnotas.NotaCursoUsuario = idUsuari()
        ventregnotas.Show()
    End Sub

    Private Sub AREASREGISTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AREASREGISTRADASToolStripMenuItem.Click

    End Sub

    Private Sub REGISTRARREPORTEFINALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRARREPORTEFINALToolStripMenuItem.Click
        Dim ventrepf As New RegistrarReporteFinal()
        ventrepf.DocenteUser = idUsuari()
        ventrepf.Show()
    End Sub
End Class