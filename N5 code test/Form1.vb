Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        Dim cd As Integer
        Dim tv As Integer
        Dim xbox As Integer
        Dim dryer As Integer

        cd = InputBox("Enter the wattage of the cd player")
        tv = InputBox("Enter the wattage of the tv")
        xbox = InputBox("Enter the wattage of the xbox")
        dryer = InputBox("Enter the wattage of the hair dryer")

        total = cd + tv + xbox + dryer

        If total > 2000 Then
            MsgBox("!!! Warning you are over the limit")

        ElseIf total < 2000 Then
            MsgBox("You are under by " & 2000 - total)
        End If


    End Sub
End Class
