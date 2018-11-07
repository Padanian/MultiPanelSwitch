Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If i Mod 2 = 0 Then
            MultiPanelSwitch4.semaphorColor = Color.Red
            MultiPanelSwitch4.isSemaphorVisible = True
            MultiPanelSwitch4.isSemaphorBlinking = True
        Else
            MultiPanelSwitch4.semaphorColor = Color.Black
            MultiPanelSwitch4.isSemaphorVisible = True
            MultiPanelSwitch4.isSemaphorBlinking = False
        End If
        i += 1


    End Sub

    Private Sub MultiPanelSwitch5_(sender As Object, e As EventArgs) Handles MultiPanelSwitch5.Click
        If MultiPanelSwitch5.selectedPosition = 0 Then
            MultiGenPoint3TemperatureWeeklyStrip1.isOff = True
        Else
            MultiGenPoint3TemperatureWeeklyStrip1.isOff = False
        End If
    End Sub
    Private Sub MultiPanelSwitch6_(sender As Object, e As EventArgs) Handles MultiPanelSwitch6.Click
        If MultiPanelSwitch6.selectedPosition = 0 Then
            MultiGenPoint3TemperatureWeeklyStrip2.isOff = True
        Else
            MultiGenPoint3TemperatureWeeklyStrip2.isOff = False
        End If
    End Sub

End Class
