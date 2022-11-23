<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.subjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.creditTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.subjectCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.creditTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(973, 480)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(725, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 158)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton.Location = New System.Drawing.Point(487, 286)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(156, 55)
        Me.CancelButton.TabIndex = 23
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'subjectCodeTextBox
        '
        Me.subjectCodeTextBox.Location = New System.Drawing.Point(295, 59)
        Me.subjectCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.subjectCodeTextBox.Name = "subjectCodeTextBox"
        Me.subjectCodeTextBox.Size = New System.Drawing.Size(348, 31)
        Me.subjectCodeTextBox.TabIndex = 25
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddUpdateButton.Location = New System.Drawing.Point(295, 286)
        Me.AddUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(156, 55)
        Me.AddUpdateButton.TabIndex = 22
        Me.AddUpdateButton.Text = "Button1"
        Me.AddUpdateButton.UseVisualStyleBackColor = False
        '
        'creditTextBox
        '
        Me.creditTextBox.Location = New System.Drawing.Point(295, 180)
        Me.creditTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.creditTextBox.Name = "creditTextBox"
        Me.creditTextBox.Size = New System.Drawing.Size(348, 31)
        Me.creditTextBox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Credit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(295, 122)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(348, 31)
        Me.nameTextBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Subject Code"
        '
        'SubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SubjectForm"
        Me.Text = "SubjectForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents subjectCodeTextBox As TextBox
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents creditTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
