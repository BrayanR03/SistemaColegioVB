<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarAsistencia
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
        Me.dtpFechaAsistencia = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaAsistencia
        '
        Me.dtpFechaAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsistencia.Location = New System.Drawing.Point(434, 54)
        Me.dtpFechaAsistencia.Name = "dtpFechaAsistencia"
        Me.dtpFechaAsistencia.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaAsistencia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FECHA ASISTENCIA:"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Location = New System.Drawing.Point(45, 114)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.RowHeadersWidth = 51
        Me.dgvAlumnos.RowTemplate.Height = 24
        Me.dgvAlumnos.Size = New System.Drawing.Size(693, 563)
        Me.dgvAlumnos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AREA:"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(45, 60)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(197, 24)
        Me.cboArea.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 691)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "GRABAR ASISTENCIA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(240, 691)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(113, 49)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'RegistrarAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 761)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dtpFechaAsistencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarAsistencia"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaAsistencia As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdSalir As Button
End Class
