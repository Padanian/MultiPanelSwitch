<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiPanelSwitch
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.lblSwitchTag = New System.Windows.Forms.Label()
        Me.pbSwitch = New System.Windows.Forms.PictureBox()
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSwitchTag
        '
        Me.lblSwitchTag.Location = New System.Drawing.Point(3, 81)
        Me.lblSwitchTag.Name = "lblSwitchTag"
        Me.lblSwitchTag.Size = New System.Drawing.Size(58, 18)
        Me.lblSwitchTag.TabIndex = 0
        Me.lblSwitchTag.Text = "Label1"
        Me.lblSwitchTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSwitch
        '
        Me.pbSwitch.Image = Global.MultiPanelSwitch.My.Resources.Resources.PanelSwitchOff
        Me.pbSwitch.Location = New System.Drawing.Point(0, 0)
        Me.pbSwitch.Name = "pbSwitch"
        Me.pbSwitch.Size = New System.Drawing.Size(64, 64)
        Me.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSwitch.TabIndex = 1
        Me.pbSwitch.TabStop = False
        '
        'MultiPanelSwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSwitchTag)
        Me.Controls.Add(Me.pbSwitch)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MultiPanelSwitch"
        Me.Size = New System.Drawing.Size(64, 100)
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSwitchTag As Label
    Friend WithEvents pbSwitch As PictureBox
End Class
