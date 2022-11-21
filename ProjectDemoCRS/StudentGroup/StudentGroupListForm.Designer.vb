<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentGroupListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentGroupListForm))
        Me.StudentGroupDataGridView = New System.Windows.Forms.DataGridView()
        Me.updateStudentGroupButton = New System.Windows.Forms.Button()
        Me.AddStudentGroupButton = New System.Windows.Forms.Button()
        Me.DeleteStudentGroupButton = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.GroupIdButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentGroupDataGridView
        '
        Me.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGroupDataGridView.Location = New System.Drawing.Point(16, 165)
        Me.StudentGroupDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.StudentGroupDataGridView.MultiSelect = False
        Me.StudentGroupDataGridView.Name = "StudentGroupDataGridView"
        Me.StudentGroupDataGridView.RowHeadersWidth = 51
        Me.StudentGroupDataGridView.Size = New System.Drawing.Size(1310, 416)
        Me.StudentGroupDataGridView.TabIndex = 0
        '
        'updateStudentGroupButton
        '
        Me.updateStudentGroupButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.updateStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentGroupButton.Location = New System.Drawing.Point(409, 592)
        Me.updateStudentGroupButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.updateStudentGroupButton.Name = "updateStudentGroupButton"
        Me.updateStudentGroupButton.Size = New System.Drawing.Size(279, 74)
        Me.updateStudentGroupButton.TabIndex = 8
        Me.updateStudentGroupButton.Text = "Update Class"
        Me.updateStudentGroupButton.UseVisualStyleBackColor = False
        '
        'AddStudentGroupButton
        '
        Me.AddStudentGroupButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentGroupButton.Location = New System.Drawing.Point(72, 592)
        Me.AddStudentGroupButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.AddStudentGroupButton.Name = "AddStudentGroupButton"
        Me.AddStudentGroupButton.Size = New System.Drawing.Size(279, 74)
        Me.AddStudentGroupButton.TabIndex = 7
        Me.AddStudentGroupButton.Text = "Add New Class"
        Me.AddStudentGroupButton.UseVisualStyleBackColor = False
        '
        'DeleteStudentGroupButton
        '
        Me.DeleteStudentGroupButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentGroupButton.Location = New System.Drawing.Point(730, 592)
        Me.DeleteStudentGroupButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteStudentGroupButton.Name = "DeleteStudentGroupButton"
        Me.DeleteStudentGroupButton.Size = New System.Drawing.Size(304, 74)
        Me.DeleteStudentGroupButton.TabIndex = 6
        Me.DeleteStudentGroupButton.Text = "Delete Class"
        Me.DeleteStudentGroupButton.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox2)
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.GroupIdButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(16, 32)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4)
        Me.Search.Size = New System.Drawing.Size(1310, 101)
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
        'displayAllButton
        '
        Me.displayAllButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.displayAllButton.Location = New System.Drawing.Point(936, 48)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(165, 38)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
        '
        'GroupIdButton
        '
        Me.GroupIdButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupIdButton.Location = New System.Drawing.Point(719, 49)
        Me.GroupIdButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupIdButton.Name = "GroupIdButton"
        Me.GroupIdButton.Size = New System.Drawing.Size(185, 38)
        Me.GroupIdButton.TabIndex = 2
        Me.GroupIdButton.Text = "By Group ID"
        Me.GroupIdButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Group ID"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(293, 49)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 37)
        Me.searchTextBox.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1171, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'StudentGroupListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1339, 689)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateStudentGroupButton)
        Me.Controls.Add(Me.AddStudentGroupButton)
        Me.Controls.Add(Me.DeleteStudentGroupButton)
        Me.Controls.Add(Me.StudentGroupDataGridView)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentGroupListForm"
        Me.Text = "StudentGroupForm"
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentGroupDataGridView As DataGridView
    Friend WithEvents updateStudentGroupButton As Button
    Friend WithEvents AddStudentGroupButton As Button
    Friend WithEvents DeleteStudentGroupButton As Button
    Friend WithEvents Search As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents GroupIdButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
