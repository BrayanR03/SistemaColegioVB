Imports System.Data.SqlClient

Public Class ReporteAlumnoAsistencias
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim idAlumnoU As String

    Public Property AlumnoUssID() As String
        Get
            Return idAlumnoU
        End Get
        Set(ByVal value As String)
            idAlumnoU = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub ReporteAlumnoAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarReporte()
        Me.CargarCurso()
        Me.CargaDataCursoAsistencia()
    End Sub
    Private Sub CargarCurso()
        Dim sql As String = "SELECT AreaID,Descripcion as Nombre FROM AREAS"
        Dim dtArea As New DataTable
        Dim daArea As New SqlDataAdapter(sql, cnn)
        daArea.Fill(dtArea)
        cboArea.DataSource = dtArea
        cboArea.DisplayMember = "Nombre"
        cboArea.ValueMember = "AreaID"
    End Sub

    Private Sub CargarReporte()
        Dim idap As String = AlumnoUssID()
        Dim sql As String = "exec ReporteAsistenciasCursosAlumnoS @apodid='" & idap & "'"
        Dim dtReportApod As New DataTable
        cnn.Open()
        Dim daReportApod As New SqlDataAdapter(sql, cnn)
        daReportApod.Fill(dtReportApod)
        dgvDataResumenAsistencia.DataSource = dtReportApod
    End Sub

    Private Sub CargaDataCursoAsistencia()
        Dim idco As String = cboArea.SelectedValue.ToString
        Dim idual As String = AlumnoUssID()
        Dim sql As String = "SELECT FORMAT(ASI.FechaAsistencia,'dd MMM yyyy') as Fecha,Estado=CASE WHEN ASI.Asistencia='A' then 'Asistió'
                        WHEN ASI.Asistencia='T' then 'Tardanza'
                        else 'No Asistió'end
                                 FROM ASISTENCIAS ASI INNER JOIN ALUMNO AL ON AL.AlumnoID=ASI.AlumnoID
								 INNER JOIN USUARIOS U ON U.UsuarioID=AL.UsuarioID
                                 where U.UsuarioID='" & idual & "' and AreaID='" & idco & "'"
        Dim dtCD As New DataTable
        Dim daCD As New SqlDataAdapter(sql, cnn)
        daCD.Fill(dtCD)
        dgvDataAsistencia.DataSource = dtCD
        ' Ajustar el tamaño de las columnas para abarcar todo el espacio
        For Each columna As DataGridViewColumn In dgvDataResumenAsistencia.Columns
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        ' Asegurarse de que todas las columnas se ajusten automáticamente
        dgvDataAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.CargaGrafico()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.CargaDataCursoAsistencia()
    End Sub

    Private Sub CargaGrafico()
        Try
            Dim totalFilas As Integer = dgvDataAsistencia.Rows.Count
            Dim totalAsistencias As Integer = 0
            Dim totalFaltas As Integer = 0
            Dim totalTardanzas As Integer = 0

            ' Calcular totales de asistencias, faltas y tardanzas basados en la columna "ESTADO"
            For i As Integer = 0 To totalFilas - 1
                Dim estadoCell As DataGridViewCell = dgvDataAsistencia.Rows(i).Cells("Estado")
                Dim estado As String = If(estadoCell.Value IsNot Nothing, estadoCell.Value.ToString(), "")

                Select Case estado
                    Case "Asistió"
                        totalAsistencias += 1
                    Case "No Asistió"
                        totalFaltas += 1
                    Case "Tardanza"
                        totalTardanzas += 1
                End Select
            Next

            ' Crear el gráfico circular
            Chart1.Series(0).Points.Clear()
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
            Chart1.Series(0).IsValueShownAsLabel = True

            ' Agregar puntos al gráfico
            Chart1.Series(0).Points.AddXY("Asistencias", totalAsistencias)
            Chart1.Series(0).Points.AddXY("Faltas", totalFaltas)
            Chart1.Series(0).Points.AddXY("Tardanzas", totalTardanzas)

            ' Actualizar los datos del gráfico
            Chart1.DataBind()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class