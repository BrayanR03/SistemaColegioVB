<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaAsistencias
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaActAsistencia = New System.Windows.Forms.DateTimePicker()
        Me.dgvAlumnoAsistencia = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdActualizaAsistencia = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgvAlumnoAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREA:"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(88, 42)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(195, 24)
        Me.cboArea.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA:"
        '
        'dtpFechaActAsistencia
        '
        Me.dtpFechaActAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaActAsistencia.Location = New System.Drawing.Point(88, 101)
        Me.dtpFechaActAsistencia.Name = "dtpFechaActAsistencia"
        Me.dtpFechaActAsistencia.Size = New System.Drawing.Size(195, 22)
        Me.dtpFechaActAsistencia.TabIndex = 3
        '
        'dgvAlumnoAsistencia
        '
        Me.dgvAlumnoAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnoAsistencia.Location = New System.Drawing.Point(27, 145)
        Me.dgvAlumnoAsistencia.Name = "dgvAlumnoAsistencia"
        Me.dgvAlumnoAsistencia.RowHeadersWidth = 51
        Me.dgvAlumnoAsistencia.RowTemplate.Height = 24
        Me.dgvAlumnoAsistencia.Size = New System.Drawing.Size(693, 563)
        Me.dgvAlumnoAsistencia.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdActualizaAsistencia
        '
        Me.cmdActualizaAsistencia.Location = New System.Drawing.Point(27, 727)
        Me.cmdActualizaAsistencia.Name = "cmdActualizaAsistencia"
        Me.cmdActualizaAsistencia.Size = New System.Drawing.Size(192, 40)
        Me.cmdActualizaAsistencia.TabIndex = 6
        Me.cmdActualizaAsistencia.Text = "ACTUALIZAR ASISTENCIA"
        Me.cmdActualizaAsistencia.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(249, 727)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(184, 40)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'ListaAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 797)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdActualizaAsistencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvAlumnoAsistencia)
        Me.Controls.Add(Me.dtpFechaActAsistencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListaAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaAsistencias"
        CType(Me.dgvAlumnoAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaActAsistencia As DateTimePicker
    Friend WithEvents dgvAlumnoAsistencia As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdActualizaAsistencia As Button
    Friend WithEvents cmdSalir As Button
End Class
