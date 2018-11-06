<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MultiPanelSwitch1 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch2 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch3 = New MultiPanelSwitch.MultiPanelSwitch()
        Me.MultiPanelSwitch4 = New MultiPanelSwitch.MultiPanelSwitch()
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
        Me.MultiPanelSwitch2.semaphorColor = System.Drawing.Color.Yellow
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
        Me.MultiPanelSwitch4.semaphorColor = System.Drawing.Color.Red
        Me.MultiPanelSwitch4.semaphortext = "Text"
        Me.MultiPanelSwitch4.Size = New System.Drawing.Size(64, 200)
        Me.MultiPanelSwitch4.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
