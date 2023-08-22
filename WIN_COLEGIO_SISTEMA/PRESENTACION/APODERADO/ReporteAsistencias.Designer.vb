<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteAsistencias
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvDatosAsistencia = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdatosalumno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdBusqueda = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.dgvFechaEstadoAsistencia = New System.Windows.Forms.DataGridView()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDatosAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFechaEstadoAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatosAsistencia
        '
        Me.dgvDatosAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosAsistencia.Location = New System.Drawing.Point(19, 54)
        Me.dgvDatosAsistencia.Name = "dgvDatosAsistencia"
        Me.dgvDatosAsistencia.RowHeadersWidth = 51
        Me.dgvDatosAsistencia.RowTemplate.Height = 24
        Me.dgvDatosAsistencia.Size = New System.Drawing.Size(675, 193)
        Me.dgvDatosAsistencia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ALUMNO:"
        '
        'txtdatosalumno
        '
        Me.txtdatosalumno.Location = New System.Drawing.Point(138, 33)
        Me.txtdatosalumno.Name = "txtdatosalumno"
        Me.txtdatosalumno.ReadOnly = True
        Me.txtdatosalumno.Size = New System.Drawing.Size(433, 22)
        Me.txtdatosalumno.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDatosAsistencia)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 444)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 287)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen General de Asistencias"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboArea)
        Me.GroupBox2.Controls.Add(Me.dgvFechaEstadoAsistencia)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 321)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asistencias del Area"
        '
        'cmdBusqueda
        '
        Me.cmdBusqueda.Location = New System.Drawing.Point(323, 44)
        Me.cmdBusqueda.Name = "cmdBusqueda"
        Me.cmdBusqueda.Size = New System.Drawing.Size(124, 23)
        Me.cmdBusqueda.TabIndex = 3
        Me.cmdBusqueda.Text = "BUSCAR"
        Me.cmdBusqueda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(114, 41)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(167, 24)
        Me.cboArea.TabIndex = 1
        '
        'dgvFechaEstadoAsistencia
        '
        Me.dgvFechaEstadoAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFechaEstadoAsistencia.Location = New System.Drawing.Point(164, 90)
        Me.dgvFechaEstadoAsistencia.Name = "dgvFechaEstadoAsistencia"
        Me.dgvFechaEstadoAsistencia.RowHeadersWidth = 51
        Me.dgvFechaEstadoAsistencia.RowTemplate.Height = 24
        Me.dgvFechaEstadoAsistencia.Size = New System.Drawing.Size(383, 192)
        Me.dgvFechaEstadoAsistencia.TabIndex = 0
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(138, 70)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.Size = New System.Drawing.Size(100, 22)
        Me.txtidalumno.TabIndex = 6
        Me.txtidalumno.Visible = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(771, 98)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(356, 355)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(783, 617)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReporteAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 770)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.txtidalumno)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtdatosalumno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteAsistencias"
        CType(Me.dgvDatosAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvFechaEstadoAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDatosAsistencia As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdatosalumno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents dgvFechaEstadoAsistencia As DataGridView
    Friend WithEvents txtidalumno As TextBox
    Friend WithEvents cmdBusqueda As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
End Class
