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
        Me.UserDataGridView.Location = New System.Drawing.Point(8, 64)
        Me.UserDataGridView.MultiSelect = False
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(784, 295)
        Me.UserDataGridView.TabIndex = 19
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(232, 376)
        Me.DeleteUserButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(209, 60)
        Me.DeleteUserButton.TabIndex = 22
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'AddUserButton
        '
        Me.AddUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserButton.Location = New System.Drawing.Point(16, 376)
        Me.AddUserButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(208, 60)
        Me.AddUserButton.TabIndex = 21
        Me.AddUserButton.Text = "Add User"
        Me.AddUserButton.UseVisualStyleBackColor = True
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPasswordButton.Location = New System.Drawing.Point(448, 376)
        Me.ResetPasswordButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(228, 60)
        Me.ResetPasswordButton.TabIndex = 20
        Me.ResetPasswordButton.Text = "Reset Password"
        Me.ResetPasswordButton.UseVisualStyleBackColor = True
        '
        'UserFormList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.AddUserButton)
        Me.Controls.Add(Me.ResetPasswordButton)
        Me.Controls.Add(Me.UserDataGridView)
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
