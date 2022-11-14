Public Class TeacherForm
    Dim myTeacher As New Teacher

    Dim OldTeacherRec As TeacherRecord

    Friend Sub prepareToUpdateTeacher(teacherID As String)
        'MessageBox.Show("to update student with matric" & studentMatric)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingTeacherInfo(teacherID)
    End Sub
    Private Sub displayExistingTeacherInfo(teacherID As String)
        Try
            OldTeacherRec = myTeacher.getTeacherRecord(teacherID)
            With Me
                .icNumberTextBox.Text = OldTeacherRec.ic
                .idTextBox.Text = OldTeacherRec.id
                .nameTextBox.Text = OldTeacherRec.name
                .dobDateTimePicker1.Value = OldTeacherRec.dob.Date
                .PhoneNumberTextBox.Text = OldTeacherRec.phone
                .subjectCodeBox.Text = OldTeacherRec.subject

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewTeacher()
        clearTeacherForm()

        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisTeacher() 'add new teacher
        Else 'update
            updateThisTeacher(OldTeacherRec)
        End If
    End Sub

    Private Sub addThisTeacher()
        Dim theNewTeacherRec As New TeacherRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewTeacherRec
            .ic = icNumberTextBox.Text
            .id = idTextBox.Text
            .gender = getLevelFromRadioButton()
            .name = nameTextBox.Text
            .dob = dobDateTimePicker1.Value
            .phone = PhoneNumberTextBox.Text
            .subject = subjectCodeBox.Text
        End With

        addOk = myTeacher.addTeacher(theNewTeacherRec)
        If addOk Then
            messageString = "New Teacher with ID : " & theNewTeacherRec.id & " has been added"
            MessageBox.Show(messageString, "Add New Teacher ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub clearTeacherForm()
        With Me
            .idTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()
            .MaleRadioButton.Checked = False
            .FemaleRadioButton.Checked = False
            .dobDateTimePicker1.Value = DateTime.Today
            .PhoneNumberTextBox.Clear()
            .subjectCodeBox.SelectedIndex = -1
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub updateThisTeacher(oldTeacherRec As TeacherRecord)
        Dim theNewTeacherRec As New TeacherRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewTeacherRec.id = idTextBox.Text
        theNewTeacherRec.ic = icNumberTextBox.Text
        theNewTeacherRec.name = nameTextBox.Text
        theNewTeacherRec.gender = getLevelFromRadioButton()
        theNewTeacherRec.dob = dobDateTimePicker1.Value
        theNewTeacherRec.phone = PhoneNumberTextBox.Text
        theNewTeacherRec.subject = subjectCodeBox.Text
        updateOk = myTeacher.updateThisTeacher(oldTeacherRec, theNewTeacherRec)
        If updateOk Then
            messageString = "Teacher with ID : " & theNewTeacherRec.id & " has been updated"
            MessageBox.Show(messageString, "Update Teacher Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Function getLevelFromRadioButton() As String
        If MaleRadioButton.Checked Then
            Return "MALE"
        Else
            Return "FEMALE"
        End If
    End Function

    Private Sub displayLevel(level As String)
        If level = "MALE" Then
            MaleRadioButton.Checked = True
        Else
            FemaleRadioButton.Checked = True
        End If

    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToString("dd-MM-yyyy"))
        'MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)

    End Sub

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.subjectCodeBox.Items.Add("BM001")
        Me.subjectCodeBox.Items.Add("ENG001")
        Me.subjectCodeBox.Items.Add("MATH001")
        Me.subjectCodeBox.Items.Add("SCI001")
        Me.subjectCodeBox.Items.Add("PAI001")
        Me.subjectCodeBox.Items.Add("PM001")
        Me.subjectCodeBox.Items.Add("GEO002")
        Me.subjectCodeBox.Items.Add("PHY002")
        Me.subjectCodeBox.Items.Add("CHEM002")
        Me.subjectCodeBox.Items.Add("BIO002")
        Me.subjectCodeBox.Items.Add("ADDM002")
        Me.subjectCodeBox.Items.Add("SEJ002")
    End Sub
End Class