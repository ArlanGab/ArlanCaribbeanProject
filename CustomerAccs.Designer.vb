<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerAccs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerAccs))
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.tbxCustAdd = New System.Windows.Forms.TextBox()
        Me.tbxCustName = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgCustAccs = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomerReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsLast = New System.Windows.Forms.ToolStripButton()
        Me.tlsNext = New System.Windows.Forms.ToolStripButton()
        Me.tlsPrev = New System.Windows.Forms.ToolStripButton()
        Me.tlsFirst = New System.Windows.Forms.ToolStripButton()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dtgCustAccs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxPhone
        '
        Me.tbxPhone.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPhone.Location = New System.Drawing.Point(170, 444)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(158, 26)
        Me.tbxPhone.TabIndex = 26
        '
        'tbxCustAdd
        '
        Me.tbxCustAdd.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustAdd.Location = New System.Drawing.Point(170, 403)
        Me.tbxCustAdd.Name = "tbxCustAdd"
        Me.tbxCustAdd.Size = New System.Drawing.Size(264, 26)
        Me.tbxCustAdd.TabIndex = 25
        '
        'tbxCustName
        '
        Me.tbxCustName.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustName.Location = New System.Drawing.Point(170, 362)
        Me.tbxCustName.Name = "tbxCustName"
        Me.tbxCustName.Size = New System.Drawing.Size(264, 26)
        Me.tbxCustName.TabIndex = 24
        '
        'tbxPassword
        '
        Me.tbxPassword.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.Location = New System.Drawing.Point(170, 321)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(265, 26)
        Me.tbxPassword.TabIndex = 23
        '
        'tbxUsername
        '
        Me.tbxUsername.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUsername.Location = New System.Drawing.Point(170, 280)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(265, 26)
        Me.tbxUsername.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 490)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User Type"
        '
        'dtgCustAccs
        '
        Me.dtgCustAccs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCustAccs.Location = New System.Drawing.Point(491, 114)
        Me.dtgCustAccs.Name = "dtgCustAccs"
        Me.dtgCustAccs.Size = New System.Drawing.Size(549, 611)
        Me.dtgCustAccs.TabIndex = 28
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(120, 556)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 34)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(242, 556)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 34)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(120, 613)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 34)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(242, 613)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(86, 34)
        Me.btnDel.TabIndex = 32
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReservationsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1062, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerReservationsToolStripMenuItem
        '
        Me.CustomerReservationsToolStripMenuItem.Name = "CustomerReservationsToolStripMenuItem"
        Me.CustomerReservationsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CustomerReservationsToolStripMenuItem.Text = "Reservations"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsLast, Me.tlsNext, Me.tlsPrev, Me.tlsFirst})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlsLast
        '
        Me.tlsLast.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsLast.Image = CType(resources.GetObject("tlsLast.Image"), System.Drawing.Image)
        Me.tlsLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsLast.Name = "tlsLast"
        Me.tlsLast.Size = New System.Drawing.Size(23, 22)
        Me.tlsLast.Text = "ToolStripButton3"
        '
        'tlsNext
        '
        Me.tlsNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsNext.Image = CType(resources.GetObject("tlsNext.Image"), System.Drawing.Image)
        Me.tlsNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsNext.Name = "tlsNext"
        Me.tlsNext.Size = New System.Drawing.Size(23, 22)
        Me.tlsNext.Text = "ToolStripButton4"
        '
        'tlsPrev
        '
        Me.tlsPrev.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsPrev.Image = CType(resources.GetObject("tlsPrev.Image"), System.Drawing.Image)
        Me.tlsPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsPrev.Name = "tlsPrev"
        Me.tlsPrev.Size = New System.Drawing.Size(23, 22)
        Me.tlsPrev.Text = "ToolStripButton1"
        '
        'tlsFirst
        '
        Me.tlsFirst.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tlsFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsFirst.Image = CType(resources.GetObject("tlsFirst.Image"), System.Drawing.Image)
        Me.tlsFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsFirst.Name = "tlsFirst"
        Me.tlsFirst.Size = New System.Drawing.Size(23, 22)
        Me.tlsFirst.Text = "ToolStripButton2"
        '
        'tbxID
        '
        Me.tbxID.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxID.Location = New System.Drawing.Point(170, 238)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.ReadOnly = True
        Me.tbxID.Size = New System.Drawing.Size(131, 26)
        Me.tbxID.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ID"
        '
        'cmbUserType
        '
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"admin", "customer"})
        Me.cmbUserType.Location = New System.Drawing.Point(170, 487)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(121, 29)
        Me.cmbUserType.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(31, 90)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 50)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Accounts"
        '
        'CustomerAccs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1062, 791)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtgCustAccs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxPhone)
        Me.Controls.Add(Me.tbxCustAdd)
        Me.Controls.Add(Me.tbxCustName)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "CustomerAccs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerAccs"
        CType(Me.dtgCustAccs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents tbxCustAdd As TextBox
    Friend WithEvents tbxCustName As TextBox
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgCustAccs As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tlsLast As ToolStripButton
    Friend WithEvents tlsNext As ToolStripButton
    Friend WithEvents tlsPrev As ToolStripButton
    Friend WithEvents tlsFirst As ToolStripButton
    Friend WithEvents tbxID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CustomerReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents Label10 As Label
End Class
