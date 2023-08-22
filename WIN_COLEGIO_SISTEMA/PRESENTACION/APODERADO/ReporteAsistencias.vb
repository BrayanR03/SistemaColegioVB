Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ReporteAsistencias
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim idAlumnoApoderado As String

    Public Property AlumnoApoderadoID() As String
        Get
            Return idAlumnoApoderado
        End Get
        Set(ByVal value As String)
            idAlumnoApoderado = value
        End Set
    End Property
    Private Sub ReporteAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(AlumnoApoderadoID())
        Me.CargarDatosAlumno()
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


    Private Sub CargarDatosAlumno()
        Dim id As String = AlumnoApoderadoID()
        Dim sql As String = "SELECT AL.AlumnoID,AL.Apellidos+', '+AL.Nombres AS DATOS
                             FROM ALUMNO AL INNER JOIN APODERADO AP
                             ON AP.ApoderadoID=AL.ApoderadoID
                             INNER JOIN USUARIOS U ON U.UsuarioID=AP.UsuarioID
                             WHERE U.UsuarioID='" & id & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmAlumData As New SqlCommand(sql, cnn)
        rs = cmAlumData.ExecuteReader()
        While rs.Read()
            txtidalumno.Text = rs(0).ToString
            txtdatosalumno.Text = rs(1).ToString
        End While
        cnn.Close()
    End Sub
    Private Sub CargarReporte()
        Dim idap As String = AlumnoApoderadoID()
        Dim sql As String = "exec ReporteAsistenciasCursos @apodid='" & idap & "'"
        Dim dtReportApod As New DataTable
        Dim daReportApod As New SqlDataAdapter(sql, cnn)
        daReportApod.Fill(dtReportApod)
        dgvDatosAsistencia.DataSource = dtReportApod
    End Sub

    Private Sub CargaDataCursoAsistencia()
        Dim idco As String = cboArea.SelectedValue.ToString

        Dim sql As String = "SELECT FORMAT(FechaAsistencia,'dd MMM yyyy') as Fecha,Estado=CASE WHEN Asistencia='A' then 'Asistió'
                        WHEN Asistencia='T' then 'Tardanza'
                        else 'No Asistió'end
                                 FROM ASISTENCIAS
                                 where AlumnoID='" & txtidalumno.Text.Trim & "' and AreaID='" & idco & "'"
        Dim dtCD As New DataTable
        Dim daCD As New SqlDataAdapter(sql, cnn)
        daCD.Fill(dtCD)
        dgvFechaEstadoAsistencia.DataSource = dtCD
        ' Ajustar el tamaño de las columnas para abarcar todo el espacio
        For Each columna As DataGridViewColumn In dgvFechaEstadoAsistencia.Columns
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        ' Asegurarse de que todas las columnas se ajusten automáticamente
        dgvFechaEstadoAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.CargaGrafico()
    End Sub

    Private Sub cmdBusqueda_Click(sender As Object, e As EventArgs) Handles cmdBusqueda.Click
        Me.CargaDataCursoAsistencia()
    End Sub

    Private Sub CargaGrafico()
        Try
            Dim totalFilas As Integer = dgvFechaEstadoAsistencia.Rows.Count
            Dim totalAsistencias As Integer = 0
            Dim totalFaltas As Integer = 0
            Dim totalTardanzas As Integer = 0

            ' Calcular totales de asistencias, faltas y tardanzas basados en la columna "ESTADO"
            For i As Integer = 0 To totalFilas - 1
                Dim estadoCell As DataGridViewCell = dgvFechaEstadoAsistencia.Rows(i).Cells("Estado")
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
            MessageBox.Show(ex.Message, "aca error")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Dispose()
    End Sub
End Class