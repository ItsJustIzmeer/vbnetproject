Public Class StudentForm
    Dim myStudent As New Student
    Dim myStudentGroupClass As New StudentGroupClass
    ' Dim theStudentGroupRecord As StudentGroupRecord
    Dim OldStudentRec As StudentRecord

    Friend Sub prepareToUpdateStudent(studentMatric As String)
        'MessageBox.Show("to update student with matric" & studentMatric)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingStudentInfo(studentMatric)
    End Sub

    Private Sub displayExistingStudentInfo(studentMatric As String)
        Try
            OldStudentRec = myStudent.getStudentRecord(studentMatric)
            With Me
                .icNumberTextBox.Text = OldStudentRec.ic
                .matricTextBox.Text = OldStudentRec.matric
                .nameTextBox.Text = OldStudentRec.name
                displayLevel(OldStudentRec.gender)
                .PhoneNumberTextBox.Text = OldStudentRec.phone
                .classComboBox.Text = OldStudentRec.classGroup
                .dobDateTimePicker1.Value = OldStudentRec.dob.Date
                .Address1TextBox.Text = OldStudentRec.address
                .CityTextBox.Text = OldStudentRec.city
                .PoscodeTextBox.Text = OldStudentRec.poscode
                .EmailTextBox.Text = OldStudentRec.email
                .SchoolLevelTextBox.Text = OldStudentRec.schoolLevel

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewStudent()
        clearStudentForm()
        displayClassList()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub

    Private Sub displayClassList()
        Dim classListArray() As String
        Dim studentClassList As String
        studentClassList = myStudentGroupClass.getStudentClassList()
        classListArray = studentClassList.Split(ControlChars.NewLine)
        classComboBox.Items.Clear()
        'MessageBox.Show(studentClassList)
        For Each i As String In classListArray
            Me.classComboBox.Items.Add(i)
        Next
        If classComboBox.Items.Count <> 0 Then
            classComboBox.SelectedIndex = 0
        End If

    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisStudent() 'add new student 
        Else 'update
            updateThisStudent(OldStudentRec)
        End If
    End Sub
    Private Sub addThisStudent()
        Dim theNewStudentRec As New StudentRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewStudentRec
            .ic = icNumberTextBox.Text
            .matric = matricTextBox.Text
            .name = nameTextBox.Text
            .gender = getLevelFromRadioButton()
            .phone = PhoneNumberTextBox.Text
            .classGroup = classComboBox.Text
            .dob = dobDateTimePicker1.Value
            .address = Address1TextBox.Text
            .city = CityTextBox.Text
            .poscode = PoscodeTextBox.Text
            .email = EmailTextBox.Text
            .schoolLevel = SchoolLevelTextBox.Text
        End With

        addOk = myStudent.addStudent(theNewStudentRec)
        If addOk Then
            messageString = "New student with matric : " & theNewStudentRec.matric & " has been added"
            MessageBox.Show(messageString, "Add New Student ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearStudentForm()
        With Me
            .matricTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()
            .dobDateTimePicker1.Value = DateTime.Today
            .classComboBox.Text = ""
            .PhoneNumberTextBox.Clear()
            .Address1TextBox.Clear()
            .CityTextBox.Clear()
            .PoscodeTextBox.Clear()
            .EmailTextBox.Clear()
            .SchoolLevelTextBox.Clear()
            .FemaleRadioButton.Checked = False
            .MaleRadioButton.Checked = False
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub updateThisStudent(oldStudentRec As StudentRecord)
        Dim theNewStudentRec As New StudentRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewStudentRec.matric = matricTextBox.Text
        theNewStudentRec.ic = icNumberTextBox.Text
        theNewStudentRec.name = nameTextBox.Text
        theNewStudentRec.gender = getLevelFromRadioButton()
        theNewStudentRec.dob = dobDateTimePicker1.Value
        theNewStudentRec.phone = PhoneNumberTextBox.Text
        theNewStudentRec.classGroup = classComboBox.Text
        theNewStudentRec.address = Address1TextBox.Text
        theNewStudentRec.city = CityTextBox.Text
        theNewStudentRec.poscode = PoscodeTextBox.Text
        theNewStudentRec.email = EmailTextBox.Text
        theNewStudentRec.schoolLevel = SchoolLevelTextBox.Text
        updateOk = myStudent.updateThisStudent(oldStudentRec, theNewStudentRec)
        If updateOk Then
            messageString = "Student with matric : " & theNewStudentRec.matric & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToString("dd-MM-yyyy"))
        'MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)

    End Sub
    Private Function getLevelFromRadioButton() As String
        If MaleRadioButton.Checked Then
            Return "MALE"
        Else
            Return "FEMALE"
        End If
    End Function
    Private Sub displayLevel(level As String)
        If level = "MALE" Or level = "Male" Then
            MaleRadioButton.Checked = True
        Else
            FemaleRadioButton.Checked = True
        End If

    End Sub
End Class