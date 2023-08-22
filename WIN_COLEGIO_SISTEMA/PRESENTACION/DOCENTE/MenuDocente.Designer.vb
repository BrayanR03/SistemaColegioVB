<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuDocente
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
        Me.PERFILDOCENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSDOCENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTAASISTENCIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AREASREGISTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARNOTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARREPORTEFINALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERFILDOCENTEToolStripMenuItem, Me.ASISTENCIASToolStripMenuItem, Me.AREASREGISTRADASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1104, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERFILDOCENTEToolStripMenuItem
        '
        Me.PERFILDOCENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATOSDOCENTEToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem})
        Me.PERFILDOCENTEToolStripMenuItem.Name = "PERFILDOCENTEToolStripMenuItem"
        Me.PERFILDOCENTEToolStripMenuItem.Size = New System.Drawing.Size(136, 24)
        Me.PERFILDOCENTEToolStripMenuItem.Text = "PERFIL DOCENTE"
        '
        'DATOSDOCENTEToolStripMenuItem
        '
        Me.DATOSDOCENTEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DATOSDOCENTEToolStripMenuItem.Name = "DATOSDOCENTEToolStripMenuItem"
        Me.DATOSDOCENTEToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.DATOSDOCENTEToolStripMenuItem.Text = "DATOS DOCENTE"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'ASISTENCIASToolStripMenuItem
        '
        Me.ASISTENCIASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARASISTENCIASToolStripMenuItem, Me.LISTAASISTENCIASToolStripMenuItem})
        Me.ASISTENCIASToolStripMenuItem.Name = "ASISTENCIASToolStripMenuItem"
        Me.ASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.ASISTENCIASToolStripMenuItem.Text = "ASISTENCIAS"
        '
        'REGISTRARASISTENCIASToolStripMenuItem
        '
        Me.REGISTRARASISTENCIASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REGISTRARASISTENCIASToolStripMenuItem.Name = "REGISTRARASISTENCIASToolStripMenuItem"
        Me.REGISTRARASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.REGISTRARASISTENCIASToolStripMenuItem.Text = "REGISTRAR ASISTENCIA"
        '
        'LISTAASISTENCIASToolStripMenuItem
        '
        Me.LISTAASISTENCIASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LISTAASISTENCIASToolStripMenuItem.Name = "LISTAASISTENCIASToolStripMenuItem"
        Me.LISTAASISTENCIASToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.LISTAASISTENCIASToolStripMenuItem.Text = "LISTA ASISTENCIAS"
        '
        'AREASREGISTRADASToolStripMenuItem
        '
        Me.AREASREGISTRADASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRARNOTASToolStripMenuItem, Me.REGISTRARREPORTEFINALToolStripMenuItem})
        Me.AREASREGISTRADASToolStripMenuItem.Name = "AREASREGISTRADASToolStripMenuItem"
        Me.AREASREGISTRADASToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.AREASREGISTRADASToolStripMenuItem.Text = "AREAS REGISTRADAS"
        '
        'REGISTRARNOTASToolStripMenuItem
        '
        Me.REGISTRARNOTASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REGISTRARNOTASToolStripMenuItem.Name = "REGISTRARNOTASToolStripMenuItem"
        Me.REGISTRARNOTASToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.REGISTRARNOTASToolStripMenuItem.Text = "REGISTRAR NOTAS EVIDENCIAS"
        '
        'REGISTRARREPORTEFINALToolStripMenuItem
        '
        Me.REGISTRARREPORTEFINALToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REGISTRARREPORTEFINALToolStripMenuItem.Name = "REGISTRARREPORTEFINALToolStripMenuItem"
        Me.REGISTRARREPORTEFINALToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.REGISTRARREPORTEFINALToolStripMenuItem.Text = "REGISTRAR REPORTE FINAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WIN_COLEGIO_SISTEMA.My.Resources.Resources.LOGO___copia
        Me.PictureBox1.Location = New System.Drawing.Point(562, 347)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 657)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuDocente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PERFILDOCENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATOSDOCENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTAASISTENCIASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AREASREGISTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARNOTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARREPORTEFINALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
