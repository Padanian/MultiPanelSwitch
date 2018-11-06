Public Class UserControl1
    Const Pi As Double = Math.PI
    Dim x1, y1, x2, y2, x3, y3 As Integer
    Dim xp1, yp1, xp2, yp2 As Int32
    Private m_lbltext As String
    Private m_selectedPosition As Integer
    Private m_positions As Integer = 3
    Private m_WarningThreshold As Integer = 80
    Private m_isLedVisible As Boolean = True
    Private WarningActive As Boolean = False
    Dim centreX As Double = 32
    Dim centreY As Double = 44
    Dim apen As New Pen(Color.LightGray, 1)
    Dim lpen As New Pen(Color.Black, 2)
    Dim tpen As New Pen(Color.Transparent, 2)
    Dim angle As Double = -3 / 4 * Pi
    Private Sub Me_click(sender As Object, e As EventArgs) Handles Me.Click
        m_selectedPosition += 1
        If m_selectedPosition > m_positions - 1 Then
            m_selectedPosition = 0
            angle = -3 / 4 * Pi
            Me.Refresh()
            Exit Sub
        End If
        If m_positions = 2 Then
            angle += Pi / 2
        Else
            angle += Pi / 4
        End If
        Me.Refresh()
    End Sub

    Public Property positions As Integer
        Get
            positions = m_positions
        End Get
        Set(positions As Integer)
            If positions = 2 Then
                m_positions = 2
                DirectCast(Me.Controls.Find("tag1", True)(0), Label).Dispose()
                DirectCast(Me.Controls.Find("tag2", True)(0), Label).Dispose()
            ElseIf positions = 3 Then
                m_positions = 3
                DirectCast(Me.Controls.Find("tag1", True)(0), Label).Dispose()
            Else
                positions = m_positions
                Exit Property
            End If

            Me.Refresh()
        End Set
    End Property
    Public Property lbltext As String
        Get
            lbltext = m_lbltext
        End Get
        Set(lbltext As String)
            If lbltext.Length < 10 Then
                m_lbltext = lbltext
                lblSwitchTag.Text = lbltext
            End If
            Me.Refresh()
        End Set
    End Property
    Public Property selectedPosition As Integer
        Get
            selectedPosition = m_selectedPosition
        End Get
        Set(selectedPosition As Integer)
            If selectedPosition > m_positions Then
                selectedPosition = 0
                angle = -3 / 4 * Pi
                m_selectedPosition = selectedPosition
            End If
        End Set
    End Property
    Private Sub GaugePaint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        e.Graphics.DrawEllipse(apen, 1, 13, 62, 62)
        e.Graphics.DrawEllipse(lpen, 4, 16, 56, 56)

        Dim m_step As Double
        If m_positions = 2 Then
            m_step = Pi / 2
        Else
            m_step = Pi / 4
        End If

        Dim i As Integer
        For num As Double = -3 / 4 * Pi To -1 / 4 * Pi Step m_step
            x1 = Convert.ToInt32(30 * Math.Cos(num) + centreX)
            y1 = Convert.ToInt32(30 * Math.Sin(num) + centreY)
            x2 = Convert.ToInt32(36 * Math.Cos(num) + centreX)
            y2 = Convert.ToInt32(36 * Math.Sin(num) + centreY)
            x3 = Convert.ToInt32(42 * Math.Cos(num) + centreX)
            y3 = Convert.ToInt32(42 * Math.Sin(num) + centreY)

            e.Graphics.DrawLine(lpen, x1, y1, x2, y2)

            Dim tag As New Label
            With tag
                .Size = New Size(8, 8)
                .Font = New Font("SegoeUI", 5, FontStyle.Regular)
                .Text = i.ToString
                .Name = "tag" & i.ToString
            End With
            If i = 0 Then
                tag.Location = New Point(x3, y3 - 4)
            ElseIf i = 1 And m_positions = 2 Then
                tag.Location = New Point(x3 - 4, y3 - 4)
            ElseIf i = 2 And m_positions = 3 Then
                tag.Location = New Point(x3 - 4, y3 - 4)
            ElseIf i = 1 And m_positions = 3 Then
                tag.Location = New Point(x3 - 4, y3 - 1)
            End If

            Me.Controls.Add(tag)
            i += 1
        Next

        e.Graphics.DrawRectangle(apen, 1, 78, 62, 21)

        drawswitch(e, angle)



    End Sub
    Public Sub drawswitch(e, angle)
        'prima linea
        Dim num As Double = angle - 0.075
        x1 = Convert.ToInt32(22 * Math.Cos(num) + centreX)
        y1 = Convert.ToInt32(22 * Math.Sin(num) + centreY)

        num = angle + 0.075
        x2 = Convert.ToInt32(22 * Math.Cos(num) + centreX)
        y2 = Convert.ToInt32(22 * Math.Sin(num) + centreY)

        Dim startNotchX As Int32 = (x1 + x2) / 2
        Dim startNotchY As Int32 = (y1 + y2) / 2

        num = angle
        Dim endNotchX = Convert.ToInt32(12 * Math.Cos(num) + centreX)
        Dim endNotchY = Convert.ToInt32(12 * Math.Sin(num) + centreY)


        e.Graphics.DrawLine(lpen, x1, y1, x2, y2)
        e.Graphics.DrawLine(lpen, startNotchX, startNotchY, endNotchX, endNotchY)

        'seconda linea
        x1 = x2
        y1 = y2

        num = angle + Pi - 0.075
        x2 = Convert.ToInt32(22 * Math.Cos(num) + centreX)
        y2 = Convert.ToInt32(22 * Math.Sin(num) + centreY)

        e.Graphics.DrawLine(lpen, x1, y1, x2, y2)

        'terza linea
        x1 = x2
        y1 = y2

        num = angle + Pi + 0.075
        x2 = Convert.ToInt32(22 * Math.Cos(num) + centreX)
        y2 = Convert.ToInt32(22 * Math.Sin(num) + centreY)

        e.Graphics.DrawLine(lpen, x1, y1, x2, y2)

        'quarta linea
        x1 = x2
        y1 = y2

        num = angle - 0.075

        x2 = Convert.ToInt32(22 * Math.Cos(num) + centreX)
        y2 = Convert.ToInt32(22 * Math.Sin(num) + centreY)

        e.Graphics.DrawLine(lpen, x1, y1, x2, y2)

    End Sub
End Class
