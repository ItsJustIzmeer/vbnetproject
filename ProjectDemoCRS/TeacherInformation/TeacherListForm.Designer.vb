<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherListForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.TeacherDataGridView = New System.Windows.Forms.DataGridView()
        Me.UpdateTeacherButton = New System.Windows.Forms.Button()
        Me.AddTeacherButton = New System.Windows.Forms.Button()
        Me.DeleteTeacherButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Search.SuspendLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(16, 15)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Size = New System.Drawing.Size(1571, 101)
        Me.Search.TabIndex = 15
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.displayAllButton.Location = New System.Drawing.Point(1132, 49)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(165, 38)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
        '
        'nameButton
        '
        Me.nameButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.nameButton.Location = New System.Drawing.Point(932, 46)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(165, 42)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
        '
        'ICButton
        '
        Me.ICButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ICButton.Location = New System.Drawing.Point(719, 49)
        Me.ICButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(165, 38)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = False
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
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 37)
        Me.searchTextBox.TabIndex = 0
        '
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(16, 186)
        Me.TeacherDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TeacherDataGridView.MultiSelect = False
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.RowHeadersWidth = 51
        Me.TeacherDataGridView.Size = New System.Drawing.Size(1571, 363)
        Me.TeacherDataGridView.TabIndex = 14
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UpdateTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(369, 576)
        Me.UpdateTeacherButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(279, 74)
        Me.UpdateTeacherButton.TabIndex = 18
        Me.UpdateTeacherButton.Text = "Update Teacher"
        Me.UpdateTeacherButton.UseVisualStyleBackColor = False
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTeacherButton.Location = New System.Drawing.Point(20, 576)
        Me.AddTeacherButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(333, 74)
        Me.AddTeacherButton.TabIndex = 17
        Me.AddTeacherButton.Text = "Add New Teacher"
        Me.AddTeacherButton.UseVisualStyleBackColor = False
        '
        'DeleteTeacherButton
        '
        Me.DeleteTeacherButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DeleteTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteTeacherButton.Location = New System.Drawing.Point(664, 576)
        Me.DeleteTeacherButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteTeacherButton.Name = "DeleteTeacherButton"
        Me.DeleteTeacherButton.Size = New System.Drawing.Size(304, 74)
        Me.DeleteTeacherButton.TabIndex = 16
        Me.DeleteTeacherButton.Text = "Delete Teacher"
        Me.DeleteTeacherButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(569, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Click on identification number to enable more option"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1432, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1632, 684)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.DeleteTeacherButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TeacherListForm"
        Me.Text = "TeacherListForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents TeacherDataGridView As DataGridView
    Friend WithEvents UpdateTeacherButton As Button
    Friend WithEvents AddTeacherButton As Button
    Friend WithEvents DeleteTeacherButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
