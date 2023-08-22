<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteNotas
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cmdBusqueda = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREA:"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(93, 63)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(195, 24)
        Me.cboArea.TabIndex = 1
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(31, 185)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(553, 201)
        Me.dgvData.TabIndex = 2
        '
        'cmdBusqueda
        '
        Me.cmdBusqueda.Location = New System.Drawing.Point(382, 81)
        Me.cmdBusqueda.Name = "cmdBusqueda"
        Me.cmdBusqueda.Size = New System.Drawing.Size(96, 41)
        Me.cmdBusqueda.TabIndex = 3
        Me.cmdBusqueda.Text = "BUSCAR"
        Me.cmdBusqueda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FECHA"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(93, 132)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpfecha.TabIndex = 5
        '
        'cmdRegresar
        '
        Me.cmdRegresar.Location = New System.Drawing.Point(31, 404)
        Me.cmdRegresar.Name = "cmdRegresar"
        Me.cmdRegresar.Size = New System.Drawing.Size(149, 52)
        Me.cmdRegresar.TabIndex = 6
        Me.cmdRegresar.Text = "REGRESAR"
        Me.cmdRegresar.UseVisualStyleBackColor = True
        '
        'ReporteNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 468)
        Me.Controls.Add(Me.cmdRegresar)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBusqueda)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteNotas"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cmdBusqueda As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents cmdRegresar As Button
End Class
