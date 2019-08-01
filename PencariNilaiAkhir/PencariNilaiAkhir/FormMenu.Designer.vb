<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DaftarSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaLulusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaTidakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 391)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(836, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(624, 393)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(560, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiswaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(836, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SiswaToolStripMenuItem
        '
        Me.SiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarSiswaToolStripMenuItem})
        Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
        Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.SiswaToolStripMenuItem.Text = "Siswa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(757, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DaftarSiswaToolStripMenuItem
        '
        Me.DaftarSiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiswaLulusToolStripMenuItem, Me.MahasiswaTidakToolStripMenuItem})
        Me.DaftarSiswaToolStripMenuItem.Name = "DaftarSiswaToolStripMenuItem"
        Me.DaftarSiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DaftarSiswaToolStripMenuItem.Text = "Daftar Siswa"
        '
        'SiswaLulusToolStripMenuItem
        '
        Me.SiswaLulusToolStripMenuItem.Name = "SiswaLulusToolStripMenuItem"
        Me.SiswaLulusToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SiswaLulusToolStripMenuItem.Text = "Mahasiswa Lulus"
        '
        'MahasiswaTidakToolStripMenuItem
        '
        Me.MahasiswaTidakToolStripMenuItem.Name = "MahasiswaTidakToolStripMenuItem"
        Me.MahasiswaTidakToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MahasiswaTidakToolStripMenuItem.Text = "Mahasiswa Tidak"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(836, 413)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DaftarSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiswaLulusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaTidakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
