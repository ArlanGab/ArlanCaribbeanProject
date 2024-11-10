<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerReservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerReservations))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tlsFirst = New System.Windows.Forms.ToolStripButton()
        Me.tlsPrev = New System.Windows.Forms.ToolStripButton()
        Me.tlsNext = New System.Windows.Forms.ToolStripButton()
        Me.tlsLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.tbxCustAdd = New System.Windows.Forms.TextBox()
        Me.tbxCustName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datDepart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxPax = New System.Windows.Forms.TextBox()
        Me.tbxCost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTourLoc = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtgReserves = New System.Windows.Forms.DataGridView()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.cmbTourLength = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbxCustID = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtgReserves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 21)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Reservation ID"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsLast, Me.tlsNext, Me.tlsPrev, Me.tlsFirst})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1059, 25)
        Me.ToolStrip1.TabIndex = 56
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'CustomerReservationsToolStripMenuItem
        '
        Me.CustomerReservationsToolStripMenuItem.Name = "CustomerReservationsToolStripMenuItem"
        Me.CustomerReservationsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CustomerReservationsToolStripMenuItem.Text = "Accounts"
        '
        'tbxID
        '
        Me.tbxID.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxID.Location = New System.Drawing.Point(164, 132)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.ReadOnly = True
        Me.tbxID.Size = New System.Drawing.Size(131, 26)
        Me.tbxID.TabIndex = 57
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReservationsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1059, 24)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(235, 663)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 30)
        Me.btnDel.TabIndex = 54
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(115, 663)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(235, 620)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(115, 620)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxPhone
        '
        Me.tbxPhone.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPhone.Location = New System.Drawing.Point(164, 304)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(158, 26)
        Me.tbxPhone.TabIndex = 47
        '
        'tbxCustAdd
        '
        Me.tbxCustAdd.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustAdd.Location = New System.Drawing.Point(164, 261)
        Me.tbxCustAdd.Name = "tbxCustAdd"
        Me.tbxCustAdd.Size = New System.Drawing.Size(331, 26)
        Me.tbxCustAdd.TabIndex = 46
        '
        'tbxCustName
        '
        Me.tbxCustName.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustName.Location = New System.Drawing.Point(164, 218)
        Me.tbxCustName.Name = "tbxCustName"
        Me.tbxCustName.Size = New System.Drawing.Size(331, 26)
        Me.tbxCustName.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "No. of Pax"
        '
        'datDepart
        '
        Me.datDepart.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datDepart.Location = New System.Drawing.Point(164, 482)
        Me.datDepart.Name = "datDepart"
        Me.datDepart.Size = New System.Drawing.Size(257, 26)
        Me.datDepart.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Departure Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 528)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Mode of Payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 572)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 21)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Total Cost"
        '
        'tbxPax
        '
        Me.tbxPax.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPax.Location = New System.Drawing.Point(164, 439)
        Me.tbxPax.Name = "tbxPax"
        Me.tbxPax.Size = New System.Drawing.Size(100, 26)
        Me.tbxPax.TabIndex = 61
        '
        'tbxCost
        '
        Me.tbxCost.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCost.Location = New System.Drawing.Point(164, 571)
        Me.tbxCost.Name = "tbxCost"
        Me.tbxCost.Size = New System.Drawing.Size(100, 26)
        Me.tbxCost.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 21)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Tour Location"
        '
        'cmbTourLoc
        '
        Me.cmbTourLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTourLoc.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTourLoc.FormattingEnabled = True
        Me.cmbTourLoc.Items.AddRange(New Object() {"Caribbean", "Mediterranean", "Alaska", "Europe"})
        Me.cmbTourLoc.Location = New System.Drawing.Point(164, 347)
        Me.cmbTourLoc.Name = "cmbTourLoc"
        Me.cmbTourLoc.Size = New System.Drawing.Size(121, 29)
        Me.cmbTourLoc.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 50)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Reservations"
        '
        'dtgReserves
        '
        Me.dtgReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgReserves.Location = New System.Drawing.Point(539, 110)
        Me.dtgReserves.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgReserves.Name = "dtgReserves"
        Me.dtgReserves.Size = New System.Drawing.Size(490, 516)
        Me.dtgReserves.TabIndex = 67
        '
        'cmbMode
        '
        Me.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMode.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"Cash", "Credit Card", "E-Wallet"})
        Me.cmbMode.Location = New System.Drawing.Point(164, 525)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(121, 29)
        Me.cmbMode.TabIndex = 68
        '
        'cmbTourLength
        '
        Me.cmbTourLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTourLength.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTourLength.FormattingEnabled = True
        Me.cmbTourLength.Items.AddRange(New Object() {"7 Days", "14 Days"})
        Me.cmbTourLength.Location = New System.Drawing.Point(164, 393)
        Me.cmbTourLength.Name = "cmbTourLength"
        Me.cmbTourLength.Size = New System.Drawing.Size(121, 29)
        Me.cmbTourLength.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Tour Length"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 21)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Customer ID"
        '
        'tbxCustID
        '
        Me.tbxCustID.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustID.Location = New System.Drawing.Point(164, 175)
        Me.tbxCustID.Name = "tbxCustID"
        Me.tbxCustID.ReadOnly = True
        Me.tbxCustID.Size = New System.Drawing.Size(131, 26)
        Me.tbxCustID.TabIndex = 71
        '
        'CustomerReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1059, 706)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbxCustID)
        Me.Controls.Add(Me.cmbTourLength)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.dtgReserves)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbTourLoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbxCost)
        Me.Controls.Add(Me.tbxPax)
        Me.Controls.Add(Me.datDepart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbxPhone)
        Me.Controls.Add(Me.tbxCustAdd)
        Me.Controls.Add(Me.tbxCustName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CustomerReservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerReservations"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtgReserves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents tlsFirst As ToolStripButton
    Friend WithEvents tlsPrev As ToolStripButton
    Friend WithEvents tlsNext As ToolStripButton
    Friend WithEvents tlsLast As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbxID As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents tbxCustAdd As TextBox
    Friend WithEvents tbxCustName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents datDepart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxPax As TextBox
    Friend WithEvents tbxCost As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbTourLoc As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtgReserves As DataGridView
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents cmbTourLength As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxCustID As TextBox
End Class
