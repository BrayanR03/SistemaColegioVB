Imports System.Data.SqlClient

Public Class ListarAsistencias
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim idListAlum As String

    Public Property ListaAlumnoID() As String
        Get
            Return idListAlum
        End Get
        Set(value As String)
            idListAlum = value
        End Set
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub ListarAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarAreas()
    End Sub

    Private Sub cargarAreas()
        Dim id As String = ListaAlumnoID()
        Dim sql As String = "EXEC AreasAlumnoBuscar @idusuario='" & id & "'"
        Dim dtareaalumno As New DataTable
        cnn.Open()
        Dim daareaalum As New SqlDataAdapter(sql, cnn)
        daareaalum.Fill(dtareaalumno)
        cboAreas.DataSource = dtareaalumno
        cboAreas.DisplayMember = "AREA"
        cboAreas.ValueMember = "ID"
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs)
        Me.BusquedaAlumno()
    End Sub

    Private Sub BusquedaAlumno()
        Dim idarr As String = cboAreas.SelectedValue.ToString
        Dim iduu As String = ListaAlumnoID()
        Dim sql As String = "SELECT ASI.AsistenciaID,ASI.FechaAsistencia AS FECHA,ASI.Asistencia AS ASISTENCIA
                                FROM ASISTENCIAS ASI INNER JOIN AREAS A
                                ON ASI.AreaID=A.AreaID
                                INNER JOIN ALUMNO AL ON AL.AlumnoID=ASI.AlumnoID
                                INNER JOIN USUARIOS US ON US.UsuarioID=AL.UsuarioID
                                WHERE A.AreaID='" & idarr & "' and US.UsuarioID='" & iduu & "'"
        Dim dtDatita As New DataTable

        Dim daDatita As New SqlDataAdapter(sql, cnn)
        daDatita.Fill(dtDatita)
        dgvDataAsistencia.DataSource = dtDatita
    End Sub

    Private Sub cmdBuscar_Click_1(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.BusquedaAlumno()
    End Sub
End Class