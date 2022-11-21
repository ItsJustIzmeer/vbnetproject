<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dobDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.subjectCodeBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.icNumberTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.FemaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.MaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dobDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.subjectCodeBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.icNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.idTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(909, 620)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teacher Information"
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(437, 276)
        Me.FemaleRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(125, 35)
        Me.FemaleRadioButton.TabIndex = 24
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(277, 276)
        Me.MaleRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(93, 35)
        Me.MaleRadioButton.TabIndex = 23
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 266)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Gender"
        '
        'dobDateTimePicker1
        '
        Me.dobDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dobDateTimePicker1.Location = New System.Drawing.Point(267, 335)
        Me.dobDateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.dobDateTimePicker1.Name = "dobDateTimePicker1"
        Me.dobDateTimePicker1.Size = New System.Drawing.Size(345, 37)
        Me.dobDateTimePicker1.TabIndex = 21
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(271, 191)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(348, 37)
        Me.nameTextBox.TabIndex = 20
        '
        'subjectCodeBox
        '
        Me.subjectCodeBox.FormattingEnabled = True
        Me.subjectCodeBox.Location = New System.Drawing.Point(264, 454)
        Me.subjectCodeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.subjectCodeBox.Name = "subjectCodeBox"
        Me.subjectCodeBox.Size = New System.Drawing.Size(348, 38)
        Me.subjectCodeBox.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 454)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 31)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Subject Code"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(264, 393)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(348, 37)
        Me.PhoneNumberTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 393)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 31)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 31)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date of birth"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton.Location = New System.Drawing.Point(391, 514)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(156, 55)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddUpdateButton.Location = New System.Drawing.Point(195, 514)
        Me.AddUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(156, 55)
        Me.AddUpdateButton.TabIndex = 6
        Me.AddUpdateButton.Text = "Button1"
        Me.AddUpdateButton.UseVisualStyleBackColor = False
        '
        'icNumberTextBox
        '
        Me.icNumberTextBox.Location = New System.Drawing.Point(271, 133)
        Me.icNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.icNumberTextBox.Name = "icNumberTextBox"
        Me.icNumberTextBox.Size = New System.Drawing.Size(348, 37)
        Me.icNumberTextBox.TabIndex = 4
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(275, 70)
        Me.idTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(344, 37)
        Me.idTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ic Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(699, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 158)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 657)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TeacherForm"
        Me.Text = "TeacherForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dobDateTimePicker1 As DateTimePicker
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents icNumberTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents subjectCodeBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
