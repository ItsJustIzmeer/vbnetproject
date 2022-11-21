<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectListForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.subjectCodeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.deleteSubjectButton = New System.Windows.Forms.Button()
        Me.updateSubjectButton = New System.Windows.Forms.Button()
        Me.addSubjectButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Search.Controls.Add(Me.PictureBox1)
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.subjectCodeButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(16, 24)
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
        Me.nameButton.Location = New System.Drawing.Point(968, 48)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(165, 42)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
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
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Location = New System.Drawing.Point(16, 160)
        Me.SubjectDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectDataGridView.MultiSelect = False
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersWidth = 49
        Me.SubjectDataGridView.Size = New System.Drawing.Size(1584, 399)
        Me.SubjectDataGridView.TabIndex = 16
        '
        'deleteSubjectButton
        '
        Me.deleteSubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.deleteSubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteSubjectButton.Location = New System.Drawing.Point(872, 576)
        Me.deleteSubjectButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.deleteSubjectButton.Name = "deleteSubjectButton"
        Me.deleteSubjectButton.Size = New System.Drawing.Size(200, 74)
        Me.deleteSubjectButton.TabIndex = 21
        Me.deleteSubjectButton.Text = "Delete Subject"
        Me.deleteSubjectButton.UseVisualStyleBackColor = False
        '
        'updateSubjectButton
        '
        Me.updateSubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.updateSubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateSubjectButton.Location = New System.Drawing.Point(584, 576)
        Me.updateSubjectButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.updateSubjectButton.Name = "updateSubjectButton"
        Me.updateSubjectButton.Size = New System.Drawing.Size(200, 74)
        Me.updateSubjectButton.TabIndex = 20
        Me.updateSubjectButton.Text = "Update Subject"
        Me.updateSubjectButton.UseVisualStyleBackColor = False
        '
        'addSubjectButton
        '
        Me.addSubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.addSubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSubjectButton.Location = New System.Drawing.Point(296, 576)
        Me.addSubjectButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.addSubjectButton.Name = "addSubjectButton"
        Me.addSubjectButton.Size = New System.Drawing.Size(200, 74)
        Me.addSubjectButton.TabIndex = 19
        Me.addSubjectButton.Text = "Add New Subject"
        Me.addSubjectButton.UseVisualStyleBackColor = False
        '
        'printButton
        '
        Me.printButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.printButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printButton.Location = New System.Drawing.Point(1392, 584)
        Me.printButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(200, 74)
        Me.printButton.TabIndex = 22
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1619, 701)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.deleteSubjectButton)
        Me.Controls.Add(Me.updateSubjectButton)
        Me.Controls.Add(Me.addSubjectButton)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Controls.Add(Me.Search)
        Me.Name = "SubjectListForm"
        Me.Text = "SubjectListForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents subjectCodeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents SubjectDataGridView As DataGridView
    Friend WithEvents deleteSubjectButton As Button
    Friend WithEvents updateSubjectButton As Button
    Friend WithEvents addSubjectButton As Button
    Friend WithEvents printButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
