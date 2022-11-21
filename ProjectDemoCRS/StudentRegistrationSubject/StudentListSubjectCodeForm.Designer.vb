<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentListSubjectCodeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentListSubjectCodeForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AllButton = New System.Windows.Forms.Button()
        Me.subjectCodeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.studentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.AllButton)
        Me.Search.Controls.Add(Me.subjectCodeButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(8, 16)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4)
        Me.Search.Size = New System.Drawing.Size(1312, 101)
        Me.Search.TabIndex = 15
        Me.Search.TabStop = False
        Me.Search.Text = "Student List Option"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1160, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AllButton
        '
        Me.AllButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AllButton.Location = New System.Drawing.Point(984, 48)
        Me.AllButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(165, 38)
        Me.AllButton.TabIndex = 4
        Me.AllButton.Text = "All Student"
        Me.AllButton.UseVisualStyleBackColor = False
        '
        'subjectCodeButton
        '
        Me.subjectCodeButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.subjectCodeButton.Location = New System.Drawing.Point(719, 49)
        Me.subjectCodeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.subjectCodeButton.Name = "subjectCodeButton"
        Me.subjectCodeButton.Size = New System.Drawing.Size(241, 38)
        Me.subjectCodeButton.TabIndex = 2
        Me.subjectCodeButton.Text = "Subject Code"
        Me.subjectCodeButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(293, 49)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 37)
        Me.searchTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.studentDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1304, 528)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'studentDataGridView
        '
        Me.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentDataGridView.Location = New System.Drawing.Point(16, 24)
        Me.studentDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.studentDataGridView.Name = "studentDataGridView"
        Me.studentDataGridView.RowHeadersWidth = 49
        Me.studentDataGridView.Size = New System.Drawing.Size(1272, 442)
        Me.studentDataGridView.TabIndex = 6
        '
        'StudentListSubjectCodeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 685)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Search)
        Me.Name = "StudentListSubjectCodeForm"
        Me.Text = "StudentListSubjectCodeForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AllButton As Button
    Friend WithEvents subjectCodeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents studentDataGridView As DataGridView
End Class
