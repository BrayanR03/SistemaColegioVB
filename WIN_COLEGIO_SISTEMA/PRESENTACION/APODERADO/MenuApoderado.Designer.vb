<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuApoderado
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PERFILAPODERADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSAPODERADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciasAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteAsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.REPORTENOTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERFILAPODERADOToolStripMenuItem, Me.AsistenciasAlumnoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1104, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERFILAPODERADOToolStripMenuItem
        '
        Me.PERFILAPODERADOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATOSAPODERADOToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.PERFILAPODERADOToolStripMenuItem.Name = "PERFILAPODERADOToolStripMenuItem"
        Me.PERFILAPODERADOToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.PERFILAPODERADOToolStripMenuItem.Text = "PERFIL APODERADO"
        '
        'DATOSAPODERADOToolStripMenuItem
        '
        Me.DATOSAPODERADOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DATOSAPODERADOToolStripMenuItem.Name = "DATOSAPODERADOToolStripMenuItem"
        Me.DATOSAPODERADOToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.DATOSAPODERADOToolStripMenuItem.Text = "DATOS APODERADO"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'AsistenciasAlumnoToolStripMenuItem
        '
        Me.AsistenciasAlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteAsistenciasToolStripMenuItem, Me.ToolStripSeparator1, Me.REPORTENOTASToolStripMenuItem})
        Me.AsistenciasAlumnoToolStripMenuItem.Name = "AsistenciasAlumnoToolStripMenuItem"
        Me.AsistenciasAlumnoToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AsistenciasAlumnoToolStripMenuItem.Text = "REPORTE ACADEMICO"
        '
        'ReporteAsistenciasToolStripMenuItem
        '
        Me.ReporteAsistenciasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReporteAsistenciasToolStripMenuItem.Name = "ReporteAsistenciasToolStripMenuItem"
        Me.ReporteAsistenciasToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.ReporteAsistenciasToolStripMenuItem.Text = "Reporte Asistencias"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(218, 6)
        '
        'REPORTENOTASToolStripMenuItem
        '
        Me.REPORTENOTASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REPORTENOTASToolStripMenuItem.Name = "REPORTENOTASToolStripMenuItem"
        Me.REPORTENOTASToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.REPORTENOTASToolStripMenuItem.Text = "REPORTE NOTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WIN_COLEGIO_SISTEMA.My.Resources.Resources.LOGO___copia
        Me.PictureBox1.Location = New System.Drawing.Point(549, 342)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuApoderado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuApoderado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuApoderado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AsistenciasAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteAsistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PERFILAPODERADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATOSAPODERADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents REPORTENOTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
