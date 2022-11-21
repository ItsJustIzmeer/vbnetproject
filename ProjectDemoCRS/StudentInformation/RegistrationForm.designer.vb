<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.icLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.matricNumberLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.EmailButton = New System.Windows.Forms.Button()
        Me.DisplaySubjectButton = New System.Windows.Forms.Button()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        Me.SubjectRegisterDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AmountFeeLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotalCreditLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.classLabel)
        Me.GroupBox1.Controls.Add(Me.icLabel)
        Me.GroupBox1.Controls.Add(Me.nameLabel)
        Me.GroupBox1.Controls.Add(Me.matricNumberLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(938, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(248, 168)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(257, 35)
        Me.PhoneNumberLabel.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 31)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Phone Number"
        '
        'classLabel
        '
        Me.classLabel.BackColor = System.Drawing.SystemColors.Window
        Me.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classLabel.Location = New System.Drawing.Point(655, 48)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(257, 35)
        Me.classLabel.TabIndex = 7
        '
        'icLabel
        '
        Me.icLabel.BackColor = System.Drawing.SystemColors.Window
        Me.icLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.icLabel.Location = New System.Drawing.Point(248, 125)
        Me.icLabel.Name = "icLabel"
        Me.icLabel.Size = New System.Drawing.Size(257, 35)
        Me.icLabel.TabIndex = 6
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.SystemColors.Window
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(248, 88)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(257, 35)
        Me.nameLabel.TabIndex = 5
        '
        'matricNumberLabel
        '
        Me.matricNumberLabel.BackColor = System.Drawing.SystemColors.Window
        Me.matricNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matricNumberLabel.Location = New System.Drawing.Point(248, 48)
        Me.matricNumberLabel.Name = "matricNumberLabel"
        Me.matricNumberLabel.Size = New System.Drawing.Size(257, 35)
        Me.matricNumberLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matric Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.PrintButton)
        Me.GroupBox2.Controls.Add(Me.EmailButton)
        Me.GroupBox2.Controls.Add(Me.DisplaySubjectButton)
        Me.GroupBox2.Controls.Add(Me.AddSubjectButton)
        Me.GroupBox2.Controls.Add(Me.DropButton)
        Me.GroupBox2.Controls.Add(Me.SubjectRegisterDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 343)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Register"
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PrintButton.Location = New System.Drawing.Point(352, 272)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(179, 53)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'EmailButton
        '
        Me.EmailButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.EmailButton.Location = New System.Drawing.Point(168, 272)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.Size = New System.Drawing.Size(179, 53)
        Me.EmailButton.TabIndex = 5
        Me.EmailButton.Text = "Send Email"
        Me.EmailButton.UseVisualStyleBackColor = False
        '
        'DisplaySubjectButton
        '
        Me.DisplaySubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DisplaySubjectButton.Location = New System.Drawing.Point(21, 213)
        Me.DisplaySubjectButton.Name = "DisplaySubjectButton"
        Me.DisplaySubjectButton.Size = New System.Drawing.Size(211, 53)
        Me.DisplaySubjectButton.TabIndex = 4
        Me.DisplaySubjectButton.Text = "Display Subject"
        Me.DisplaySubjectButton.UseVisualStyleBackColor = False
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddSubjectButton.Location = New System.Drawing.Point(247, 213)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(179, 53)
        Me.AddSubjectButton.TabIndex = 3
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = False
        '
        'DropButton
        '
        Me.DropButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DropButton.Location = New System.Drawing.Point(442, 213)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(179, 53)
        Me.DropButton.TabIndex = 2
        Me.DropButton.Text = "Drop Subject"
        Me.DropButton.UseVisualStyleBackColor = False
        '
        'SubjectRegisterDataGridView
        '
        Me.SubjectRegisterDataGridView.AllowUserToResizeRows = False
        Me.SubjectRegisterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SubjectRegisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectRegisterDataGridView.Location = New System.Drawing.Point(21, 50)
        Me.SubjectRegisterDataGridView.Name = "SubjectRegisterDataGridView"
        Me.SubjectRegisterDataGridView.RowHeadersWidth = 51
        Me.SubjectRegisterDataGridView.Size = New System.Drawing.Size(600, 150)
        Me.SubjectRegisterDataGridView.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Controls.Add(Me.AmountFeeLabel)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TotalCreditLabel)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(704, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 343)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fee Amount"
        '
        'AmountFeeLabel
        '
        Me.AmountFeeLabel.BackColor = System.Drawing.SystemColors.Window
        Me.AmountFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountFeeLabel.Location = New System.Drawing.Point(192, 112)
        Me.AmountFeeLabel.Name = "AmountFeeLabel"
        Me.AmountFeeLabel.Size = New System.Drawing.Size(257, 35)
        Me.AmountFeeLabel.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 31)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fee Amount"
        '
        'TotalCreditLabel
        '
        Me.TotalCreditLabel.BackColor = System.Drawing.SystemColors.Window
        Me.TotalCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCreditLabel.Location = New System.Drawing.Point(192, 64)
        Me.TotalCreditLabel.Name = "TotalCreditLabel"
        Me.TotalCreditLabel.Size = New System.Drawing.Size(257, 35)
        Me.TotalCreditLabel.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Credit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(986, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 203)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1205, 669)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents classLabel As System.Windows.Forms.Label
    Friend WithEvents icLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents matricNumberLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SubjectRegisterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddSubjectButton As System.Windows.Forms.Button
    Friend WithEvents DropButton As System.Windows.Forms.Button
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintButton As Button
    Friend WithEvents EmailButton As Button
    Friend WithEvents DisplaySubjectButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AmountFeeLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TotalCreditLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
