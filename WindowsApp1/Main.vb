Public Class Main


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SplitContainer1.SplitterDistance > 60 Then
            SplitContainer1.SplitterDistance -= 5 ' Adjust the value as needed
            SplitContainer1.Invalidate()
            SplitContainer1.Update()
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SplitContainer1.SplitterDistance < 270 Then
            SplitContainer1.SplitterDistance += 5 ' Adjust the value as needed
            SplitContainer1.Invalidate()
            SplitContainer1.Update()
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If SplitContainer1.SplitterDistance > 60 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Timer1.Interval = 10 ' milliseconds
        Timer2.Interval = 10 ' milliseconds
    End Sub
End Class