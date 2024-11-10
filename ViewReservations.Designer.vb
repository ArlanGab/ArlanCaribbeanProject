<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReservations))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WelcomeNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgCurrentReserves = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtgCurrentReserves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WelcomeNAMEToolStripMenuItem, Me.AccountSettingsToolStripMenuItem, Me.ViewReservationsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
        Me.MenuStrip1.TabIndex = 80
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WelcomeNAMEToolStripMenuItem
        '
        Me.WelcomeNAMEToolStripMenuItem.Enabled = False
        Me.WelcomeNAMEToolStripMenuItem.Name = "WelcomeNAMEToolStripMenuItem"
        Me.WelcomeNAMEToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.WelcomeNAMEToolStripMenuItem.Text = "Welcome, [NAME]"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.AccountSettingsToolStripMenuItem.Text = "Account Settings"
        '
        'ViewReservationsToolStripMenuItem
        '
        Me.ViewReservationsToolStripMenuItem.Name = "ViewReservationsToolStripMenuItem"
        Me.ViewReservationsToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ViewReservationsToolStripMenuItem.Text = "Reserve a Slot"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 50)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Current Reservations"
        '
        'dtgCurrentReserves
        '
        Me.dtgCurrentReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCurrentReserves.Location = New System.Drawing.Point(50, 120)
        Me.dtgCurrentReserves.Name = "dtgCurrentReserves"
        Me.dtgCurrentReserves.Size = New System.Drawing.Size(696, 386)
        Me.dtgCurrentReserves.TabIndex = 78
        '
        'ViewReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 546)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtgCurrentReserves)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ViewReservations"
        Me.Text = "ViewReservations"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtgCurrentReserves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WelcomeNAMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgCurrentReserves As DataGridView
End Class
