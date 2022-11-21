<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationFormPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationFormPrint))
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AmountFeeLabel = New System.Windows.Forms.Label()
        Me.SubjectRegisterDataGridView = New System.Windows.Forms.DataGridView()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.IClabel = New System.Windows.Forms.Label()
        Me.matricNumberLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalCreditLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplaySubjectToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DisplaySubjectToolStripMenuItem
        '
        Me.DisplaySubjectToolStripMenuItem.Name = "DisplaySubjectToolStripMenuItem"
        Me.DisplaySubjectToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.DisplaySubjectToolStripMenuItem.Text = "Display Subject"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(628, 54)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(221, 215)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'classLabel
        '
        Me.classLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classLabel.Location = New System.Drawing.Point(268, 236)
        Me.classLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(342, 43)
        Me.classLabel.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Class"
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.phoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneNumberLabel.Location = New System.Drawing.Point(268, 186)
        Me.phoneNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(342, 43)
        Me.phoneNumberLabel.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(468, 384)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Fee Amount"
        '
        'AmountFeeLabel
        '
        Me.AmountFeeLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.AmountFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountFeeLabel.Location = New System.Drawing.Point(601, 383)
        Me.AmountFeeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AmountFeeLabel.Name = "AmountFeeLabel"
        Me.AmountFeeLabel.Size = New System.Drawing.Size(199, 34)
        Me.AmountFeeLabel.TabIndex = 6
        '
        'SubjectRegisterDataGridView
        '
        Me.SubjectRegisterDataGridView.AllowUserToResizeRows = False
        Me.SubjectRegisterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SubjectRegisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectRegisterDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.SubjectRegisterDataGridView.Location = New System.Drawing.Point(27, 50)
        Me.SubjectRegisterDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectRegisterDataGridView.Name = "SubjectRegisterDataGridView"
        Me.SubjectRegisterDataGridView.RowHeadersWidth = 49
        Me.SubjectRegisterDataGridView.Size = New System.Drawing.Size(800, 303)
        Me.SubjectRegisterDataGridView.TabIndex = 0
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(268, 137)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(342, 43)
        Me.nameLabel.TabIndex = 6
        '
        'IClabel
        '
        Me.IClabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IClabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IClabel.Location = New System.Drawing.Point(268, 91)
        Me.IClabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IClabel.Name = "IClabel"
        Me.IClabel.Size = New System.Drawing.Size(342, 43)
        Me.IClabel.TabIndex = 5
        '
        'matricNumberLabel
        '
        Me.matricNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.matricNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matricNumberLabel.Location = New System.Drawing.Point(268, 42)
        Me.matricNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.matricNumberLabel.Name = "matricNumberLabel"
        Me.matricNumberLabel.Size = New System.Drawing.Size(342, 43)
        Me.matricNumberLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IC Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matric Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 384)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Credit"
        '
        'TotalCreditLabel
        '
        Me.TotalCreditLabel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TotalCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCreditLabel.Location = New System.Drawing.Point(188, 383)
        Me.TotalCreditLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalCreditLabel.Name = "TotalCreditLabel"
        Me.TotalCreditLabel.Size = New System.Drawing.Size(199, 34)
        Me.TotalCreditLabel.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.03478!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(204, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(549, 39)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "OFFICIAL REGISTRATION SLIP"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TotalCreditLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.AmountFeeLabel)
        Me.GroupBox2.Controls.Add(Me.SubjectRegisterDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 400)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(860, 534)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Register"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.classLabel)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.phoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.nameLabel)
        Me.GroupBox1.Controls.Add(Me.IClabel)
        Me.GroupBox1.Controls.Add(Me.matricNumberLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(860, 302)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
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
        'RegistrationFormPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 947)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RegistrationFormPrint"
        Me.Text = "RegistrationFormPrint"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySubjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents classLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AmountFeeLabel As Label
    Friend WithEvents SubjectRegisterDataGridView As DataGridView
    Friend WithEvents nameLabel As Label
    Friend WithEvents IClabel As Label
    Friend WithEvents matricNumberLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TotalCreditLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
