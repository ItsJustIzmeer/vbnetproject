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
        Me.Search.SuspendLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(12, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(1178, 82)
        Me.Search.TabIndex = 15
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.Location = New System.Drawing.Point(849, 40)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(124, 31)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = True
        '
        'nameButton
        '
        Me.nameButton.Location = New System.Drawing.Point(699, 37)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(124, 34)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = True
        '
        'ICButton
        '
        Me.ICButton.Location = New System.Drawing.Point(539, 40)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(124, 31)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(220, 40)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(295, 31)
        Me.searchTextBox.TabIndex = 0
        '
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(12, 151)
        Me.TeacherDataGridView.MultiSelect = False
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.Size = New System.Drawing.Size(1178, 295)
        Me.TeacherDataGridView.TabIndex = 14
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(277, 468)
        Me.UpdateTeacherButton.Margin = New System.Windows.Forms.Padding(6)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(209, 60)
        Me.UpdateTeacherButton.TabIndex = 18
        Me.UpdateTeacherButton.Text = "Update Teacher"
        Me.UpdateTeacherButton.UseVisualStyleBackColor = True
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTeacherButton.Location = New System.Drawing.Point(15, 468)
        Me.AddTeacherButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(250, 60)
        Me.AddTeacherButton.TabIndex = 17
        Me.AddTeacherButton.Text = "Add New Teacher"
        Me.AddTeacherButton.UseVisualStyleBackColor = True
        '
        'DeleteTeacherButton
        '
        Me.DeleteTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteTeacherButton.Location = New System.Drawing.Point(498, 468)
        Me.DeleteTeacherButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteTeacherButton.Name = "DeleteTeacherButton"
        Me.DeleteTeacherButton.Size = New System.Drawing.Size(228, 60)
        Me.DeleteTeacherButton.TabIndex = 16
        Me.DeleteTeacherButton.Text = "Delete Teacher"
        Me.DeleteTeacherButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Click on identification number to enable more option"
        '
        'TeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 556)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.DeleteTeacherButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.Name = "TeacherListForm"
        Me.Text = "TeacherListForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
