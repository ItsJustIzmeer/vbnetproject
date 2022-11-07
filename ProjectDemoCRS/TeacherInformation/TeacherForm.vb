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
            .name = nameTextBox.Text
            .dob = dobDateTimePicker1.Value
            .phone = PhoneNumberTextBox.Text
        End With

        addOk = myTeacher.addTeacher(theNewTeacherRec)
        If addOk Then
            messageString = "New student with matric : " & theNewTeacherRec.id & " has been added"
            MessageBox.Show(messageString, "Add New Student ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub clearTeacherForm()
        With Me
            .idTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()

            '.classComboBox.Text = ""
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
        theNewTeacherRec.dob = dobDateTimePicker1.Value
        theNewTeacherRec.phone = PhoneNumberTextBox.Text
        updateOk = myTeacher.updateThisTeacher(oldTeacherRec, theNewTeacherRec)
        If updateOk Then
            messageString = "Teacher with id : " & theNewTeacherRec.id & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToString("dd-MM-yyyy"))
        'MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)

    End Sub

End Class