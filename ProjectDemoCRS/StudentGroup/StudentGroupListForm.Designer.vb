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
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentGroupDataGridView
        '
        Me.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGroupDataGridView.Location = New System.Drawing.Point(16, 165)
        Me.StudentGroupDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentGroupDataGridView.MultiSelect = False
        Me.StudentGroupDataGridView.Name = "StudentGroupDataGridView"
        Me.StudentGroupDataGridView.RowHeadersWidth = 51
        Me.StudentGroupDataGridView.Size = New System.Drawing.Size(1178, 416)
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
        'StudentGroupListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 689)
        Me.Controls.Add(Me.updateStudentGroupButton)
        Me.Controls.Add(Me.AddStudentGroupButton)
        Me.Controls.Add(Me.DeleteStudentGroupButton)
        Me.Controls.Add(Me.StudentGroupDataGridView)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StudentGroupListForm"
        Me.Text = "StudentGroupForm"
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentGroupDataGridView As DataGridView
    Friend WithEvents updateStudentGroupButton As Button
    Friend WithEvents AddStudentGroupButton As Button
    Friend WithEvents DeleteStudentGroupButton As Button
End Class
