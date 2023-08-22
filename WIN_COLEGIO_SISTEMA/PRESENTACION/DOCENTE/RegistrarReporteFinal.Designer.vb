<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarReporteFinal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdatosalumno = New System.Windows.Forms.TextBox()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDataNotasEv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkB4 = New System.Windows.Forms.CheckBox()
        Me.chkB3 = New System.Windows.Forms.CheckBox()
        Me.chkB2 = New System.Windows.Forms.CheckBox()
        Me.chkB1 = New System.Windows.Forms.CheckBox()
        Me.cboC4 = New System.Windows.Forms.ComboBox()
        Me.cboC3 = New System.Windows.Forms.ComboBox()
        Me.cboC2 = New System.Windows.Forms.ComboBox()
        Me.cboC1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.cmdRegistrarNota = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataNotasEv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREA:"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(95, 52)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(203, 24)
        Me.cboArea.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdatosalumno)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 183)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Alumno"
        '
        'txtdatosalumno
        '
        Me.txtdatosalumno.Location = New System.Drawing.Point(127, 141)
        Me.txtdatosalumno.Name = "txtdatosalumno"
        Me.txtdatosalumno.ReadOnly = True
        Me.txtdatosalumno.Size = New System.Drawing.Size(279, 22)
        Me.txtdatosalumno.TabIndex = 6
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(127, 71)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(165, 22)
        Me.txtidalumno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Datos Alumno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id Alumno:"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(307, 23)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(99, 28)
        Me.txtbuscar.TabIndex = 2
        Me.txtbuscar.Text = "BUSCAR"
        Me.txtbuscar.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(127, 29)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(165, 22)
        Me.txtDni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dni Alumno:"
        '
        'dgvDataNotasEv
        '
        Me.dgvDataNotasEv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataNotasEv.Location = New System.Drawing.Point(14, 99)
        Me.dgvDataNotasEv.Name = "dgvDataNotasEv"
        Me.dgvDataNotasEv.RowHeadersWidth = 51
        Me.dgvDataNotasEv.RowTemplate.Height = 24
        Me.dgvDataNotasEv.Size = New System.Drawing.Size(728, 172)
        Me.dgvDataNotasEv.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "FILTRAR NOTAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(98, 117)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpFecha.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Nota:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cboC4)
        Me.GroupBox2.Controls.Add(Me.cboC3)
        Me.GroupBox2.Controls.Add(Me.cboC2)
        Me.GroupBox2.Controls.Add(Me.cboC1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dgvDataNotasEv)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 500)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Evidencias Notas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkB4)
        Me.GroupBox3.Controls.Add(Me.chkB3)
        Me.GroupBox3.Controls.Add(Me.chkB2)
        Me.GroupBox3.Controls.Add(Me.chkB1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(608, 68)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PERIODO"
        '
        'chkB4
        '
        Me.chkB4.AutoSize = True
        Me.chkB4.Location = New System.Drawing.Point(424, 32)
        Me.chkB4.Name = "chkB4"
        Me.chkB4.Size = New System.Drawing.Size(108, 20)
        Me.chkB4.TabIndex = 3
        Me.chkB4.Text = "BIMESTRE 4"
        Me.chkB4.UseVisualStyleBackColor = True
        '
        'chkB3
        '
        Me.chkB3.AutoSize = True
        Me.chkB3.Location = New System.Drawing.Point(278, 32)
        Me.chkB3.Name = "chkB3"
        Me.chkB3.Size = New System.Drawing.Size(108, 20)
        Me.chkB3.TabIndex = 2
        Me.chkB3.Text = "BIMESTRE 3"
        Me.chkB3.UseVisualStyleBackColor = True
        '
        'chkB2
        '
        Me.chkB2.AutoSize = True
        Me.chkB2.Location = New System.Drawing.Point(133, 32)
        Me.chkB2.Name = "chkB2"
        Me.chkB2.Size = New System.Drawing.Size(111, 20)
        Me.chkB2.TabIndex = 1
        Me.chkB2.Text = " BIMESTRE 2"
        Me.chkB2.UseVisualStyleBackColor = True
        '
        'chkB1
        '
        Me.chkB1.AutoSize = True
        Me.chkB1.Location = New System.Drawing.Point(6, 32)
        Me.chkB1.Name = "chkB1"
        Me.chkB1.Size = New System.Drawing.Size(108, 20)
        Me.chkB1.TabIndex = 0
        Me.chkB1.Text = "BIMESTRE 1"
        Me.chkB1.UseVisualStyleBackColor = True
        '
        'cboC4
        '
        Me.cboC4.FormattingEnabled = True
        Me.cboC4.Items.AddRange(New Object() {"Seleccionar", "AD", "A", "B", "C"})
        Me.cboC4.Location = New System.Drawing.Point(604, 439)
        Me.cboC4.Name = "cboC4"
        Me.cboC4.Size = New System.Drawing.Size(144, 24)
        Me.cboC4.TabIndex = 12
        '
        'cboC3
        '
        Me.cboC3.FormattingEnabled = True
        Me.cboC3.Items.AddRange(New Object() {"Seleccionar", "AD", "A", "B", "C"})
        Me.cboC3.Location = New System.Drawing.Point(414, 439)
        Me.cboC3.Name = "cboC3"
        Me.cboC3.Size = New System.Drawing.Size(148, 24)
        Me.cboC3.TabIndex = 11
        '
        'cboC2
        '
        Me.cboC2.FormattingEnabled = True
        Me.cboC2.Items.AddRange(New Object() {"Seleccionar", "AD", "A", "B", "C"})
        Me.cboC2.Location = New System.Drawing.Point(217, 439)
        Me.cboC2.Name = "cboC2"
        Me.cboC2.Size = New System.Drawing.Size(145, 24)
        Me.cboC2.TabIndex = 10
        '
        'cboC1
        '
        Me.cboC1.FormattingEnabled = True
        Me.cboC1.Items.AddRange(New Object() {"Seleccionar", "AD", "A", "B", "C"})
        Me.cboC1.Location = New System.Drawing.Point(14, 439)
        Me.cboC1.Name = "cboC1"
        Me.cboC1.Size = New System.Drawing.Size(145, 24)
        Me.cboC1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(595, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Competencia 4:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Competencia 3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Competencia 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Competencia 1:"
        '
        'cmdRegistrarNota
        '
        Me.cmdRegistrarNota.Location = New System.Drawing.Point(15, 743)
        Me.cmdRegistrarNota.Name = "cmdRegistrarNota"
        Me.cmdRegistrarNota.Size = New System.Drawing.Size(150, 50)
        Me.cmdRegistrarNota.TabIndex = 14
        Me.cmdRegistrarNota.Text = "REGISTRAR NOTA"
        Me.cmdRegistrarNota.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(199, 742)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(136, 51)
        Me.cmdSalir.TabIndex = 15
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'RegistrarReporteFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 863)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdRegistrarNota)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarReporteFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarReporteFinal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataNotasEv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdatosalumno As TextBox
    Friend WithEvents txtidalumno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbuscar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDataNotasEv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkB4 As CheckBox
    Friend WithEvents chkB3 As CheckBox
    Friend WithEvents chkB2 As CheckBox
    Friend WithEvents chkB1 As CheckBox
    Friend WithEvents cboC4 As ComboBox
    Friend WithEvents cboC3 As ComboBox
    Friend WithEvents cboC2 As ComboBox
    Friend WithEvents cboC1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents cmdRegistrarNota As Button
    Friend WithEvents cmdSalir As Button
End Class
