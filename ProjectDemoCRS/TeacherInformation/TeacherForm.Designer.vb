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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(682, 504)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teacher Information"
        '
        'dobDateTimePicker1
        '
        Me.dobDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dobDateTimePicker1.Location = New System.Drawing.Point(200, 272)
        Me.dobDateTimePicker1.Name = "dobDateTimePicker1"
        Me.dobDateTimePicker1.Size = New System.Drawing.Size(260, 31)
        Me.dobDateTimePicker1.TabIndex = 21
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(203, 155)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(262, 31)
        Me.nameTextBox.TabIndex = 20
        '
        'subjectCodeBox
        '
        Me.subjectCodeBox.FormattingEnabled = True
        Me.subjectCodeBox.Location = New System.Drawing.Point(198, 369)
        Me.subjectCodeBox.Name = "subjectCodeBox"
        Me.subjectCodeBox.Size = New System.Drawing.Size(262, 33)
        Me.subjectCodeBox.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Subject Code"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(198, 319)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(262, 31)
        Me.PhoneNumberTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date of birth"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(293, 418)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(117, 45)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Location = New System.Drawing.Point(146, 418)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(117, 45)
        Me.AddUpdateButton.TabIndex = 6
        Me.AddUpdateButton.Text = "Button1"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        '
        'icNumberTextBox
        '
        Me.icNumberTextBox.Location = New System.Drawing.Point(203, 108)
        Me.icNumberTextBox.Name = "icNumberTextBox"
        Me.icNumberTextBox.Size = New System.Drawing.Size(262, 31)
        Me.icNumberTextBox.TabIndex = 4
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(206, 57)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(259, 31)
        Me.idTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ic Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Gender"
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(208, 224)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(77, 29)
        Me.MaleRadioButton.TabIndex = 23
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(328, 224)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(101, 29)
        Me.FemaleRadioButton.TabIndex = 24
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TeacherForm"
        Me.Text = "TeacherForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
