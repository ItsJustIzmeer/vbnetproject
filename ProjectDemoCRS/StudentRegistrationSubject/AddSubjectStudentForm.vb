Imports System.Data.OleDb
Public Class AddSubjectStudentForm
    Dim mySubjectRegister As New RegisterSubject
    Dim OldSubjectRegisterRec As RegisterSubjectRecord
    Private Sub displayExistingSubjectRegisterInfo(studentMatric As String)
        Try
            OldSubjectRegisterRec = mySubjectRegister.getAddSubjectRecord(studentMatric)
            With Me

                .matricTextBox.Text = OldSubjectRegisterRec.matric
                .subjectCodeTextBox.Text = OldSubjectRegisterRec.subjectCode
                .creditTextBox.Text = OldSubjectRegisterRec.credit

            End With
        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Friend Sub prepareToAddNewSubject()
        clearAddSubjectStudentForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub addThisSubject()
        Dim theNewRegisterSubjectRec As New RegisterSubjectRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewRegisterSubjectRec
            .matric = matricTextBox.Text
            .subjectCode = subjectCodeTextBox.Text
            .credit = creditTextBox.Text
        End With

        addOk = mySubjectRegister.addRegisterSubject(theNewRegisterSubjectRec)
        If addOk Then
            messageString = "New student with matric : " & theNewRegisterSubjectRec.matric & " has been succesfully added"
            MessageBox.Show(messageString, "Add New Student ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("WRONG DATA, PLEASE INSERT CORRECT INFORMATION",
            "Critical Warning",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign,
            True)
        End If
    End Sub
    Private Sub clearAddSubjectStudentForm()
        With Me
            .matricTextBox.Clear()
            .subjectCodeTextBox.Clear()
            .creditTextBox.Clear()
        End With
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisSubject() 'add new subject 
        Else 'update
            '  updateThisStudent(OldStudentRec)
        End If
    End Sub
    Private Sub matricTextBox_TextChanged(sender As Object, e As EventArgs) Handles matricTextBox.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
        Dim cmd As New OleDbCommand("Select matricNumber from student", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataSet
        da.Fill(dt)
        Dim column1 As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To dt.Tables(0).Rows.Count - 1
            column1.Add(dt.Tables(0).Rows(i)("matricNumber").ToString())
        Next
        matricTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        matricTextBox.AutoCompleteCustomSource = column1
        matricTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub subjectCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles subjectCodeTextBox.TextChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
        Dim cmd As New OleDbCommand("Select subjectCode from subject", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataSet
        da.Fill(dt)
        Dim column2 As New AutoCompleteStringCollection
        Dim x As Integer
        For x = 0 To dt.Tables(0).Rows.Count - 1
            column2.Add(dt.Tables(0).Rows(x)("subjectCode").ToString())
        Next
        subjectCodeTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        subjectCodeTextBox.AutoCompleteCustomSource = column2
        subjectCodeTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
End Class