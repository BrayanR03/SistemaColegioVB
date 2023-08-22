Imports System.Data.SqlClient

Public Class RegistrarReporteFinal
    Dim cnn As New SqlConnection("Server=LAPTOP-D05MS1MQ\SQLEXPRESS;Database=BD_COLEGIO_SR;Integrated Security=true")
    Dim iddoce As String

    Public Property DocenteUser() As String
        Get
            Return iddoce
        End Get
        Set(ByVal value As String)
            iddoce = value
        End Set
    End Property
    Private Sub RegistrarReporteFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboC1.SelectedIndex = 0
        cboC2.SelectedIndex = 0
        cboC3.SelectedIndex = 0
        cboC4.SelectedIndex = 0
        Me.cargarArea()
    End Sub
    Private Sub cargarArea()
        Dim iddocentearea As String = DocenteUser()
        Dim sql As String = "SELECT AreaID,Descripcion as Nombre FROM AREAS where DocenteID='" & iddocentearea & "'"
        Dim dtArea As New DataTable
        Dim daArea As New SqlDataAdapter(sql, cnn)
        daArea.Fill(dtArea)
        cboArea.DataSource = dtArea
        cboArea.DisplayMember = "Nombre"
        cboArea.ValueMember = "AreaID"
    End Sub

    Private Sub txtbuscar_Click(sender As Object, e As EventArgs) Handles txtbuscar.Click
        Me.BuscarAlumno()
    End Sub
    Private Sub BuscarAlumno()
        Dim dni As String = txtDni.Text.Trim()

        If String.IsNullOrEmpty(dni) Then
            MessageBox.Show("Debes ingresar un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim sql As String = "SELECT AlumnoID,Apellidos+', '+Nombres as Datos FROM ALUMNO where Dni='" & dni & "'"
        cnn.Open()
        Dim rs As SqlDataReader
        Dim cmAlum As New SqlCommand(sql, cnn)
        rs = cmAlum.ExecuteReader()
        While rs.Read()
            txtidalumno.Text = rs(0).ToString
            txtdatosalumno.Text = rs(1).ToString
        End While
        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BusquedaNotasEv()
    End Sub

    Private Sub BusquedaNotasEv()
        Dim dni As String = txtDni.Text.Trim()

        If String.IsNullOrEmpty(dni) Then
            MessageBox.Show("Debes ingresar un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim fechita As String = dtpFecha.Value.ToString
        fechita = Format(CDate(dtpFecha.Value.ToString), "yyyy-MM-dd")
        Dim idar As String = cboArea.SelectedValue.ToString
        Dim sql As String = "EXEC DataNotasEvidencias @alumnoid='" & dni & "',@areaid='" & idar & "',@fecha='" & fechita & "'"
        Dim dtData As New DataTable
        Dim daData As New SqlDataAdapter(sql, cnn)
        daData.Fill(dtData)
        dgvDataNotasEv.DataSource = dtData
    End Sub

    Private Sub cmdRegistrarNota_Click(sender As Object, e As EventArgs) Handles cmdRegistrarNota.Click
        Me.RegistraNotaFinalReporte()
    End Sub

    Private Sub RegistraNotaFinalReporte()
        Dim dni As String = txtDni.Text.Trim()

        If String.IsNullOrEmpty(dni) Then
            MessageBox.Show("Debes ingresar un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim idar As String = cboArea.SelectedValue.ToString
        Dim c1, c2, c3, c4 As String
        Dim idperiodo As String = ""
        If chkB1.Checked = True Then
            idperiodo = "1"
        ElseIf chkB2.Checked = True Then
            idperiodo = "2"
        ElseIf chkB3.Checked = True Then
            idperiodo = "3"
        ElseIf chkB4.Checked = True Then
            idperiodo = "4"
        Else
            MessageBox.Show("Debes Seleccionar Un Periodo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        c1 = cboC1.SelectedItem.ToString
        c2 = cboC2.SelectedItem.ToString
        c3 = cboC3.SelectedItem.ToString
        c4 = cboC4.SelectedItem.ToString
        cnn.Open()
        Dim sql As String = "EXEC RFinalNotas @areaid='" & idar & "',@alumnoid='" & dni & "',@c1='" & c1 & "',@C2='" & c2 & "',@C3='" & c3 & "',
                            @c4='" & c4 & "',@periodo='" & idperiodo & "'"
        Dim cmRegis As New SqlCommand(sql, cnn)
        Try
            cmRegis.ExecuteNonQuery()
            MessageBox.Show("Se Registro Las Notas Correctamente")
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show("Error Al Registrar Los Datos", Err.Description)
            cnn.Close()
        End Try
    End Sub

    Private Sub chkB4_CheckedChanged(sender As Object, e As EventArgs) Handles chkB4.CheckedChanged
        chkB4.Checked = True
        chkB1.Checked = False
        chkB2.Checked = False
        chkB3.Checked = False
    End Sub

    Private Sub chkB3_CheckedChanged(sender As Object, e As EventArgs) Handles chkB3.CheckedChanged
        chkB3.Checked = True
        chkB1.Checked = False
        chkB2.Checked = False
        chkB4.Checked = False
    End Sub

    Private Sub chkB2_CheckedChanged(sender As Object, e As EventArgs) Handles chkB2.CheckedChanged
        chkB2.Checked = True
        chkB1.Checked = False
        chkB4.Checked = False
        chkB3.Checked = False
    End Sub

    Private Sub chkB1_CheckedChanged(sender As Object, e As EventArgs) Handles chkB1.CheckedChanged
        chkB1.Checked = True
        chkB4.Checked = False
        chkB2.Checked = False
        chkB3.Checked = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class