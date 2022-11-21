<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.userLevelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddResetButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Location = New System.Drawing.Point(299, 59)
        Me.userNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(344, 37)
        Me.userNameTextBox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 31)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "User Level"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(295, 122)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(348, 37)
        Me.passwordTextBox.TabIndex = 26
        '
        'userLevelTextBox
        '
        Me.userLevelTextBox.Location = New System.Drawing.Point(295, 180)
        Me.userLevelTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userLevelTextBox.Name = "userLevelTextBox"
        Me.userLevelTextBox.Size = New System.Drawing.Size(348, 37)
        Me.userLevelTextBox.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.userNameTextBox)
        Me.GroupBox1.Controls.Add(Me.AddResetButton)
        Me.GroupBox1.Controls.Add(Me.userLevelTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.passwordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 512)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton.Location = New System.Drawing.Point(239, 286)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(156, 55)
        Me.CancelButton.TabIndex = 23
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddResetButton
        '
        Me.AddResetButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddResetButton.Location = New System.Drawing.Point(43, 286)
        Me.AddResetButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddResetButton.Name = "AddResetButton"
        Me.AddResetButton.Size = New System.Drawing.Size(156, 55)
        Me.AddResetButton.TabIndex = 22
        Me.AddResetButton.Text = "Button1"
        Me.AddResetButton.UseVisualStyleBackColor = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents userLevelTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddResetButton As Button
End Class
