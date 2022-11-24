<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserFormList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserFormList))
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.AddUserButton = New System.Windows.Forms.Button()
        Me.ResetPasswordButton = New System.Windows.Forms.Button()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Location = New System.Drawing.Point(11, 79)
        Me.UserDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.UserDataGridView.MultiSelect = False
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersWidth = 51
        Me.UserDataGridView.Size = New System.Drawing.Size(1045, 363)
        Me.UserDataGridView.TabIndex = 19
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(309, 463)
        Me.DeleteUserButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(279, 74)
        Me.DeleteUserButton.TabIndex = 22
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = False
        '
        'AddUserButton
        '
        Me.AddUserButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserButton.Location = New System.Drawing.Point(21, 463)
        Me.AddUserButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(277, 74)
        Me.AddUserButton.TabIndex = 21
        Me.AddUserButton.Text = "Add User"
        Me.AddUserButton.UseVisualStyleBackColor = False
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ResetPasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPasswordButton.Location = New System.Drawing.Point(597, 463)
        Me.ResetPasswordButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(304, 74)
        Me.ResetPasswordButton.TabIndex = 20
        Me.ResetPasswordButton.Text = "Update User"
        Me.ResetPasswordButton.UseVisualStyleBackColor = False
        '
        'UserFormList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.AddUserButton)
        Me.Controls.Add(Me.ResetPasswordButton)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserFormList"
        Me.Text = "UserForm"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents AddUserButton As Button
    Friend WithEvents ResetPasswordButton As Button
End Class
