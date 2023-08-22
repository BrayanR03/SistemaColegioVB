Imports System.Data.SqlClient

Public Class ReporteNotas
    Dim idapd As String
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")

    Public Property ApodNotReport() As String
        Get
            Return idapd
        End Get
        Set(value As String)
            idapd = value
        End Set
    End Property
    Private Sub ReporteNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarAreas()
    End Sub

    Private Sub CargarAreas()
        Dim id As String = ApodNotReport()
        Dim sql As String =
                        "SELECT A.AreaID,A.Descripcion AS Nombre
                        FROM AREAS A INNER JOIN DetalleAreas DET
                        ON A.AreaID=DET.AreaID
                        INNER JOIN ALUMNO AL ON AL.AlumnoID=DET.AlumnoID
                        INNER JOIN APODERADO AP ON AP.ApoderadoID=AL.ApoderadoID
                        INNER JOIN USUARIOS U ON U.UsuarioID=AP.UsuarioID
                        WHERE U.UsuarioID='" & id & "'"
        Dim dtCurso As New DataTable
        Dim daCurso As New SqlDataAdapter(sql, cnn)
        daCurso.Fill(dtCurso)
        cboArea.DataSource = dtCurso
        cboArea.DisplayMember = "Nombre"
        cboArea.ValueMember = "AreaID"
    End Sub
    Private Sub cmdRegresar_Click(sender As Object, e As EventArgs) Handles cmdRegresar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdBusqueda_Click(sender As Object, e As EventArgs) Handles cmdBusqueda.Click
        Me.BusquedaTotal()
    End Sub

    Private Sub BusquedaTotal()
        Dim id As String = ApodNotReport()
        Dim idaa As String = cboArea.SelectedValue.ToString
        Dim fechita As String = dtpfecha.Value.ToString
        fechita = Format(CDate(dtpfecha.Value.ToString), "yyyy-MM-dd")
        Dim sql As String = "EXEC NotasApoderado @areaid='" & idaa & "',@fecha='" & fechita & "',@usuapodid='" & id & "' "

        Dim dtTabla As New DataTable
        Dim daTabla As New SqlDataAdapter(sql, cnn)
        daTabla.Fill(dtTabla)
        dgvData.DataSource = dtTabla
    End Sub
End Class