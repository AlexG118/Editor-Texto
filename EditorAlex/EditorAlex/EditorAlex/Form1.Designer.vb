<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarRemplazarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemarcarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColourDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheroToolStripMenuItem, Me.EditarToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem, Me.RemarcarToolStripMenuItem, Me.BuscarRemplazarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheroToolStripMenuItem
        '
        Me.FicheroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.CerrarPestañaToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.GrabarComoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.FicheroToolStripMenuItem.Image = CType(resources.GetObject("FicheroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FicheroToolStripMenuItem.Name = "FicheroToolStripMenuItem"
        Me.FicheroToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.FicheroToolStripMenuItem.Text = "Fichero"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-1"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NuevoToolStripMenuItem.Text = "Nueva Pestaña"
        '
        'CerrarPestañaToolStripMenuItem
        '
        Me.CerrarPestañaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CerrarPestañaToolStripMenuItem.Image = CType(resources.GetObject("CerrarPestañaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarPestañaToolStripMenuItem.Name = "CerrarPestañaToolStripMenuItem"
        Me.CerrarPestañaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-2"
        Me.CerrarPestañaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CerrarPestañaToolStripMenuItem.Text = "Cerrar Pestaña"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-3"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrabarToolStripMenuItem.Image = CType(resources.GetObject("GrabarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-Shift-S"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GrabarToolStripMenuItem.Text = "Guardar"
        '
        'GrabarComoToolStripMenuItem
        '
        Me.GrabarComoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrabarComoToolStripMenuItem.Image = CType(resources.GetObject("GrabarComoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrabarComoToolStripMenuItem.Name = "GrabarComoToolStripMenuItem"
        Me.GrabarComoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GrabarComoToolStripMenuItem.Text = "Guardar como"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.BorrarTextoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-C"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-X"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PegarToolStripMenuItem.Image = CType(resources.GetObject("PegarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-V"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'BorrarTextoToolStripMenuItem
        '
        Me.BorrarTextoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BorrarTextoToolStripMenuItem.Image = CType(resources.GetObject("BorrarTextoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrarTextoToolStripMenuItem.Name = "BorrarTextoToolStripMenuItem"
        Me.BorrarTextoToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.BorrarTextoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BorrarTextoToolStripMenuItem.Text = "Borrar texto"
        '
        'BuscarRemplazarToolStripMenuItem
        '
        Me.BuscarRemplazarToolStripMenuItem.Image = CType(resources.GetObject("BuscarRemplazarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarRemplazarToolStripMenuItem.Name = "BuscarRemplazarToolStripMenuItem"
        Me.BuscarRemplazarToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.BuscarRemplazarToolStripMenuItem.Text = "Buscar/Reemplazar"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Image = CType(resources.GetObject("DeshacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-Z"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Image = CType(resources.GetObject("RehacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-Y"
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Image = CType(resources.GetObject("FuenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = CType(resources.GetObject("ColorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'RemarcarToolStripMenuItem
        '
        Me.RemarcarToolStripMenuItem.Image = CType(resources.GetObject("RemarcarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemarcarToolStripMenuItem.Name = "RemarcarToolStripMenuItem"
        Me.RemarcarToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.RemarcarToolStripMenuItem.Text = "Remarcar"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        Me.ofd.Filter = "Text files (*.txt)|*.txt"
        '
        'sfd
        '
        Me.sfd.Filter = "Text files (*.txt)|*.txt"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 458)
        Me.TabControl1.TabIndex = 3
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(676, 482)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Text Creator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemarcarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColourDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarRemplazarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
