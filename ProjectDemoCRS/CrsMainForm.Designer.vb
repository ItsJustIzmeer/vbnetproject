<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrsMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrsMainForm))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StafInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassListButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeacherListButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ViewStudentListButton = New System.Windows.Forms.Button()
        Me.StudentListButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SubjectListButton = New System.Windows.Forms.Button()
        Me.RegisterSubjectButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.UserListButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.UserInformationToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.SubjectInfoToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1135, 28)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.ApplicationToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherInformationToolStripMenuItem, Me.StafInformationToolStripMenuItem, Me.StudentInformationToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.TeacherInformationToolStripMenuItem.Text = "Class List"
        '
        'StafInformationToolStripMenuItem
        '
        Me.StafInformationToolStripMenuItem.Name = "StafInformationToolStripMenuItem"
        Me.StafInformationToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.StafInformationToolStripMenuItem.Text = "Assign Teacher"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.StudentInformationToolStripMenuItem.Text = "Enrol Student"
        '
        'UserInformationToolStripMenuItem
        '
        Me.UserInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem})
        Me.UserInformationToolStripMenuItem.Name = "UserInformationToolStripMenuItem"
        Me.UserInformationToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.UserInformationToolStripMenuItem.Text = "User Information"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 24)
        Me.ToolStripMenuItem2.Text = "Student Information"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherListToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 24)
        Me.ToolStripMenuItem1.Text = "Teacher Information"
        '
        'TeacherListToolStripMenuItem
        '
        Me.TeacherListToolStripMenuItem.Name = "TeacherListToolStripMenuItem"
        Me.TeacherListToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.TeacherListToolStripMenuItem.Text = "Teacher List"
        '
        'SubjectInfoToolStripMenuItem
        '
        Me.SubjectInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectListToolStripMenuItem})
        Me.SubjectInfoToolStripMenuItem.Name = "SubjectInfoToolStripMenuItem"
        Me.SubjectInfoToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SubjectInfoToolStripMenuItem.Text = "Subject Information"
        '
        'SubjectListToolStripMenuItem
        '
        Me.SubjectListToolStripMenuItem.Name = "SubjectListToolStripMenuItem"
        Me.SubjectListToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SubjectListToolStripMenuItem.Text = "Subject List"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AbutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AboutToolStripMenuItem.Text = "Search"
        '
        'AbutToolStripMenuItem
        '
        Me.AbutToolStripMenuItem.Name = "AbutToolStripMenuItem"
        Me.AbutToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AbutToolStripMenuItem.Text = "About"
        '
        'ClassListButton
        '
        Me.ClassListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClassListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassListButton.Location = New System.Drawing.Point(243, 49)
        Me.ClassListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClassListButton.Name = "ClassListButton"
        Me.ClassListButton.Size = New System.Drawing.Size(135, 46)
        Me.ClassListButton.TabIndex = 0
        Me.ClassListButton.Text = "Class List"
        Me.ClassListButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(620, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "School Management System"
        '
        'TeacherListButton
        '
        Me.TeacherListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TeacherListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherListButton.Location = New System.Drawing.Point(21, 49)
        Me.TeacherListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TeacherListButton.Name = "TeacherListButton"
        Me.TeacherListButton.Size = New System.Drawing.Size(135, 46)
        Me.TeacherListButton.TabIndex = 1
        Me.TeacherListButton.Text = "Teacher List"
        Me.TeacherListButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.ViewStudentListButton)
        Me.GroupBox1.Controls.Add(Me.StudentListButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(213, 204)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student"
        '
        'ViewStudentListButton
        '
        Me.ViewStudentListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewStudentListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStudentListButton.Location = New System.Drawing.Point(28, 132)
        Me.ViewStudentListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewStudentListButton.Name = "ViewStudentListButton"
        Me.ViewStudentListButton.Size = New System.Drawing.Size(135, 52)
        Me.ViewStudentListButton.TabIndex = 3
        Me.ViewStudentListButton.Text = "View Student List"
        Me.ViewStudentListButton.UseVisualStyleBackColor = False
        '
        'StudentListButton
        '
        Me.StudentListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StudentListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentListButton.Location = New System.Drawing.Point(28, 62)
        Me.StudentListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StudentListButton.Name = "StudentListButton"
        Me.StudentListButton.Size = New System.Drawing.Size(135, 46)
        Me.StudentListButton.TabIndex = 2
        Me.StudentListButton.Text = "Student List"
        Me.StudentListButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.Controls.Add(Me.TeacherListButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 331)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(213, 145)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Teacher"
        '
        'SubjectListButton
        '
        Me.SubjectListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SubjectListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectListButton.Location = New System.Drawing.Point(49, 46)
        Me.SubjectListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectListButton.Name = "SubjectListButton"
        Me.SubjectListButton.Size = New System.Drawing.Size(135, 46)
        Me.SubjectListButton.TabIndex = 5
        Me.SubjectListButton.Text = "Subject List"
        Me.SubjectListButton.UseVisualStyleBackColor = False
        '
        'RegisterSubjectButton
        '
        Me.RegisterSubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RegisterSubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterSubjectButton.Location = New System.Drawing.Point(33, 49)
        Me.RegisterSubjectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterSubjectButton.Name = "RegisterSubjectButton"
        Me.RegisterSubjectButton.Size = New System.Drawing.Size(160, 46)
        Me.RegisterSubjectButton.TabIndex = 6
        Me.RegisterSubjectButton.Text = "Register Subject"
        Me.RegisterSubjectButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(962, 529)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(160, 46)
        Me.LogOutButton.TabIndex = 7
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'UserListButton
        '
        Me.UserListButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UserListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserListButton.Location = New System.Drawing.Point(25, 49)
        Me.UserListButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UserListButton.Name = "UserListButton"
        Me.UserListButton.Size = New System.Drawing.Size(135, 46)
        Me.UserListButton.TabIndex = 8
        Me.UserListButton.Text = "User List"
        Me.UserListButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(341, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Azure
        Me.GroupBox3.Controls.Add(Me.UserListButton)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(341, 331)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 145)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Azure
        Me.GroupBox4.Controls.Add(Me.SubjectListButton)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(644, 331)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(269, 145)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Subject Information"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Azure
        Me.GroupBox5.Controls.Add(Me.RegisterSubjectButton)
        Me.GroupBox5.Controls.Add(Me.ClassListButton)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(644, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(421, 145)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Register"
        '
        'CrsMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1135, 588)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CrsMainForm"
        Me.Text = "CrsMain"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StafInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassListButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TeacherListButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentListButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SubjectListButton As Button
    Friend WithEvents RegisterSubjectButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents UserListButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ViewStudentListButton As Button
    Friend WithEvents SubjectListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
End Class
