<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountSettings))
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.tbxCustAdd = New System.Windows.Forms.TextBox()
        Me.tbxCustName = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WelcomeNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxPhone
        '
        Me.tbxPhone.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPhone.Location = New System.Drawing.Point(209, 322)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(359, 26)
        Me.tbxPhone.TabIndex = 26
        '
        'tbxCustAdd
        '
        Me.tbxCustAdd.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustAdd.Location = New System.Drawing.Point(209, 270)
        Me.tbxCustAdd.Name = "tbxCustAdd"
        Me.tbxCustAdd.Size = New System.Drawing.Size(359, 26)
        Me.tbxCustAdd.TabIndex = 25
        '
        'tbxCustName
        '
        Me.tbxCustName.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustName.Location = New System.Drawing.Point(209, 218)
        Me.tbxCustName.Name = "tbxCustName"
        Me.tbxCustName.Size = New System.Drawing.Size(264, 26)
        Me.tbxCustName.TabIndex = 24
        '
        'tbxPass
        '
        Me.tbxPass.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPass.Location = New System.Drawing.Point(209, 166)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(265, 26)
        Me.tbxPass.TabIndex = 23
        '
        'tbxUser
        '
        Me.tbxUser.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.Location = New System.Drawing.Point(209, 114)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(265, 26)
        Me.tbxUser.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(58, 394)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 33)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WelcomeNAMEToolStripMenuItem, Me.ReserveToolStripMenuItem, Me.ViewReservationsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WelcomeNAMEToolStripMenuItem
        '
        Me.WelcomeNAMEToolStripMenuItem.Enabled = False
        Me.WelcomeNAMEToolStripMenuItem.Name = "WelcomeNAMEToolStripMenuItem"
        Me.WelcomeNAMEToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.WelcomeNAMEToolStripMenuItem.Text = "Welcome, [NAME]"
        '
        'ReserveToolStripMenuItem
        '
        Me.ReserveToolStripMenuItem.Name = "ReserveToolStripMenuItem"
        Me.ReserveToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ReserveToolStripMenuItem.Text = "Reserve a Slot"
        '
        'ViewReservationsToolStripMenuItem
        '
        Me.ViewReservationsToolStripMenuItem.Name = "ViewReservationsToolStripMenuItem"
        Me.ViewReservationsToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ViewReservationsToolStripMenuItem.Text = "View Reservations"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(58, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(270, 50)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Account Settings"
        '
        'AccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(658, 469)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.tbxPhone)
        Me.Controls.Add(Me.tbxCustAdd)
        Me.Controls.Add(Me.tbxCustName)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AccountSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountSettings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents tbxCustAdd As TextBox
    Friend WithEvents tbxCustName As TextBox
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReserveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label10 As Label
    Friend WithEvents WelcomeNAMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReservationsToolStripMenuItem As ToolStripMenuItem
End Class
