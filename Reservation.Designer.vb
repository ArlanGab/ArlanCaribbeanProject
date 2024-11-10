<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTours = New System.Windows.Forms.ListBox()
        Me.grpDays = New System.Windows.Forms.GroupBox()
        Me.rdb14 = New System.Windows.Forms.RadioButton()
        Me.rdb7 = New System.Windows.Forms.RadioButton()
        Me.tbxPax = New System.Windows.Forms.TextBox()
        Me.datDepart = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WelcomeNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDays.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WelcomeNAMEToolStripMenuItem, Me.AccountSettingsToolStripMenuItem, Me.ViewReservationsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(923, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.AccountSettingsToolStripMenuItem.Text = "Account Settings"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tour List"
        '
        'lstTours
        '
        Me.lstTours.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTours.FormattingEnabled = True
        Me.lstTours.ItemHeight = 21
        Me.lstTours.Items.AddRange(New Object() {"Caribbean", "Mediterranean", "Alaska", "Europe"})
        Me.lstTours.Location = New System.Drawing.Point(73, 158)
        Me.lstTours.Name = "lstTours"
        Me.lstTours.Size = New System.Drawing.Size(154, 109)
        Me.lstTours.TabIndex = 2
        '
        'grpDays
        '
        Me.grpDays.Controls.Add(Me.rdb14)
        Me.grpDays.Controls.Add(Me.rdb7)
        Me.grpDays.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDays.Location = New System.Drawing.Point(74, 327)
        Me.grpDays.Name = "grpDays"
        Me.grpDays.Size = New System.Drawing.Size(155, 98)
        Me.grpDays.TabIndex = 3
        Me.grpDays.TabStop = False
        Me.grpDays.Text = "No. of Days:"
        '
        'rdb14
        '
        Me.rdb14.AutoSize = True
        Me.rdb14.Location = New System.Drawing.Point(16, 65)
        Me.rdb14.Name = "rdb14"
        Me.rdb14.Size = New System.Drawing.Size(74, 25)
        Me.rdb14.TabIndex = 1
        Me.rdb14.Text = "14 days"
        Me.rdb14.UseVisualStyleBackColor = True
        '
        'rdb7
        '
        Me.rdb7.AutoSize = True
        Me.rdb7.Checked = True
        Me.rdb7.Location = New System.Drawing.Point(16, 33)
        Me.rdb7.Name = "rdb7"
        Me.rdb7.Size = New System.Drawing.Size(67, 25)
        Me.rdb7.TabIndex = 0
        Me.rdb7.TabStop = True
        Me.rdb7.Text = "7 days"
        Me.rdb7.UseVisualStyleBackColor = True
        '
        'tbxPax
        '
        Me.tbxPax.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPax.Location = New System.Drawing.Point(469, 155)
        Me.tbxPax.Name = "tbxPax"
        Me.tbxPax.Size = New System.Drawing.Size(116, 26)
        Me.tbxPax.TabIndex = 69
        '
        'datDepart
        '
        Me.datDepart.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datDepart.Location = New System.Drawing.Point(469, 215)
        Me.datDepart.Name = "datDepart"
        Me.datDepart.Size = New System.Drawing.Size(262, 26)
        Me.datDepart.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(338, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 21)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Total Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Mode of Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Departure Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(338, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Num Pax"
        '
        'btnReserve
        '
        Me.btnReserve.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.Location = New System.Drawing.Point(754, 418)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(101, 32)
        Me.btnReserve.TabIndex = 71
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(465, 329)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 21)
        Me.lblCost.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 50)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Reserve a Slot"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(712, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 186)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'WelcomeNAMEToolStripMenuItem
        '
        Me.WelcomeNAMEToolStripMenuItem.Enabled = False
        Me.WelcomeNAMEToolStripMenuItem.Name = "WelcomeNAMEToolStripMenuItem"
        Me.WelcomeNAMEToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.WelcomeNAMEToolStripMenuItem.Text = "Welcome, [NAME]"
        '
        'ViewReservationsToolStripMenuItem
        '
        Me.ViewReservationsToolStripMenuItem.Name = "ViewReservationsToolStripMenuItem"
        Me.ViewReservationsToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ViewReservationsToolStripMenuItem.Text = "View Reservations"
        '
        'cmbMode
        '
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"Cash", "Credit Card", "E-Wallet"})
        Me.cmbMode.Location = New System.Drawing.Point(469, 269)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(121, 29)
        Me.cmbMode.TabIndex = 75
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(923, 490)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.tbxPax)
        Me.Controls.Add(Me.datDepart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpDays)
        Me.Controls.Add(Me.lstTours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDays.ResumeLayout(False)
        Me.grpDays.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lstTours As ListBox
    Friend WithEvents grpDays As GroupBox
    Friend WithEvents rdb14 As RadioButton
    Friend WithEvents rdb7 As RadioButton
    Friend WithEvents tbxPax As TextBox
    Friend WithEvents datDepart As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReserve As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeNAMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbMode As ComboBox
End Class
