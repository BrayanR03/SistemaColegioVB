Public Class MenuAlumno
    Dim idAlumnoGeneral As String

    Public Property AlumnoIDGeneral() As String
        Get
            Return idAlumnoGeneral
        End Get
        Set(value As String)
            idAlumnoGeneral = value
        End Set
    End Property
    Private Sub AREASREGISTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AREASREGISTRADASToolStripMenuItem.Click
        Dim area As New AreasRegistradas()
        area.AlumIDArea = AlumnoIDGeneral()
        area.Show()
    End Sub

    Private Sub DATOSALUMNOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSALUMNOToolStripMenuItem.Click
        Dim datosalum As New DatosAlumno()
        datosalum.AlumnoUserID = AlumnoIDGeneral()
        datosalum.Show()
    End Sub

    Private Sub REPORTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTEToolStripMenuItem.Click
        Dim repo As New ReporteAlumnoAsistencias()
        repo.AlumnoUssID = AlumnoIDGeneral()
        repo.Show()
    End Sub

    Private Sub LISTAASISTENCIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTAASISTENCIASToolStripMenuItem.Click
        Dim ventlis As New ListarAsistencias()
        ventlis.ListaAlumnoID = AlumnoIDGeneral()
        ventlis.Show()
    End Sub

    Private Sub MenuAlumno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MessageBox.Show("Advertencia, Debes Cerrar Sesión")
            e.Cancel = True ' Cancela el cierre del formulario
        End If
    End Sub

    Private Sub CERRARSESIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARSESIÓNToolStripMenuItem.Click
        If Login Is Nothing Then
            Login = New Login()
        End If

        ' Muestra el formulario de inicio de sesión
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub MenuAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class