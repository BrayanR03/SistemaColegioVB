<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAlumno
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PERFILALUMNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSALUMNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARSESIÓNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AREASREGISTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTAASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTEASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERFILALUMNOToolStripMenuItem, Me.ASISTENCIASToolStripMenuItem, Me.REPORTEASISTENCIASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1104, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERFILALUMNOToolStripMenuItem
        '
        Me.PERFILALUMNOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATOSALUMNOToolStripMenuItem, Me.CERRARSESIÓNToolStripMenuItem})
        Me.PERFILALUMNOToolStripMenuItem.Name = "PERFILALUMNOToolStripMenuItem"
        Me.PERFILALUMNOToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.PERFILALUMNOToolStripMenuItem.Text = "PERFIL ALUMNO"
        '
        'DATOSALUMNOToolStripMenuItem
        '
        Me.DATOSALUMNOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DATOSALUMNOToolStripMenuItem.Name = "DATOSALUMNOToolStripMenuItem"
        Me.DATOSALUMNOToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.DATOSALUMNOToolStripMenuItem.Text = "DATOS ALUMNO"
        '
        'CERRARSESIÓNToolStripMenuItem
        '
        Me.CERRARSESIÓNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CERRARSESIÓNToolStripMenuItem.Name = "CERRARSESIÓNToolStripMenuItem"
        Me.CERRARSESIÓNToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.CERRARSESIÓNToolStripMenuItem.Text = "CERRAR SESIÓN"
        '
        'ASISTENCIASToolStripMenuItem
        '
        Me.ASISTENCIASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AREASREGISTRADASToolStripMenuItem, Me.LISTAASISTENCIASToolStripMenuItem})
        Me.ASISTENCIASToolStripMenuItem.Name = "ASISTENCIASToolStripMenuItem"
        Me.ASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.ASISTENCIASToolStripMenuItem.Text = "ASISTENCIAS"
        '
        'AREASREGISTRADASToolStripMenuItem
        '
        Me.AREASREGISTRADASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AREASREGISTRADASToolStripMenuItem.Name = "AREASREGISTRADASToolStripMenuItem"
        Me.AREASREGISTRADASToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.AREASREGISTRADASToolStripMenuItem.Text = "AREAS REGISTRADAS"
        '
        'LISTAASISTENCIASToolStripMenuItem
        '
        Me.LISTAASISTENCIASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LISTAASISTENCIASToolStripMenuItem.Name = "LISTAASISTENCIASToolStripMenuItem"
        Me.LISTAASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.LISTAASISTENCIASToolStripMenuItem.Text = "LISTA ASISTENCIAS"
        '
        'REPORTEASISTENCIASToolStripMenuItem
        '
        Me.REPORTEASISTENCIASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTEToolStripMenuItem})
        Me.REPORTEASISTENCIASToolStripMenuItem.Name = "REPORTEASISTENCIASToolStripMenuItem"
        Me.REPORTEASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.REPORTEASISTENCIASToolStripMenuItem.Text = "REPORTE ASISTENCIAS"
        '
        'REPORTEToolStripMenuItem
        '
        Me.REPORTEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REPORTEToolStripMenuItem.Name = "REPORTEToolStripMenuItem"
        Me.REPORTEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.REPORTEToolStripMenuItem.Text = "MIS ASISTENCIAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WIN_COLEGIO_SISTEMA.My.Resources.Resources.LOGO___copia
        Me.PictureBox1.Location = New System.Drawing.Point(562, 343)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAlumno"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PERFILALUMNOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATOSALUMNOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARSESIÓNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AREASREGISTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTAASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTEASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
