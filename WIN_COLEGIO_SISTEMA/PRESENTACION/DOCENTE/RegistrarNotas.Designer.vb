<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarNotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAreas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdatosalumno = New System.Windows.Forms.TextBox()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvdatosnotas = New System.Windows.Forms.DataGridView()
        Me.dtpfechaexperiencia = New System.Windows.Forms.DateTimePicker()
        Me.cmdRegistrar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvdatosnotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREA:"
        '
        'cboAreas
        '
        Me.cboAreas.FormattingEnabled = True
        Me.cboAreas.Location = New System.Drawing.Point(136, 60)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(168, 24)
        Me.cboAreas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DNI ALUMNO:"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(136, 107)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(168, 22)
        Me.txtdni.TabIndex = 4
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(334, 104)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(99, 29)
        Me.cmdBuscar.TabIndex = 5
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdatosalumno)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 159)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Alumno"
        '
        'txtdatosalumno
        '
        Me.txtdatosalumno.Location = New System.Drawing.Point(9, 101)
        Me.txtdatosalumno.Name = "txtdatosalumno"
        Me.txtdatosalumno.ReadOnly = True
        Me.txtdatosalumno.Size = New System.Drawing.Size(308, 22)
        Me.txtdatosalumno.TabIndex = 2
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(106, 40)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.ReadOnly = True
        Me.txtidalumno.Size = New System.Drawing.Size(211, 22)
        Me.txtidalumno.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID ALUMNO:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvdatosnotas)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(783, 342)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notas Detalladas"
        '
        'dgvdatosnotas
        '
        Me.dgvdatosnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatosnotas.Location = New System.Drawing.Point(9, 93)
        Me.dgvdatosnotas.Name = "dgvdatosnotas"
        Me.dgvdatosnotas.RowHeadersWidth = 51
        Me.dgvdatosnotas.RowTemplate.Height = 24
        Me.dgvdatosnotas.Size = New System.Drawing.Size(723, 204)
        Me.dgvdatosnotas.TabIndex = 4
        '
        'dtpfechaexperiencia
        '
        Me.dtpfechaexperiencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaexperiencia.Location = New System.Drawing.Point(504, 54)
        Me.dtpfechaexperiencia.Name = "dtpfechaexperiencia"
        Me.dtpfechaexperiencia.Size = New System.Drawing.Size(253, 22)
        Me.dtpfechaexperiencia.TabIndex = 8
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.Location = New System.Drawing.Point(30, 725)
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.Size = New System.Drawing.Size(161, 49)
        Me.cmdRegistrar.TabIndex = 9
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(225, 725)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(158, 49)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WIN_COLEGIO_SISTEMA.My.Resources.Resources.Docente
        Me.PictureBox1.Location = New System.Drawing.Point(504, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'RegistrarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 824)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.dtpfechaexperiencia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAreas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarNotas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvdatosnotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboAreas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdatosalumno As TextBox
    Friend WithEvents txtidalumno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvdatosnotas As DataGridView
    Friend WithEvents dtpfechaexperiencia As DateTimePicker
    Friend WithEvents cmdRegistrar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
