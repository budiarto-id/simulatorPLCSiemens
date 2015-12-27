<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BerkasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SambunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SambungkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PutuskanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuAboutDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAboutProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerkasToolStripMenuItem, Me.SambunganToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BerkasToolStripMenuItem
        '
        Me.BerkasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.BerkasToolStripMenuItem.Name = "BerkasToolStripMenuItem"
        Me.BerkasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.BerkasToolStripMenuItem.Text = "Berkas"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'SambunganToolStripMenuItem
        '
        Me.SambunganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SambungkanToolStripMenuItem, Me.PutuskanToolStripMenuItem})
        Me.SambunganToolStripMenuItem.Name = "SambunganToolStripMenuItem"
        Me.SambunganToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.SambunganToolStripMenuItem.Text = "Sambungan"
        '
        'SambungkanToolStripMenuItem
        '
        Me.SambungkanToolStripMenuItem.Name = "SambungkanToolStripMenuItem"
        Me.SambungkanToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SambungkanToolStripMenuItem.Text = "Sambungkan"
        '
        'PutuskanToolStripMenuItem
        '
        Me.PutuskanToolStripMenuItem.Enabled = False
        Me.PutuskanToolStripMenuItem.Name = "PutuskanToolStripMenuItem"
        Me.PutuskanToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PutuskanToolStripMenuItem.Text = "Putuskan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.ToolStripSeparator1, Me.menuAboutDev, Me.menuAboutProduct})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(243, 22)
        Me.BantuanToolStripMenuItem1.Text = "Lihat Bantuan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(240, 6)
        '
        'menuAboutDev
        '
        Me.menuAboutDev.Name = "menuAboutDev"
        Me.menuAboutDev.Size = New System.Drawing.Size(243, 22)
        Me.menuAboutDev.Text = "Tentang Pengembang"
        '
        'menuAboutProduct
        '
        Me.menuAboutProduct.Name = "menuAboutProduct"
        Me.menuAboutProduct.Size = New System.Drawing.Size(243, 22)
        Me.menuAboutProduct.Text = "Tentang Simulator PLC Siemens"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulator PLC Siemens"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BerkasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SambunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAboutDev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuAboutProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SambungkanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PutuskanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
