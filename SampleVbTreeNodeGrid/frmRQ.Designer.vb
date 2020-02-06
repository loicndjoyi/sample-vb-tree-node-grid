<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRQ
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.msRevenuQuebec = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdRevenuQuebec = New System.Windows.Forms.OpenFileDialog()
        Me.tvCompagnie = New System.Windows.Forms.TreeView()
        Me.lstCompagnies = New System.Windows.Forms.ListBox()
        Me.lstPers = New System.Windows.Forms.ListBox()
        Me.gboRech = New System.Windows.Forms.GroupBox()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.gboComp = New System.Windows.Forms.GroupBox()
        Me.gboPers = New System.Windows.Forms.GroupBox()
        Me.gboCompSelect = New System.Windows.Forms.GroupBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.msRevenuQuebec.SuspendLayout()
        Me.gboRech.SuspendLayout()
        Me.gboComp.SuspendLayout()
        Me.gboPers.SuspendLayout()
        Me.gboCompSelect.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msRevenuQuebec
        '
        Me.msRevenuQuebec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.msRevenuQuebec.Location = New System.Drawing.Point(0, 0)
        Me.msRevenuQuebec.Name = "msRevenuQuebec"
        Me.msRevenuQuebec.Size = New System.Drawing.Size(1195, 24)
        Me.msRevenuQuebec.TabIndex = 0
        Me.msRevenuQuebec.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msOuvrir})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'msOuvrir
        '
        Me.msOuvrir.Image = Global.RevenuQuebec.My.Resources.Resources.open_file_icon
        Me.msOuvrir.Name = "msOuvrir"
        Me.msOuvrir.Size = New System.Drawing.Size(104, 22)
        Me.msOuvrir.Text = "Ouvrir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupportEnLigneToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'SupportEnLigneToolStripMenuItem
        '
        Me.SupportEnLigneToolStripMenuItem.Image = Global.RevenuQuebec.My.Resources.Resources.images
        Me.SupportEnLigneToolStripMenuItem.Name = "SupportEnLigneToolStripMenuItem"
        Me.SupportEnLigneToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SupportEnLigneToolStripMenuItem.Text = "Support technique"
        '
        'ofdRevenuQuebec
        '
        Me.ofdRevenuQuebec.FileName = "ofdRevenuQuebec"
        '
        'tvCompagnie
        '
        Me.tvCompagnie.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tvCompagnie.Location = New System.Drawing.Point(26, 19)
        Me.tvCompagnie.Name = "tvCompagnie"
        Me.tvCompagnie.Size = New System.Drawing.Size(279, 314)
        Me.tvCompagnie.TabIndex = 2
        '
        'lstCompagnies
        '
        Me.lstCompagnies.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lstCompagnies.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCompagnies.FormattingEnabled = True
        Me.lstCompagnies.ItemHeight = 14
        Me.lstCompagnies.Location = New System.Drawing.Point(18, 21)
        Me.lstCompagnies.Name = "lstCompagnies"
        Me.lstCompagnies.Size = New System.Drawing.Size(374, 144)
        Me.lstCompagnies.TabIndex = 9
        '
        'lstPers
        '
        Me.lstPers.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPers.FormattingEnabled = True
        Me.lstPers.ItemHeight = 14
        Me.lstPers.Location = New System.Drawing.Point(18, 16)
        Me.lstPers.Name = "lstPers"
        Me.lstPers.Size = New System.Drawing.Size(374, 144)
        Me.lstPers.TabIndex = 11
        '
        'gboRech
        '
        Me.gboRech.BackColor = System.Drawing.SystemColors.HighlightText
        Me.gboRech.Controls.Add(Me.txtRecherche)
        Me.gboRech.Controls.Add(Me.btnRecherche)
        Me.gboRech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboRech.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboRech.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gboRech.Location = New System.Drawing.Point(533, 40)
        Me.gboRech.Name = "gboRech"
        Me.gboRech.Size = New System.Drawing.Size(365, 86)
        Me.gboRech.TabIndex = 3
        Me.gboRech.TabStop = False
        Me.gboRech.Text = "Recherche :"
        '
        'txtRecherche
        '
        Me.txtRecherche.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecherche.Location = New System.Drawing.Point(6, 29)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(179, 22)
        Me.txtRecherche.TabIndex = 4
        Me.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRecherche
        '
        Me.btnRecherche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRecherche.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecherche.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecherche.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecherche.Location = New System.Drawing.Point(235, 19)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(109, 39)
        Me.btnRecherche.TabIndex = 5
        Me.btnRecherche.Text = "Valider"
        Me.btnRecherche.UseVisualStyleBackColor = False
        '
        'gboComp
        '
        Me.gboComp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gboComp.Controls.Add(Me.tvCompagnie)
        Me.gboComp.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboComp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gboComp.Location = New System.Drawing.Point(12, 40)
        Me.gboComp.Name = "gboComp"
        Me.gboComp.Size = New System.Drawing.Size(348, 350)
        Me.gboComp.TabIndex = 1
        Me.gboComp.TabStop = False
        Me.gboComp.Text = "Compagnie(s) :"
        '
        'gboPers
        '
        Me.gboPers.BackColor = System.Drawing.SystemColors.HighlightText
        Me.gboPers.Controls.Add(Me.lstPers)
        Me.gboPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboPers.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboPers.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gboPers.Location = New System.Drawing.Point(776, 213)
        Me.gboPers.Name = "gboPers"
        Me.gboPers.Size = New System.Drawing.Size(407, 177)
        Me.gboPers.TabIndex = 10
        Me.gboPers.TabStop = False
        Me.gboPers.Text = "Personne cherchée :"
        '
        'gboCompSelect
        '
        Me.gboCompSelect.BackColor = System.Drawing.SystemColors.HighlightText
        Me.gboCompSelect.Controls.Add(Me.lstCompagnies)
        Me.gboCompSelect.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCompSelect.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gboCompSelect.Location = New System.Drawing.Point(366, 213)
        Me.gboCompSelect.Name = "gboCompSelect"
        Me.gboCompSelect.Size = New System.Drawing.Size(407, 177)
        Me.gboCompSelect.TabIndex = 8
        Me.gboCompSelect.TabStop = False
        Me.gboCompSelect.Text = "Compagnie cherchée :"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RevenuQuebec.My.Resources.Resources.rq1
        Me.PictureBox1.Location = New System.Drawing.Point(1022, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 86)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmRQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1195, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gboCompSelect)
        Me.Controls.Add(Me.gboPers)
        Me.Controls.Add(Me.gboComp)
        Me.Controls.Add(Me.gboRech)
        Me.Controls.Add(Me.msRevenuQuebec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.msRevenuQuebec
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRQ"
        Me.ShowIcon = False
        Me.Text = "Revenu Québec"
        Me.msRevenuQuebec.ResumeLayout(False)
        Me.msRevenuQuebec.PerformLayout()
        Me.gboRech.ResumeLayout(False)
        Me.gboRech.PerformLayout()
        Me.gboComp.ResumeLayout(False)
        Me.gboPers.ResumeLayout(False)
        Me.gboCompSelect.ResumeLayout(False)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msRevenuQuebec As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msOuvrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdRevenuQuebec As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tvCompagnie As System.Windows.Forms.TreeView
    Friend WithEvents lstCompagnies As System.Windows.Forms.ListBox
    Friend WithEvents lstPers As System.Windows.Forms.ListBox
    Friend WithEvents gboRech As System.Windows.Forms.GroupBox
    Friend WithEvents gboComp As System.Windows.Forms.GroupBox
    Friend WithEvents gboPers As System.Windows.Forms.GroupBox
    Friend WithEvents gboCompSelect As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecherche As System.Windows.Forms.Button
    Friend WithEvents txtRecherche As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupportEnLigneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
