Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

Public Class Form1
    Dim bmpBLCMask As Bitmap
    Dim windowID As Integer
    Dim finalPicture As Bitmap




    ''  All the stuff related to Window capture below

    Private WithEvents Tmr As New Timer With {.Interval = 1}

    <DllImport("user32.dll", EntryPoint:="GetWindowRect")>
    Private Shared Function GetWindowRect(ByVal hWnd As System.IntPtr, ByRef lpRect As RECT) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll", EntryPoint:="GetForegroundWindow")>
    Private Shared Function GetForegroundWindow() As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    'Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tmr.Tick
    '    Tmr.Stop()
    '    If PictureBox1.Image IsNot Nothing Then PictureBox1.Image.Dispose()
    '    PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    '    PictureBox1.Image = GetForgroundWindowImage()
    '    resetBLCMask()
    '    Me.Show()

    'End Sub

    Private Function GetForgroundWindowImage() As Image
        Dim bmp As Bitmap = Nothing
        'Dim hWnd As IntPtr = GetForegroundWindow()
        Dim hWnd As Integer = windowID  ' fix the damn window
        If Not hWnd.Equals(IntPtr.Zero) Then
            Dim rec As New RECT
            GetWindowRect(hWnd, rec)
            Dim recSize As New Size(rec.right - rec.left, rec.bottom - rec.top)
            bmp = New Bitmap(recSize.Width, recSize.Height)
            Dim grfx As Graphics = Graphics.FromImage(bmp)
            grfx.CopyFromScreen(rec.left, rec.top, 0, 0, recSize, CopyPixelOperation.SourceCopy)
            grfx.Dispose()
        End If
        Return bmp
    End Function


    ''  All the stuff related to Window capture above

    ''
    ''
    ''
    ''
    ''
    ''
    '' What happens when GO is clicked :

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        statusLabel.Text = "Status : Cover lens now"
        Refresh()
        Threading.Thread.Sleep(3000)
        windowID = GetForegroundWindow()
        'If bmpBLCMask Is Nothing Then
        'Dim result As Integer = MessageBox.Show("Cover lens and press OK", "BLC Calibration", MessageBoxButtons.OK)
        'If result = DialogResult.OK Then
        resetBLCMask()
        '    End If
        'End If

        statusLabel.Text = "Status : Ok you can let go now"
        Refresh()
        'Threading.Thread.Sleep(3000) ' Wait 1 second

        subtractImage()
        Me.Refresh()
        'loopLikeMad()
        statusLabel.Text = "Status : Live streaming"
        Tmr.Start()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tmr.Tick
        'subtractImage()

        Me.Refresh()
        If PictureBox1.Image IsNot Nothing Then PictureBox1.Image.Dispose()
        subtractImage()

    End Sub



    'Private Sub loopLikeMad()
    '    For index As Integer = 1 To 5
    '        'subtractImage()
    '        statusLabel.Text = index.ToString
    '        'Me.Refresh()
    '        statusLabel.Refresh()
    '        Threading.Thread.Sleep(30)
    '    Next

    'End Sub

    Private Sub resetBLCMask()
        bmpBLCMask = GetForgroundWindowImage()
        'bmpgrBLCMask = Graphics.FromImage(bmpBLCMask)

    End Sub

    Private Sub removeBLCMask()
        Dim blackMask As Bitmap = bmpBLCMask
        Dim wid As Integer = blackMask.Width
        Dim hgt As Integer = blackMask.Height

        'Dim r1, g1, b1, As Integer
        Dim color1 As Color

        For x As Integer = 0 To wid - 1
            For y As Integer = 0 To hgt - 1
                'color1 = blackMask.GetPixel(x, y)
                ''r1 = color1.R : g1 = color1.G : b1 = color1.B

                color1 = Color.FromArgb(255, 0, 0, 0)
                blackMask.SetPixel(x, y, color1)
            Next y
        Next x

        bmpBLCMask = blackMask



    End Sub

    Private Sub subtractImage()


        ' Load the images.
        Dim bm1 As Bitmap = bmpBLCMask
        Dim bm2 As Bitmap = GetForgroundWindowImage()


        ' Make a difference image.
        'Dim wid As Integer = Math.Min(bm1.Width, bm2.Width)
        'Dim hgt As Integer = Math.Min(bm1.Height, bm2.Height)
        Dim wid As Integer = bm1.Width
        Dim hgt As Integer = bm1.Height
        Dim bm3 As New Bitmap(wid, hgt)


        Dim are_identical As Boolean = True
        Dim r1, g1, b1, r2, g2, b2, r3, g3, b3 As Integer
        Dim color1, color2, color3 As Color
        'get the image width and length
        For x As Integer = 0 To wid - 1
            For y As Integer = 0 To hgt - 1
                color1 = bm1.GetPixel(x, y)
                r1 = color1.R : g1 = color1.G : b1 = color1.B

                color2 = bm2.GetPixel(x, y)
                r2 = color2.R : g2 = color2.G : b2 = color2.B

                'r3 = 128 + (r1 - r2) \ 2
                'g3 = 128 + (g1 - g2) \ 2
                'b3 = 128 + (b1 - b2) \ 2

                r3 = Math.Abs(r2 - r1)
                g3 = Math.Abs(g2 - g1)
                b3 = Math.Abs(b2 - b1)

                r3 = Math.Min(r3 * trackBarBrightness.Value, 255)
                g3 = Math.Min(g3 * trackBarBrightness.Value, 255)
                b3 = Math.Min(b3 * trackBarBrightness.Value, 255)

                If r3 < trackBarGamma.Value Then
                    r3 = Math.Max(Math.Round(r3 * 0.01 * trackBarContrast.Value), 0)
                Else
                    r3 = Math.Min(Math.Round(r3 * 0.01 * (200 - trackBarContrast.Value)), 255)
                End If

                If g3 < trackBarGamma.Value Then
                    g3 = Math.Max(Math.Round(g3 * 0.01 * trackBarContrast.Value), 0)
                Else
                    g3 = Math.Min(Math.Round(g3 * 0.01 * (200 - trackBarContrast.Value)), 255)
                End If

                If b3 < trackBarGamma.Value Then
                    b3 = Math.Max(Math.Round(b3 * 0.01 * trackBarContrast.Value), 0)
                Else
                    b3 = Math.Min(Math.Round(b3 * 0.01 * (200 - trackBarContrast.Value)), 255)
                End If


                color3 = Color.FromArgb(255, r3, g3, b3)
                bm3.SetPixel(x, y, color3)

                If (r1 <> r2) OrElse (g1 <> g2) OrElse (b1 <>
                b2) Then are_identical = False
            Next y
        Next x

        finalPicture = bm3
        'Display the result.
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.Image = finalPicture
        'PictureBox1.Refresh()

        'finalPicture = bm3
        'bm1.Dispose()
        bm2.Dispose()
        'bm3.Dispose()

    End Sub

    Private Sub trackBarBrightness_Scroll(sender As Object, e As EventArgs) Handles trackBarBrightness.Scroll
        Label2.Text = String.Format("Brightness: {0}", trackBarBrightness.Value)
    End Sub

    'Private Sub frmScreenCopy_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Escape
    '            removeBLCMask()
    '        'Case Keys.F2
    '        '    If e.Control = False Then
    '        '        Clipboard.SetImage(Desktop)
    '        '    Else
    '        '        ' make a copy inluding the glass
    '        '        Dim bmp As Bitmap = pic.Image.Clone
    '        '        Dim bmpgr As Graphics = Graphics.FromImage(bmp)
    '        '        bmpgr.Clip = rgn
    '        '        bmpgr.DrawImage(bmpOriCopy, rctMagn, rctOriCopy, GraphicsUnit.Pixel)
    '        '        bmpgr.DrawEllipse(pn, rctMagn)
    '        '        Clipboard.SetImage(bmp.Clone)
    '        '        bmpgr.Dispose()
    '        '        bmp.Dispose()
    '        '    End If
    '        'Case Keys.F4
    '        '    If Cursor.Tag = "off" Then
    '        '        Cursor.Show()
    '        '        Cursor.Tag = "on"
    '        '    Else
    '        '        Cursor.Hide()
    '        '        Cursor.Tag = "off"
    '        '    End If
    '        Case Keys.F5
    '            PictureBox1.Hide()
    '            'resetBLCMask()


    '    End Select
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBLCRefresh.Click
        resetBLCMask()
    End Sub

    Private Sub btnDisableBLC_Click(sender As Object, e As EventArgs) Handles btnDisableBLC.Click
        removeBLCMask()
    End Sub

    Private Sub trackBarContrast_Scroll(sender As Object, e As EventArgs) Handles trackBarContrast.Scroll
        Label3.Text = String.Format("Contrast: {0}", trackBarContrast.Value)
    End Sub



    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles trackBarGamma.Scroll
        Label4.Text = String.Format("Gamma: {0}", trackBarGamma.Value)
    End Sub
End Class
