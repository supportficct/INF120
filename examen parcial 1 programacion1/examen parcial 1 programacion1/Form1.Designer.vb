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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.introd = New System.Windows.Forms.TextBox()
        Me.respuest = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(240, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.DescargarToolStripMenuItem, Me.ExamenToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MenuToolStripMenuItem.Text = "menu "
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CargarToolStripMenuItem.Text = "cargar"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DescargarToolStripMenuItem.Text = "descargar"
        '
        'ExamenToolStripMenuItem
        '
        Me.ExamenToolStripMenuItem.Name = "ExamenToolStripMenuItem"
        Me.ExamenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExamenToolStripMenuItem.Text = "examen"
        '
        'introd
        '
        Me.introd.Location = New System.Drawing.Point(26, 73)
        Me.introd.Name = "introd"
        Me.introd.Size = New System.Drawing.Size(100, 20)
        Me.introd.TabIndex = 1
        '
        'respuest
        '
        Me.respuest.Location = New System.Drawing.Point(26, 135)
        Me.respuest.Name = "respuest"
        Me.respuest.Size = New System.Drawing.Size(100, 20)
        Me.respuest.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 318)
        Me.Controls.Add(Me.respuest)
        Me.Controls.Add(Me.introd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents introd As System.Windows.Forms.TextBox
    Friend WithEvents respuest As System.Windows.Forms.TextBox
    Friend WithEvents ExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
