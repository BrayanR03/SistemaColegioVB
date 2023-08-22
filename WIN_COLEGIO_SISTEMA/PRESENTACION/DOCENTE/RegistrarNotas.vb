Imports System.Data.SqlClient

Public Class RegistrarNotas
    Dim iddocusu As String
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")

    Public Property NotaCursoUsuario() As String
        Get
            Return iddocusu
        End Get
        Set(ByVal value As String)
            iddocusu = value
        End Set
    End Property

    Private Sub RegistrarNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarAreas()

        Dim column0 As New DataGridViewTextBoxColumn()
        column0.HeaderText = "IdCompetencia"
        dgvdatosnotas.Columns.Add(column0)

        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "Competencia"
        dgvdatosnotas.Columns.Add(column1)


        Dim column2 As New DataGridViewComboBoxColumn()
        column2.HeaderText = "Evidencia Aprendizaje 1"
        column2.Items.AddRange("AD", "A", "B", "C", "SC")
        dgvdatosnotas.Columns.Add(column2)

        Dim column3 As New DataGridViewComboBoxColumn()
        column3.HeaderText = "Evidencia Aprendizaje 2"
        column3.Items.AddRange("AD", "A", "B", "C", "SC")
        dgvdatosnotas.Columns.Add(column3)

        Dim column4 As New DataGridViewComboBoxColumn()
        column4.HeaderText = "Evidencia Aprendizaje 3"
        column4.Items.AddRange("AD", "A", "B", "C", "SC")
        dgvdatosnotas.Columns.Add(column4)

        Dim column5 As New DataGridViewComboBoxColumn()
        column5.HeaderText = "Evidencia Aprendizaje 4"
        column5.Items.AddRange("AD", "A", "B", "C", "SC")
        dgvdatosnotas.Columns.Add(column5)

        Using cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
            cnn.Open()
            Dim idar As String = cboAreas.SelectedValue.ToString
            Dim sql As String = "EXEC BuscaCompetenciaNotas @areaid='" & idar & "',@iduser='" & NotaCursoUsuario() & "'" ' Ajusta esta consulta a tu estructura de base de datos
            Using cmd As New SqlCommand(sql, cnn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim competenciaid As String = reader("CompetenciaID").ToString()
                    Dim competencia As String = reader("Competencia").ToString()

                    dgvdatosnotas.Rows.Add(competenciaid, competencia, "SC", "SC", "SC", "SC") ' Puedes ajustar "A" a la asistencia que desees inicialmente
                End While
            End Using
        End Using
        dgvdatosnotas.AutoResizeColumn(1)
    End Sub

    Private Sub CargarAreas()
        Dim id As String = NotaCursoUsuario()
        Dim sql As String = "SELECT A.AreaID as AreaID,A.Descripcion AS Nombre FROM AREAS A INNER JOIN DOCENTE D
                             ON A.DocenteID=D.DocenteID
                             INNER JOIN USUARIOS U ON U.UsuarioID=D.UsuarioID
                             WHERE U.UsuarioID='" & id & "'"
        Dim dtCurso As New DataTable
        Dim daCurso As New SqlDataAdapter(sql, cnn)
        daCurso.Fill(dtCurso)
        cboAreas.DataSource = dtCurso
        cboAreas.DisplayMember = "Nombre"
        cboAreas.ValueMember = "AreaID"
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Me.BuscarDatos()
    End Sub

    Private Sub BuscarDatos()
        Dim dni As String = txtdni.Text.Trim()

        If String.IsNullOrEmpty(dni) Then
            MessageBox.Show("Debes ingresar un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim userid As String = NotaCursoUsuario()
        Dim areaid As String = cboAreas.SelectedValue.ToString
        Dim sql As String = "EXEC BuscarAlumno @dni='" & dni & "',@areaid='" & areaid & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmDat As New SqlCommand(sql, cnn)
        rs = cmDat.ExecuteReader()
        While rs.Read()
            txtidalumno.Text = rs(0).ToString
            txtdatosalumno.Text = rs(1).ToString
        End While
        cnn.Close()
    End Sub



    Private Sub cmdRegistrar_Click(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        Me.RegistrarNotasAlumnos()
    End Sub

    Private Sub RegistrarNotasAlumnos()
        Dim dni As String = txtdni.Text.Trim()

        If String.IsNullOrEmpty(dni) Then
            MessageBox.Show("Debes ingresar un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim idar As String = cboAreas.SelectedValue.ToString
        Dim fechita As String = dtpfechaexperiencia.Value.ToString
        fechita = Format(CDate(dtpfechaexperiencia.Value.ToString), "yyyy-MM-dd")


        For Each row As DataGridViewRow In dgvdatosnotas.Rows
            Dim competenciaid As String = row.Cells(0).Value?.ToString()
            Dim competencia As String = row.Cells(1).Value?.ToString()

            If Not String.IsNullOrEmpty(competenciaid) Or Not String.IsNullOrEmpty(competencia) Then
                Console.WriteLine($"CompetenciaID:{competenciaid}, Competencia: {competencia}")

                For columnIndex As Integer = 2 To dgvdatosnotas.Columns.Count - 1
                    Dim evidenciaNombre As String = dgvdatosnotas.Columns(columnIndex).HeaderText
                    Dim valorNota As String = row.Cells(columnIndex).Value?.ToString()

                    If Not String.IsNullOrEmpty(valorNota) Then
                        ' Aquí ejecuta la sentencia SQL para registrar los valores
                        Dim sql As String = "EXEC EvidenciaRegistroNotas @fecharegistro='" & fechita & "', @nota='" & valorNota & "', @alumnoid='" & dni & "', @areaid='" & idar & "', @evidencia='" & evidenciaNombre & "', @competenciaid='" & competenciaid & "'"
                        Using connection As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
                            connection.Open()
                            Using cmd As New SqlCommand(sql, connection)
                                cmd.Parameters.AddWithValue("@fecharegistro", fechita)
                                cmd.Parameters.AddWithValue("@nota", valorNota)
                                cmd.Parameters.AddWithValue("@alumnoid", txtidalumno.Text.Trim)
                                cmd.Parameters.AddWithValue("@areaid", idar)
                                cmd.Parameters.AddWithValue("@evidencia", evidenciaNombre)
                                cmd.Parameters.AddWithValue("@competenciaid", competenciaid)
                                ' Agrega aquí los demás parámetros según corresponda
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                        MessageBox.Show("Se Registro Las Notas")
                    End If
                Next
            End If
        Next


        ' Crear una lista de nombres de columnas
        'Dim nombresColumnas As New List(Of String)()
        'For Each columna As DataGridViewColumn In dgvdatosnotas.Columns
        '    nombresColumnas.Add(columna.HeaderText)
        'Next

        'For Each row As DataGridViewRow In dgvdatosnotas.Rows
        '    Dim competenciaid As String = row.Cells(0).Value?.ToString()
        '    Dim competencia As String = row.Cells(1).Value?.ToString()

        '    Dim valoresPorColumna As New List(Of String)()
        '    For Each celda As DataGridViewCell In row.Cells
        '        valoresPorColumna.Add(celda.Value?.ToString())
        '    Next

        '    If Not String.IsNullOrEmpty(competenciaid) Or Not String.IsNullOrEmpty(competencia) Then
        '        Console.WriteLine($"CompetenciaID:{competenciaid}, Competencia: {competencia}")

        '        For i As Integer = 2 To valoresPorColumna.Count - 1
        '            Dim nombreColumna As String = nombresColumnas(i)
        '            Dim valorCelda As String = valoresPorColumna(i)

        '            If Not String.IsNullOrEmpty(valorCelda) Then
        '                Console.WriteLine($"{nombreColumna}: {valorCelda}")
        '            End If
        '        Next
        '    End If
        'Next


        'For Each row As DataGridViewRow In dgvdatosnotas.Rows
        '    Dim competenciaid As String = row.Cells(0).Value?.ToString()
        '    Dim competencia As String = row.Cells(1).Value?.ToString() ' Valor de la columna "Competencia"
        '    Dim ea1 As String = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "") ' Valor de la columna "Evidencia Aprendizaje 1"
        '    Dim ea2 As String = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "") ' Valor de la columna "Evidencia Aprendizaje 2"
        '    Dim ea3 As String = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "") ' Valor de la columna "Evidencia Aprendizaje 3"
        '    Dim ea4 As String = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "") ' Valor de la columna "Evidencia Aprendizaje 4"

        '    ' Verificar si al menos una de las celdas de experiencia de aprendizaje contiene un valor no nulo
        '    If Not String.IsNullOrEmpty(ea1) Or Not String.IsNullOrEmpty(ea2) Or Not String.IsNullOrEmpty(ea3) Or Not String.IsNullOrEmpty(ea4) Then
        '        ' Hacer lo que necesites con los valores capturados
        '        Console.WriteLine($"CompetenciaID:{competenciaid}, Competencia: {competencia}, EA1: {ea1}, EA2: {ea2}, EA3: {ea3}, EA4: {ea4}")
        '    End If
        'Next


        'Dim fechita As String = dtpfechaexperiencia.Value.ToString
        'fechita = Format(CDate(dtpfechaexperiencia.Value.ToString), "yyyy-MM-dd")

        'Dim sql As String = "EXEC RegistrarNotaExperiencia @nota='',@fecharegistro='',@competenciaid=''"


    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class