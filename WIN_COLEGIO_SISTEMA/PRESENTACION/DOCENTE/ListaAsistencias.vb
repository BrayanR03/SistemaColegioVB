Imports System.Data.SqlClient

Public Class ListaAsistencias
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim listUserDocente As String

    Public Property ListaAsistenciaUsuarioDocente() As String
        Get
            Return listUserDocente
        End Get
        Set(ByVal value As String)
            listUserDocente = value
        End Set
    End Property
    Private Sub ListaAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarAreas()
        Me.BuscarAsistenciaAlumnos()
    End Sub

    Private Sub CargarAreas()
        Dim iddocenteuser As String = ListaAsistenciaUsuarioDocente()
        Dim sql As String = "select A.AreaID as AreaID,A.Descripcion AS Nombre from AREAS A INNER JOIN DOCENTE D ON D.DocenteID=A.DocenteID where D.UsuarioID='" & iddocenteuser & "'"
        Dim dtAre As New DataTable
        Dim daAre As New SqlDataAdapter(sql, cnn)
        daAre.Fill(dtAre)
        cboArea.DataSource = dtAre
        cboArea.DisplayMember = "Nombre"
        cboArea.ValueMember = "AreaID"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BuscarAsistenciaAlumnos()
    End Sub

    Private Sub BuscarAsistenciaAlumnos()
        dgvAlumnoAsistencia.Columns.Clear() ' Limpiar las columnas existentes
        dgvAlumnoAsistencia.Rows.Clear()
        Dim fechita As String = dtpFechaActAsistencia.Value.ToString
        fechita = Format(CDate(dtpFechaActAsistencia.Value.ToString), "yyyy-MM-dd")
        Dim areaid As String = cboArea.SelectedValue.ToString
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "Id Alumno"
        dgvAlumnoAsistencia.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "Datos Alumno"
        dgvAlumnoAsistencia.Columns.Add(column2)

        Dim column3 As New DataGridViewComboBoxColumn()
        column3.HeaderText = "Asistencia"
        column3.Items.AddRange("A", "F", "T")
        dgvAlumnoAsistencia.Columns.Add(column3)

        Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
            cnn.Open()

            Dim sql As String = "EXEC ActBuscarAsistencia @fecha='" & fechita & "',@areaid='" & areaid & "'" ' Ajusta esta consulta a tu estructura de base de datos
            Using cmd As New SqlCommand(sql, cnn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim idAlumno As String = reader("Id").ToString()
                    Dim nombreAlumno As String = reader("DatosAlumno").ToString()
                    Dim Asiscombo As String = reader("Asistencia").ToString
                    dgvAlumnoAsistencia.Rows.Add(idAlumno, nombreAlumno, Asiscombo) ' Puedes ajustar "A" a la asistencia que desees inicialmente
                End While
            End Using
        End Using
        dgvAlumnoAsistencia.AutoResizeColumn(1)

    End Sub

    Private Sub cmdActualizaAsistencia_Click(sender As Object, e As EventArgs) Handles cmdActualizaAsistencia.Click
        Me.ActualizaAsistenciaAlumnos()
    End Sub

    Private Sub ActualizaAsistenciaAlumnos()
        If dgvAlumnoAsistencia.Rows.Count > 0 Then
            Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
                cnn.Open()

                For Each row As DataGridViewRow In dgvAlumnoAsistencia.Rows
                    If Not row.IsNewRow Then ' Verifica si la fila no es una fila nueva (si la hay)
                        Dim idAlumno As String
                        Dim asistencia As String
                        idAlumno = row.Cells(0).Value.ToString()
                        asistencia = row.Cells(2).Value.ToString()

                        Dim areaid As String = cboArea.SelectedValue.ToString
                        Dim fechita As String = dtpFechaActAsistencia.Value.ToString
                        fechita = Format(CDate(dtpFechaActAsistencia.Value), "yyyy-MM-dd")
                        Dim sql As String = "EXEC ActualizarAsistencia @fecha='" & fechita & "',@asistencia='" & asistencia & "',@areaid='" & areaid & "',@alumnoid='" & idAlumno & "'"
                        Using cmd As New SqlCommand(sql, cnn)
                            cmd.Parameters.AddWithValue("@asistencia", asistencia)
                            cmd.Parameters.AddWithValue("@fecha", fechita)
                            cmd.Parameters.AddWithValue("@areaid", areaid)
                            cmd.Parameters.AddWithValue("@alumnoid", idAlumno)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Asistencia registrada exitosamente.")
            End Using
        Else
            MessageBox.Show("No hay datos en el DataGridView.")
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class