Public Class MultiPanelSwitch
    Const Pi As Double = Math.PI
    Dim x1, y1, x2, y2, x3, y3 As Integer
    Dim xp1, yp1, xp2, yp2 As Int32
    Private m_lbltext As String = "Text"
    Private m_semaphortext As String = "Text"
    Private m_selectedPosition As Integer = 0
    Private m_positions As Integer = 3
    Private m_WarningThreshold As Integer = 80
    Private m_semaphorColor As Color = Color.Yellow
    Private m_isSemaphorVisible As Boolean
    Private m_isSemaphorBlinking As Boolean
    Dim centreX As Double = 32
    Dim centreY As Double = 44
    Dim apen As New Pen(Color.LightGray, 1)
    Dim lpen As New Pen(Color.Black, 2)
    Dim angle As Double = -3 / 4 * Pi
    Dim blinkingSemaphorTimer As New Timer
    Dim pbSemaphor As New PictureBox
    Dim lblSemaphorText As New Label



    Private Sub Me_click(sender As Object, e As EventArgs) Handles pbSwitch.Click
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
    Public Property isSemaphorVisible As Boolean
        Get
            isSemaphorVisible = m_isSemaphorVisible
        End Get
        Set(isSemaphorVisible As Boolean)
            m_isSemaphorVisible = isSemaphorVisible
            If isSemaphorVisible Then
                Me.Height = 200
                pbSemaphor.Visible = True
            Else
                Me.Height = 100
                pbSemaphor.Visible = False
            End If


        End Set
    End Property
    Public Property isSemaphorBlinking As Boolean
        Get
            isSemaphorBlinking = m_isSemaphorBlinking
        End Get
        Set(isSemaphorBlinking As Boolean)
            m_isSemaphorBlinking = isSemaphorBlinking
            Me.Refresh()
        End Set
    End Property
    Public Property semaphorColor As Color
        Get
            semaphorColor = m_semaphorColor
        End Get
        Set(semaphorColor As Color)
            Select Case semaphorColor
                Case Color.Yellow
                    pbSemaphor.Image = My.Resources.led_amber_black
                Case Color.Blue
                    pbSemaphor.Image = My.Resources.led_blue_black
                Case Color.Green
                    pbSemaphor.Image = My.Resources.led_green_black
                Case Color.Red
                    pbSemaphor.Image = My.Resources.led_red_black
                Case Color.Black
                    pbSemaphor.Image = My.Resources.led_off_black
                Case Else
                    pbSemaphor.Image = My.Resources.led_off_black
                    semaphorColor = Color.Yellow
                    m_semaphorColor = Color.Yellow
                    Exit Property
            End Select
            m_semaphorColor = semaphorColor

        End Set
    End Property
    Public Property positions As Integer
        Get
            positions = m_positions
        End Get
        Set(positions As Integer)
            If positions = 2 Then
                m_positions = 2
                Dim ca As Control() = Me.Controls.Find("tag1", True)
                If ca.Length > 0 Then DirectCast(ca(0), Label).Dispose()
                Me.Invalidate()
                ca = Me.Controls.Find("tag2", True)
                If ca.Length > 0 Then DirectCast(ca(0), Label).Dispose()
                Me.Invalidate()
            ElseIf positions = 3 Then
                m_positions = 3
                Dim ca As Control() = Me.Controls.Find("tag1", True)
                If ca.Length > 0 Then DirectCast(ca(0), Label).Dispose()
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
    Public Property semaphortext As String
        Get
            semaphortext = m_semaphortext
        End Get
        Set(semaphortext As String)
            If semaphortext.Length < 10 Then
                m_semaphortext = semaphortext
                lblSemaphorText.Text = semaphortext
            End If
            Me.Refresh()
        End Set
    End Property
    Public ReadOnly Property selectedPosition As Integer
        Get
            selectedPosition = m_selectedPosition
        End Get
    End Property
    Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        'AddHandler pbSwitch.Click, AddressOf Me_click

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        AddHandler blinkingSemaphorTimer.Tick, AddressOf blinkingSemaphor
        With pbSemaphor
            .Location = New Point(6, 142)
            .Size = New Size(52, 52)
            .Name = "pbSemaphor"
            .Visible = False
            .Image = My.Resources.led_amber_black
            .SizeMode = PictureBoxSizeMode.Zoom
        End With
        Me.Controls.Add(pbSemaphor)

        With lblSemaphorText
            .Size = New Size(58, 18)
            .Font = New Font("SegoeUI", 8.25, FontStyle.Regular)
            .Name = "lblSemaphorText"
            .Location = New Point(3, 118)
            .Text = m_semaphortext
            .Visible = False
            .TextAlign = ContentAlignment.MiddleCenter
        End With
        Me.Controls.Add(lblSemaphorText)

    End Sub
    Private Sub GaugePaint(sender As Object, e As PaintEventArgs) Handles Me.Paint


        drawswitch(e, angle)

        Dim m_step As Double
        If m_positions = 2 Then
            m_step = Pi / 2
        Else
            m_step = Pi / 4
        End If


        e.Graphics.DrawRectangle(apen, 1, 78, 62, 21)

        lblSwitchTag.Text = lbltext


        If isSemaphorVisible And Not isSemaphorBlinking Then
            With blinkingSemaphorTimer
                .Enabled = False
                .Stop()
            End With
            pbSemaphor.Visible = True
            e.Graphics.DrawRectangle(apen, 1, 115, 62, 21)
            lblSemaphorText.Visible = True
            Select Case m_semaphorColor
                Case Color.Yellow
                    pbSemaphor.Image = My.Resources.led_amber_black
                Case Color.Blue
                    pbSemaphor.Image = My.Resources.led_blue_black
                Case Color.Green
                    pbSemaphor.Image = My.Resources.led_green_black
                Case Color.Red
                    pbSemaphor.Image = My.Resources.led_red_black
            End Select

        ElseIf isSemaphorVisible And isSemaphorBlinking Then
            If blinkingSemaphorTimer.Enabled = False Then
                With blinkingSemaphorTimer
                    .Interval = 1000
                    .Enabled = True
                    .Start()
                End With
            End If
            e.Graphics.DrawRectangle(apen, 1, 115, 62, 21)
            lblSemaphorText.Visible = True
        ElseIf Not isSemaphorVisible Then
            With blinkingSemaphorTimer
                .Enabled = False
                .Stop()
            End With
            pbSemaphor.Visible = False
            lblSemaphorText.Visible = False
        End If

    End Sub
    Private Sub blinkingSemaphor()

        pbSemaphor.Visible = True
        If m_semaphorColor <> Color.Black Then
            If DateTime.Now.Second Mod 2 = 0 Then
                Select Case m_semaphorColor
                    Case Color.Yellow
                        pbSemaphor.Image = My.Resources.led_amber_black
                    Case Color.Blue
                        pbSemaphor.Image = My.Resources.led_blue_black
                    Case Color.Green
                        pbSemaphor.Image = My.Resources.led_green_black
                    Case Color.Red
                        pbSemaphor.Image = My.Resources.led_red_black
                End Select
            Else
                pbSemaphor.Image = My.Resources.led_off_black
            End If
        End If

    End Sub

    Public Sub drawswitch(e, angle)

        If angle = -3 / 4 * Pi And m_positions = 3 Then
            pbSwitch.Image = My.Resources.PanelSwitchOff
        ElseIf angle = -3 / 4 * Pi And m_positions = 2 Then
            pbSwitch.Image = My.Resources.PanelSwitchOff_2pos
        ElseIf angle = -1 / 2 * Pi Then
            pbSwitch.Image = My.Resources.PanelSwitchAuto
        ElseIf angle = -1 / 4 * Pi And m_positions = 3 Then
            pbSwitch.Image = My.Resources.PanelSwitchOn
        ElseIf angle = -1 / 4 * Pi And m_positions = 2 Then
            pbSwitch.Image = My.Resources.PanelSwitchOn_2pos
        End If

    End Sub
End Class
