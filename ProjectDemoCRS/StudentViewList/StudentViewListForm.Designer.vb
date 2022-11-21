<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentViewListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentViewListForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.icButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.icButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(8, 16)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4)
        Me.Search.Size = New System.Drawing.Size(1571, 101)
        Me.Search.TabIndex = 15
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
        Me.displayAllButton.Location = New System.Drawing.Point(1136, 48)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(165, 38)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
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
        'icButton
        '
        Me.icButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.icButton.Location = New System.Drawing.Point(719, 49)
        Me.icButton.Margin = New System.Windows.Forms.Padding(4)
        Me.icButton.Name = "icButton"
        Me.icButton.Size = New System.Drawing.Size(241, 38)
        Me.icButton.TabIndex = 2
        Me.icButton.Text = "By IC"
        Me.icButton.UseVisualStyleBackColor = False
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
        'StudentDataGridView
        '
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(8, 168)
        Me.StudentDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 49
        Me.StudentDataGridView.Size = New System.Drawing.Size(1560, 416)
        Me.StudentDataGridView.TabIndex = 27
        '
        'StudentViewListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1592, 638)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.Search)
        Me.Name = "StudentViewListForm"
        Me.Text = "StudentViewListForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents icButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents StudentDataGridView As DataGridView
End Class
