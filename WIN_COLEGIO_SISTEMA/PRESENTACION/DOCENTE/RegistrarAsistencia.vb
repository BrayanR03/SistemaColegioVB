Imports System.Data.SqlClient

Public Class RegistrarAsistencia

    Dim userDocenteAsis As String
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    ''Dim idareauserdoc As String
    Public Property DocenteUser() As String
        Get
            Return userDocenteAsis
        End Get
        Set(ByVal value As String)
            userDocenteAsis = value
        End Set
    End Property
    Private Sub CargarArea()
        Dim iddocenteuser As String = DocenteUser()
        Dim sql As String = "select A.AreaID,A.Descripcion AS Nombre from AREAS A INNER JOIN DOCENTE D ON D.DocenteID=A.DocenteID where D.UsuarioID='" & iddocenteuser & "'"
        Dim dtArea As New DataTable
        Dim daArea As New SqlDataAdapter(sql, cnn)
        daArea.Fill(dtArea)
        cboArea.DataSource = dtArea
        cboArea.DisplayMember = "Nombre"
        cboArea.ValueMember = "AreaID"
    End Sub
    Private Sub RegistrarAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("id docente en usuarios")
        Console.WriteLine(DocenteUser())
        ''idareauserdoc = DocenteUser()
        Me.CargarArea()
        ''Me.CargarAlumnos()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "Id Alumno"
        dgvAlumnos.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "Datos Alumno"
        dgvAlumnos.Columns.Add(column2)

        Dim column3 As New DataGridViewComboBoxColumn()
        column3.HeaderText = "Asistencia"
        column3.Items.AddRange("A", "F", "T")
        dgvAlumnos.Columns.Add(column3)

        Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
            cnn.Open()

            Dim sql As String = "EXEC BuscarAlumnoAreaDocente @idusuariodocente='" & DocenteUser() & "'" ' Ajusta esta consulta a tu estructura de base de datos
            Using cmd As New SqlCommand(sql, cnn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim idAlumno As String = reader("Id").ToString()
                    Dim nombreAlumno As String = reader("DatosAlumno").ToString()

                    dgvAlumnos.Rows.Add(idAlumno, nombreAlumno, "A") ' Puedes ajustar "A" a la asistencia que desees inicialmente
                End While
            End Using
        End Using
        dgvAlumnos.AutoResizeColumn(1)
    End Sub


    Private Sub CargarAlumnos()
        Dim udocente As String = DocenteUser()
        Dim sql As String = "EXEC BuscarAlumnoAreaDocente @idusuariodocente='" & udocente & "'"
        Dim dtAlumno As New DataTable
        Dim daAlumno As New SqlDataAdapter(sql, cnn)
        daAlumno.Fill(dtAlumno)
        dgvAlumnos.DataSource = dtAlumno
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.GrabarAsistencia()
        Me.Dispose()
    End Sub
    Private Sub GrabarAsistencia()

        If dgvAlumnos.Rows.Count > 0 Then
            Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
                cnn.Open()

                For Each row As DataGridViewRow In dgvAlumnos.Rows
                    If Not row.IsNewRow Then ' Verifica si la fila no es una fila nueva (si la hay)
                        Dim idAlumno As String
                        Dim asistencia As String
                        idAlumno = row.Cells(0).Value.ToString()
                        asistencia = row.Cells(2).Value.ToString()

                        Dim areaid As String = cboArea.SelectedValue.ToString
                        Dim fechita As String = dtpFechaAsistencia.Value.ToString
                        fechita = Format(CDate(dtpFechaAsistencia.Value), "yyyy-MM-dd")
                        Dim sql As String = "EXEC RegistrarAsistencia @asistencia='" & asistencia & "',@fecha='" & fechita & "',@areaid='" & areaid & "',@alumnoid='" & idAlumno & "'"
                        Using cmd As New SqlCommand(sql, cnn)
                            cmd.Parameters.AddWithValue("@asistencia", asistencia)
                            cmd.Parameters.AddWithValue("@fecha", fechita)
                            cmd.Parameters.AddWithValue("@areaid", areaid)
                            cmd.Parameters.AddWithValue("@alumnoid", idAlumno)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next

            End Using
            MessageBox.Show("Asistencia registrada exitosamente.")
        Else
            MessageBox.Show("No hay datos en el DataGridView.")
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    'Private Sub GrabarAsistencia()
    '    'If dgvAlumnos.Rows.Count > 0 Then

    '    Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    '            cnn.Open()

    '        For Each row As DataGridViewRow In dgvAlumnos.Rows

    '            Dim idAlumno As String
    '            Dim asistencia As String
    '            idAlumno = row.Cells(0).Value.ToString()
    '            asistencia = row.Cells(2).Value.ToString()

    '            Dim areaid As String = cboArea.SelectedValue.ToString
    '                Dim fechita As String = dtpFechaAsistencia.Value.ToString
    '                fechita = Format(CDate(dtpFechaAsistencia.Value), "yyyy-MM-dd")
    '                Dim sql As String = "EXEC RegistrarAsistencia @asistencia='" & asistencia & "',@fecha='" & fechita & "',@areaid='" & areaid & "',@alumnoid='" & idAlumno & "'"
    '                Using cmd As New SqlCommand(sql, cnn)
    '                    cmd.Parameters.AddWithValue("@asistencia", asistencia)
    '                    cmd.Parameters.AddWithValue("@fecha", fechita)
    '                    cmd.Parameters.AddWithValue("@areaid", areaid)
    '                    cmd.Parameters.AddWithValue("@alumnoid", idAlumno)
    '                    cmd.ExecuteNonQuery()
    '                End Using


    '        Next

    '        MessageBox.Show("Asistencia registrada exitosamente.")
    '        End Using

    'End Sub
End Class