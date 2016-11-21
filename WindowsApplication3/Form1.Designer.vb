<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trackBarBrightness = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBLCRefresh = New System.Windows.Forms.Button()
        Me.btnDisableBLC = New System.Windows.Forms.Button()
        Me.trackBarContrast = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trackBarGamma = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarGamma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(31, 25)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(608, 358)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(525, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How to use:"
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(28, 98)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(58, 13)
        Me.statusLabel.TabIndex = 4
        Me.statusLabel.Text = "Status : Nil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Brightness"
        '
        'trackBarBrightness
        '
        Me.trackBarBrightness.Location = New System.Drawing.Point(175, 25)
        Me.trackBarBrightness.Minimum = 1
        Me.trackBarBrightness.Name = "trackBarBrightness"
        Me.trackBarBrightness.Size = New System.Drawing.Size(159, 45)
        Me.trackBarBrightness.TabIndex = 6
        Me.trackBarBrightness.Value = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(528, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 104)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Press Go and select the Video window and cover the lens for 3 seconds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press """ &
    "BLC Refresh"" to update BLC Mask" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press ""Disable BLC"" to remove BLC Mask"
        '
        'btnBLCRefresh
        '
        Me.btnBLCRefresh.Location = New System.Drawing.Point(402, 25)
        Me.btnBLCRefresh.Name = "btnBLCRefresh"
        Me.btnBLCRefresh.Size = New System.Drawing.Size(97, 23)
        Me.btnBLCRefresh.TabIndex = 8
        Me.btnBLCRefresh.Text = "BLC Refresh"
        Me.btnBLCRefresh.UseVisualStyleBackColor = True
        '
        'btnDisableBLC
        '
        Me.btnDisableBLC.Location = New System.Drawing.Point(404, 67)
        Me.btnDisableBLC.Name = "btnDisableBLC"
        Me.btnDisableBLC.Size = New System.Drawing.Size(95, 23)
        Me.btnDisableBLC.TabIndex = 9
        Me.btnDisableBLC.Text = "Disable BLC"
        Me.btnDisableBLC.UseVisualStyleBackColor = True
        '
        'trackBarContrast
        '
        Me.trackBarContrast.Location = New System.Drawing.Point(175, 80)
        Me.trackBarContrast.Maximum = 200
        Me.trackBarContrast.Minimum = 1
        Me.trackBarContrast.Name = "trackBarContrast"
        Me.trackBarContrast.Size = New System.Drawing.Size(159, 45)
        Me.trackBarContrast.TabIndex = 10
        Me.trackBarContrast.Value = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Contrast"
        '
        'trackBarGamma
        '
        Me.trackBarGamma.Location = New System.Drawing.Point(175, 144)
        Me.trackBarGamma.Maximum = 255
        Me.trackBarGamma.Minimum = 1
        Me.trackBarGamma.Name = "trackBarGamma"
        Me.trackBarGamma.Size = New System.Drawing.Size(159, 45)
        Me.trackBarGamma.TabIndex = 12
        Me.trackBarGamma.Value = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Gamma"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 509)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trackBarGamma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trackBarContrast)
        Me.Controls.Add(Me.btnDisableBLC)
        Me.Controls.Add(Me.btnBLCRefresh)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.trackBarBrightness)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "BLCViewerRefresh"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarGamma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents trackBarBrightness As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBLCRefresh As Button
    Friend WithEvents btnDisableBLC As Button
    Friend WithEvents trackBarContrast As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents trackBarGamma As TrackBar
    Friend WithEvents Label4 As Label
End Class
