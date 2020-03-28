Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MultiPanelSwitch4.semaphorColor = Color.Red Then
            MultiPanelSwitch4.semaphorColor = Color.Black
        Else
            MultiPanelSwitch4.semaphorColor = Color.Red
        End If

        MultiPanelSwitch4.isSemaphorBlinking = Not MultiPanelSwitch4.isSemaphorBlinking


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
