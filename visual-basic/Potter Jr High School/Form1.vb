Option Strict On
Option Explicit On
Option Infer Off
Public Class Form1

    'Declare array to store text
    Dim strNamesAndGrades(14, 1) As String
    'Declare student counter variable
    Dim intStudent As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrades.SelectedIndex = 0

        'declare stream reader
        Dim inFile As IO.StreamReader

        'Declare an open file dialog
        Dim dlgFile As OpenFileDialog = New OpenFileDialog

        'Determine whether the file exists.
        If IO.File.Exists("NamesAndGrades.txt") Then
            'Open the file for input.
            inFile = IO.File.OpenText("NamesAndGrades.txt")
            'Read the file and store in lstStudents
            Do Until inFile.Peek = -1
                strNamesAndGrades(intStudent, 0) = inFile.ReadLine
                strNamesAndGrades(intStudent, 1) = inFile.ReadLine
                intStudent += 1
            Loop

            'inFile.Close()
        Else
            MessageBox.Show("Gradebook not available for processing. Press OK to selet a new gradebook file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If dlgFile.ShowDialog() = DialogResult.OK Then
                inFile = IO.File.OpenText(dlgFile.FileName)
                Do Until inFile.Peek = -1
                    strNamesAndGrades(intStudent, 0) = inFile.ReadLine
                    strNamesAndGrades(intStudent, 1) = inFile.ReadLine
                    intStudent += 1
                Loop
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstNames.Items.Clear()
        'Declare a local counter variable to store the 
        'number of students with the selected grade.
        Dim intStudentCount As Integer = 0
        For intIndex As Integer = 0 To intStudent - 1
            'If the student's grade = the selected grade
            'then the student's name is added to the listbox
            'and student count goes up by 1
            If strNamesAndGrades(intIndex, 1) = lstGrades.SelectedItem.ToString Then
                lstNames.Items.Add(strNamesAndGrades(intIndex, 0))
                intStudentCount += 1
            End If
        Next
        'Update text box to reflect student count.
        txtNumber.Text = intStudentCount.ToString

        'Other option: txtNumber.Text = lstStudents.Items.Count.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
