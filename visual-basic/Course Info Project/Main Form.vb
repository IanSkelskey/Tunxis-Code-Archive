' Name:         Course Info Project
' Purpose:      Keep track of a student's college courses.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub CoursesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CoursesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CoursesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCoursesDataSet)
            MessageBox.Show("Changes saved.", "Course Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Course Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyCoursesDataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.MyCoursesDataSet.Courses)

    End Sub
End Class
