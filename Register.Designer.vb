<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.tbxCustName = New System.Windows.Forms.TextBox()
        Me.tbxCustAdd = New System.Windows.Forms.TextBox()
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 290)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 357)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Customer Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 423)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Phone Number"
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(217, 150)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(352, 26)
        Me.tbxUser.TabIndex = 12
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(217, 216)
        Me.tbxPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(352, 26)
        Me.tbxPass.TabIndex = 13
        '
        'tbxCustName
        '
        Me.tbxCustName.Location = New System.Drawing.Point(217, 282)
        Me.tbxCustName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxCustName.Name = "tbxCustName"
        Me.tbxCustName.Size = New System.Drawing.Size(351, 26)
        Me.tbxCustName.TabIndex = 14
        '
        'tbxCustAdd
        '
        Me.tbxCustAdd.Location = New System.Drawing.Point(217, 349)
        Me.tbxCustAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxCustAdd.Name = "tbxCustAdd"
        Me.tbxCustAdd.Size = New System.Drawing.Size(477, 26)
        Me.tbxCustAdd.TabIndex = 15
        '
        'tbxPhone
        '
        Me.tbxPhone.Location = New System.Drawing.Point(217, 415)
        Me.tbxPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(477, 26)
        Me.tbxPhone.TabIndex = 16
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(69, 493)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(188, 37)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(298, 493)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 37)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(606, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 262)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(317, 50)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Create New Account"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(904, 600)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
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
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPass As TextBox
    Friend WithEvents tbxCustName As TextBox
    Friend WithEvents tbxCustAdd As TextBox
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
