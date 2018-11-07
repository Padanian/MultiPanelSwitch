<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MultiPanelSwitch1 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch2 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch3 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch4 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MultiPanelSwitch5 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch6 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiGenPoint3TemperatureWeeklyStrip1 = New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip()
        Me.MultiGenPoint3TemperatureWeeklyStrip2 = New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip()
        Me.SuspendLayout()
        '
        'MultiPanelSwitch1
        '
        Me.MultiPanelSwitch1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch1.isSemaphorBlinking = False
        Me.MultiPanelSwitch1.isSemaphorVisible = True
        Me.MultiPanelSwitch1.lbltext = "Pump 1"
        Me.MultiPanelSwitch1.Location = New System.Drawing.Point(75, 44)
        Me.MultiPanelSwitch1.Name = "MultiPanelSwitch1"
        Me.MultiPanelSwitch1.positions = 3
        Me.MultiPanelSwitch1.semaphorColor = System.Drawing.Color.Black
        Me.MultiPanelSwitch1.semaphortext = "Status"
        Me.MultiPanelSwitch1.Size = New System.Drawing.Size(64, 200)
        Me.MultiPanelSwitch1.TabIndex = 0
        '
        'MultiPanelSwitch2
        '
        Me.MultiPanelSwitch2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch2.isSemaphorBlinking = False
        Me.MultiPanelSwitch2.isSemaphorVisible = True
        Me.MultiPanelSwitch2.lbltext = "Pump 2"
        Me.MultiPanelSwitch2.Location = New System.Drawing.Point(145, 44)
        Me.MultiPanelSwitch2.Name = "MultiPanelSwitch2"
        Me.MultiPanelSwitch2.positions = 3
        Me.MultiPanelSwitch2.semaphorColor = System.Drawing.Color.Black
        Me.MultiPanelSwitch2.semaphortext = "Text"
        Me.MultiPanelSwitch2.Size = New System.Drawing.Size(64, 200)
        Me.MultiPanelSwitch2.TabIndex = 0
        '
        'MultiPanelSwitch3
        '
        Me.MultiPanelSwitch3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch3.isSemaphorBlinking = False
        Me.MultiPanelSwitch3.isSemaphorVisible = False
        Me.MultiPanelSwitch3.lbltext = "Chiller 1"
        Me.MultiPanelSwitch3.Location = New System.Drawing.Point(215, 44)
        Me.MultiPanelSwitch3.Name = "MultiPanelSwitch3"
        Me.MultiPanelSwitch3.positions = 3
        Me.MultiPanelSwitch3.semaphorColor = System.Drawing.Color.Yellow
        Me.MultiPanelSwitch3.semaphortext = "Text"
        Me.MultiPanelSwitch3.Size = New System.Drawing.Size(64, 100)
        Me.MultiPanelSwitch3.TabIndex = 0
        '
        'MultiPanelSwitch4
        '
        Me.MultiPanelSwitch4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch4.isSemaphorBlinking = False
        Me.MultiPanelSwitch4.isSemaphorVisible = True
        Me.MultiPanelSwitch4.lbltext = "Heater"
        Me.MultiPanelSwitch4.Location = New System.Drawing.Point(285, 44)
        Me.MultiPanelSwitch4.Name = "MultiPanelSwitch4"
        Me.MultiPanelSwitch4.positions = 2
        Me.MultiPanelSwitch4.semaphorColor = System.Drawing.Color.Black
        Me.MultiPanelSwitch4.semaphortext = "Text"
        Me.MultiPanelSwitch4.Size = New System.Drawing.Size(64, 200)
        Me.MultiPanelSwitch4.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(474, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MultiPanelSwitch5
        '
        Me.MultiPanelSwitch5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch5.isSemaphorBlinking = False
        Me.MultiPanelSwitch5.isSemaphorVisible = False
        Me.MultiPanelSwitch5.lbltext = "Chrono 1"
        Me.MultiPanelSwitch5.Location = New System.Drawing.Point(387, 44)
        Me.MultiPanelSwitch5.Name = "MultiPanelSwitch5"
        Me.MultiPanelSwitch5.positions = 3
        Me.MultiPanelSwitch5.semaphorColor = System.Drawing.Color.Yellow
        Me.MultiPanelSwitch5.semaphortext = "Text"
        Me.MultiPanelSwitch5.Size = New System.Drawing.Size(64, 100)
        Me.MultiPanelSwitch5.TabIndex = 2
        '
        'MultiPanelSwitch6
        '
        Me.MultiPanelSwitch6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiPanelSwitch6.isSemaphorBlinking = False
        Me.MultiPanelSwitch6.isSemaphorVisible = False
        Me.MultiPanelSwitch6.lbltext = "Text"
        Me.MultiPanelSwitch6.Location = New System.Drawing.Point(457, 44)
        Me.MultiPanelSwitch6.Name = "MultiPanelSwitch6"
        Me.MultiPanelSwitch6.positions = 3
        Me.MultiPanelSwitch6.semaphorColor = System.Drawing.Color.Yellow
        Me.MultiPanelSwitch6.semaphortext = "Text"
        Me.MultiPanelSwitch6.Size = New System.Drawing.Size(64, 100)
        Me.MultiPanelSwitch6.TabIndex = 3
        '
        'MultiGenPoint3TemperatureWeeklyStrip1
        '
        Me.MultiGenPoint3TemperatureWeeklyStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiGenPoint3TemperatureWeeklyStrip1.isCooling = False
        Me.MultiGenPoint3TemperatureWeeklyStrip1.isEco = False
        Me.MultiGenPoint3TemperatureWeeklyStrip1.isHeating = True
        Me.MultiGenPoint3TemperatureWeeklyStrip1.isManual = False
        Me.MultiGenPoint3TemperatureWeeklyStrip1.isOff = True
        Me.MultiGenPoint3TemperatureWeeklyStrip1.Location = New System.Drawing.Point(595, 44)
        Me.MultiGenPoint3TemperatureWeeklyStrip1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MultiGenPoint3TemperatureWeeklyStrip1.Name = "MultiGenPoint3TemperatureWeeklyStrip1"
        Me.MultiGenPoint3TemperatureWeeklyStrip1.Size = New System.Drawing.Size(294, 130)
        Me.MultiGenPoint3TemperatureWeeklyStrip1.TabIndex = 4
        Me.MultiGenPoint3TemperatureWeeklyStrip1.temperature = 23.4R
        '
        'MultiGenPoint3TemperatureWeeklyStrip2
        '
        Me.MultiGenPoint3TemperatureWeeklyStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiGenPoint3TemperatureWeeklyStrip2.isCooling = False
        Me.MultiGenPoint3TemperatureWeeklyStrip2.isEco = False
        Me.MultiGenPoint3TemperatureWeeklyStrip2.isHeating = True
        Me.MultiGenPoint3TemperatureWeeklyStrip2.isManual = False
        Me.MultiGenPoint3TemperatureWeeklyStrip2.isOff = True
        Me.MultiGenPoint3TemperatureWeeklyStrip2.Location = New System.Drawing.Point(595, 178)
        Me.MultiGenPoint3TemperatureWeeklyStrip2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MultiGenPoint3TemperatureWeeklyStrip2.Name = "MultiGenPoint3TemperatureWeeklyStrip2"
        Me.MultiGenPoint3TemperatureWeeklyStrip2.Size = New System.Drawing.Size(294, 130)
        Me.MultiGenPoint3TemperatureWeeklyStrip2.TabIndex = 4
        Me.MultiGenPoint3TemperatureWeeklyStrip2.temperature = 23.4R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 517)
        Me.Controls.Add(Me.MultiGenPoint3TemperatureWeeklyStrip2)
        Me.Controls.Add(Me.MultiGenPoint3TemperatureWeeklyStrip1)
        Me.Controls.Add(Me.MultiPanelSwitch6)
        Me.Controls.Add(Me.MultiPanelSwitch5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MultiPanelSwitch4)
        Me.Controls.Add(Me.MultiPanelSwitch3)
        Me.Controls.Add(Me.MultiPanelSwitch2)
        Me.Controls.Add(Me.MultiPanelSwitch1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MultiPanelSwitch1 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents MultiPanelSwitch2 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents MultiPanelSwitch3 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents MultiPanelSwitch4 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents Button1 As Button
    Friend WithEvents MultiPanelSwitch5 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents MultiPanelSwitch6 As MultiPanelSwitch.MultiPanelSwitch
    Friend WithEvents MultiGenPoint3TemperatureWeeklyStrip1 As MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip
    Friend WithEvents MultiGenPoint3TemperatureWeeklyStrip2 As MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip
End Class
