Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list1, list2, list3, list4 As String
        list1 = ""
        list2 = ""
        list3 = ""
        list4 = ""
        For a = 1 To 5
            For b = a To a
                list1 = list1 & "* "
                ListBox1.Items.Add(list1)
            Next
        Next

        For a = 1 To 5
            If a Mod 2 = 1 Then
                For b = a To a
                    list2 = list2 & "* "
                    ListBox2.Items.Add(list2)
                Next
            End If
        Next
        For a = 5 To 1 Step -1
            list3 = ""
            For b = 1 To a
                list3 = list3 & "*"

            Next
            ListBox3.Items.Add(list3)
        Next
        For a = 5 To 1 Step -1
            If a Mod 2 = 0 Then
                list4 = ""
                For b = 1 To a
                    list4 = list4 & "* "

                Next
                ListBox4.Items.Add(list4)
            End If
        Next
    End Sub
End Class
