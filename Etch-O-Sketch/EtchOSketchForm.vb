'Owen Fujii
'RCET 2265
'Spring 2024
'Etch-O-Sketch
'https://github.com/Masaharu41/Etch-O-Sketch.git

Option Explicit On
Option Strict On


Imports System.Threading

Public Class EtchOSketchForm

    Private Sub LoadDefaults(sender As Object, e As EventArgs) Handles Me.Load
        ForegroundColor(Color.Black, True)
        BackColor = BackgroundColorChange(Color.Firebrick, True)
        DrawingPictureBox.BackColor = PictureForegroundColor(Color.LemonChiffon, True)
    End Sub

    Sub ClearForm()
        DrawingPictureBox.Image = Nothing
    End Sub

    Sub mousedraw(x As Integer, y As Integer, updateCord As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor(, False), 5)
        Static oldX As Integer, oldY As Integer
        If updateCord = False Then
            'oldX = x
            g.DrawLine(pen, oldX, oldY, x, y)
            ' oldY = y

        End If
        oldX = x
        oldY = y
        pen.Dispose()
        g.Dispose()
    End Sub

    Function ForegroundColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static newColorVar As Color

        If update Then
            newColorVar = newColor

        End If

        Return newColorVar

    End Function
    Function BackgroundColorChange(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static newColorVar As Color

        If update Then
            newColorVar = newColor

        End If

        Return newColorVar

    End Function

    Function PictureForegroundColor(Optional newcolor As Color = Nothing, Optional update As Boolean = False) As Color
        Static newColorVar As Color

        If update Then
            newColorVar = newcolor

        End If
        Return newColorVar

    End Function


    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        'Remove Text for Full submission
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        'mousedraw(e.X, e.Y)
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        'Remove Text for Full submission
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, True)
        End If
    End Sub

    Private Sub CursorColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursorColorToolStripMenuItem.Click, SelectColorButton.Click

        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ForegroundColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub DrawingPadColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawingPadColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            PictureForegroundColor(ColorDialog.Color, True)
        End If
        DrawingPictureBox.BackColor = PictureForegroundColor(, False)
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            BackgroundColorChange(ColorDialog.Color, True)
        End If
        BackColor = BackgroundColorChange(, False)
    End Sub

    'TODO
    '[*] Shake Screen

    Sub ShakeTheScreen()
        'Shakes the screen randomly and returns to its original point
        Dim originalScreenX As Integer
        Dim originalScreenY As Integer
        Dim modifiedX As Integer
        Dim modifiedY As Integer
        Dim screenPoint As Point
        screenPoint = Me.Location
        originalScreenX = screenPoint.X
        originalScreenY = screenPoint.Y

        modifiedX = screenPoint.X
        modifiedY = screenPoint.Y
        For i = 0 To 10
            modifiedX = originalScreenX - RandomScreenCoord()
            modifiedY = originalScreenY - RandomScreenCoord()
            Me.Location = New Point(modifiedX, modifiedY)
            Thread.Sleep(30)
            modifiedX = originalScreenX + RandomScreenCoord()
            modifiedY = originalScreenY + RandomScreenCoord()
            Me.Location = New Point(modifiedX, modifiedY)
            Thread.Sleep(30)
        Next
        Me.Location = New Point(originalScreenX, originalScreenY)
    End Sub

    Function RandomScreenCoord() As Integer
        Dim temp As Integer
        Randomize()
        temp = CInt(Rnd() * 100)
        Return temp
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ShakeTheScreen()
        ClearForm()
    End Sub

    Sub DrawSinWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Static x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer
        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height
        For i = 1 To screenEnd * 4
            y = Math.Sin(i / screenEnd * 2 * pi) * (screenTop / 8) + (screenTop / 6)
            x = i
            g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            ' oldY = y
        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCosWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue, 5)
        Static x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer
        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height

        For i = 1 To screenEnd * 4
            y = Math.Cos(i / screenEnd * 2 * pi) * (screenTop / 8) + (screenTop / 2)
            x = i
            g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            ' oldY = y
        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawTanWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Purple, 5)
        Static x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer

        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height

        For i = 1 To screenEnd * 4
            y = Math.Tan(i / screenEnd * 2 * pi) * (screenTop / 16) + (screenTop / 2)
            x = i
            Try
                g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

            Catch ex As Exception
            End Try

        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click
        DrawSinWave()
        DrawCosWave()
        DrawTanWave()
    End Sub

    Private Sub DrawingPictureBox_MouseClick(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseClick
        'Handles when the middle button of the mouse is clicked on the picture box.
        'If the button is pressed then cursor color change will be available 
        Select Case e.Button
            Case MouseButtons.Left
            Case MouseButtons.Middle
                If ColorDialog.ShowDialog() = DialogResult.OK Then
                    ForegroundColor(ColorDialog.Color, True)
                End If
            Case MouseButtons.Right
            Case Else
        End Select
    End Sub
End Class
