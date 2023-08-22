Public Class MenuApoderado
    Dim idUserApod As String

    Public Property UserApoderado() As String
        Get
            Return idUserApod
        End Get
        Set(ByVal value As String)
            idUserApod = value
        End Set
    End Property
    Private Sub ReporteAsistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteAsistenciasToolStripMenuItem.Click
        Dim ventRepor As New ReporteAsistencias()
        ventRepor.AlumnoApoderadoID = UserApoderado()
        ventRepor.Show()
    End Sub

    Private Sub DATOSAPODERADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSAPODERADOToolStripMenuItem.Click
        Dim ventdd As New DatosApoderado()
        ventdd.idUSApod = UserApoderado()
        ventdd.Show()
    End Sub

    Private Sub CERRARSESIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        If Login Is Nothing Then
            Login = New Login()
        End If

        ' Muestra el formulario de inicio de sesión
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub REPORTENOTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTENOTASToolStripMenuItem.Click
        Dim reportnotas As New ReporteNotas()
        reportnotas.ApodNotReport = UserApoderado()
        reportnotas.Show()
    End Sub

    Private Sub MenuApoderado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            MessageBox.Show("Advertencia, Debes Cerrar Sesión")
            e.Cancel = True ' Cancela el cierre del formulario
        End If
    End Sub
End Class