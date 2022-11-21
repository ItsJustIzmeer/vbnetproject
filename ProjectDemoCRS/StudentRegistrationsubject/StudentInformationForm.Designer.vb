<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInformationForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInformationForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CourseTreeView = New System.Windows.Forms.TreeView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.studentDataGridView = New System.Windows.Forms.DataGridView()
        Me.ViewSubjectCodeButton = New System.Windows.Forms.Button()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.RegistrationButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.matricButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.CourseTreeView)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 152)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(248, 528)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Program List"
        '
        'CourseTreeView
        '
        Me.CourseTreeView.BackColor = System.Drawing.Color.LightGray
        Me.CourseTreeView.Location = New System.Drawing.Point(16, 32)
        Me.CourseTreeView.Margin = New System.Windows.Forms.Padding(4)
        Me.CourseTreeView.Name = "CourseTreeView"
        Me.CourseTreeView.Size = New System.Drawing.Size(224, 463)
        Me.CourseTreeView.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1432, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.studentDataGridView)
        Me.GroupBox2.Controls.Add(Me.ViewSubjectCodeButton)
        Me.GroupBox2.Controls.Add(Me.DeleteStudentButton)
        Me.GroupBox2.Controls.Add(Me.RegistrationButton)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(296, 152)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1080, 528)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'studentDataGridView
        '
        Me.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.studentDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentDataGridView.Location = New System.Drawing.Point(24, 32)
        Me.studentDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.studentDataGridView.Name = "studentDataGridView"
        Me.studentDataGridView.RowHeadersWidth = 49
        Me.studentDataGridView.Size = New System.Drawing.Size(840, 480)
        Me.studentDataGridView.TabIndex = 19
        '
        'ViewSubjectCodeButton
        '
        Me.ViewSubjectCodeButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewSubjectCodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSubjectCodeButton.Location = New System.Drawing.Point(876, 421)
        Me.ViewSubjectCodeButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ViewSubjectCodeButton.Name = "ViewSubjectCodeButton"
        Me.ViewSubjectCodeButton.Size = New System.Drawing.Size(200, 74)
        Me.ViewSubjectCodeButton.TabIndex = 18
        Me.ViewSubjectCodeButton.Text = "View List Subject Code"
        Me.ViewSubjectCodeButton.UseVisualStyleBackColor = False
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentButton.Location = New System.Drawing.Point(876, 333)
        Me.DeleteStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(200, 74)
        Me.DeleteStudentButton.TabIndex = 17
        Me.DeleteStudentButton.Text = "Delete Student"
        Me.DeleteStudentButton.UseVisualStyleBackColor = False
        '
        'RegistrationButton
        '
        Me.RegistrationButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RegistrationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationButton.Location = New System.Drawing.Point(876, 245)
        Me.RegistrationButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(200, 74)
        Me.RegistrationButton.TabIndex = 16
        Me.RegistrationButton.Text = "Subject Registration"
        Me.RegistrationButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1432, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.AllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.matricButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(16, 24)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4)
        Me.Search.Size = New System.Drawing.Size(1571, 101)
        Me.Search.TabIndex = 14
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1432, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AllButton
        '
        Me.AllButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AllButton.Location = New System.Drawing.Point(1136, 48)
        Me.AllButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(165, 38)
        Me.AllButton.TabIndex = 4
        Me.AllButton.Text = "All Student"
        Me.AllButton.UseVisualStyleBackColor = False
        '
        'nameButton
        '
        Me.nameButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.nameButton.Location = New System.Drawing.Point(960, 48)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(165, 42)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
        '
        'matricButton
        '
        Me.matricButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.matricButton.Location = New System.Drawing.Point(719, 49)
        Me.matricButton.Margin = New System.Windows.Forms.Padding(4)
        Me.matricButton.Name = "matricButton"
        Me.matricButton.Size = New System.Drawing.Size(241, 38)
        Me.matricButton.TabIndex = 2
        Me.matricButton.Text = "By Matric Number"
        Me.matricButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(293, 49)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 37)
        Me.searchTextBox.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowCurrentPage = True
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(876, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(197, 168)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'StudentInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1387, 700)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "StudentInformationForm"
        Me.Text = "StudentInformationForm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CourseTreeView As TreeView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Search As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents matricButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents ViewSubjectCodeButton As Button
    Friend WithEvents DeleteStudentButton As Button
    Friend WithEvents studentDataGridView As DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PictureBox4 As PictureBox
End Class
