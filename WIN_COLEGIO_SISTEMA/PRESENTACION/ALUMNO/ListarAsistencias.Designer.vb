<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarAsistencias
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
        Me.cboAreas = New System.Windows.Forms.ComboBox()
        Me.dgvDataAsistencia = New System.Windows.Forms.DataGridView()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDataAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREAS"
        '
        'cboAreas
        '
        Me.cboAreas.FormattingEnabled = True
        Me.cboAreas.Location = New System.Drawing.Point(105, 77)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(226, 24)
        Me.cboAreas.TabIndex = 1
        '
        'dgvDataAsistencia
        '
        Me.dgvDataAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataAsistencia.Location = New System.Drawing.Point(46, 189)
        Me.dgvDataAsistencia.Name = "dgvDataAsistencia"
        Me.dgvDataAsistencia.RowHeadersWidth = 51
        Me.dgvDataAsistencia.RowTemplate.Height = 24
        Me.dgvDataAsistencia.Size = New System.Drawing.Size(496, 331)
        Me.dgvDataAsistencia.TabIndex = 2
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(46, 131)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(87, 33)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Text = "BUSCAR"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListarAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 608)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.dgvDataAsistencia)
        Me.Controls.Add(Me.cboAreas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListarAsistencias"
        Me.Text = "ListarAsistencias"
        CType(Me.dgvDataAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboAreas As ComboBox
    Friend WithEvents dgvDataAsistencia As DataGridView
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents Button1 As Button
End Class
