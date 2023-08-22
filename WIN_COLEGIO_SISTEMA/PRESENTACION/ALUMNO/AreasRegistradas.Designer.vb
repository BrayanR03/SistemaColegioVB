<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreasRegistradas
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
        Me.dgvAreasDatos = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        CType(Me.dgvAreasDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAreasDatos
        '
        Me.dgvAreasDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreasDatos.Location = New System.Drawing.Point(26, 75)
        Me.dgvAreasDatos.Name = "dgvAreasDatos"
        Me.dgvAreasDatos.RowHeadersWidth = 51
        Me.dgvAreasDatos.RowTemplate.Height = 24
        Me.dgvAreasDatos.Size = New System.Drawing.Size(882, 287)
        Me.dgvAreasDatos.TabIndex = 0
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(26, 407)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(129, 44)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "REGRESAR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'AreasRegistradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 516)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgvAreasDatos)
        Me.Name = "AreasRegistradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AreasRegistradas"
        CType(Me.dgvAreasDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAreasDatos As DataGridView
    Friend WithEvents cmdSalir As Button
End Class
