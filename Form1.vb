Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        ' This PLace We Are Creating The Variables And Setting The DataType
        Dim StrFirstName As String
        Dim IntAge As Integer
        Dim StrOccupation As String
        Dim StrGender As String


        ' This Assigns The Variables Created To The Specified InputName 
        StrFirstName = TxtFirstName.Text
        IntAge = TxtIntAge.Text
        StrOccupation = TxtOccupation.Text
        StrGender = LstGender.SelectedItem

        ' This Checks The Age Inputted By The User
        If IntAge < 18 Then
            MsgBox("You Are Not Of Age")

        Else
            MsgBox("Thank You For Submiting , " & " Your Name is  " & StrFirstName & " " & " Your Age Is " & " " & IntAge & " " & " Your occupation is " & " " & StrOccupation & " " & "Your Gender is  " & StrGender)
            Console.WriteLine("Submission ")
        End If

    End Sub

    ' This Controls The Exit Button On The APPLICAYION
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class
