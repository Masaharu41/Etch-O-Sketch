'Owen Fujii
'RCET 2265
'Spring 2024
'Etch-O-Sketch
'https://github.com/Masaharu41/Etch-O-Sketch.git

Option Explicit On
Option Strict On


Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class EtchOSketchForm

    Private Sub LoadDefaults(sender As Object, e As EventArgs) Handles Me.Load
        'loads the default colors of the form on load
        DefaultColors()
    End Sub

    Sub DefaultColors()
        'Loads the default color scheme of the form
        DrawingPictureBox.Image = Nothing
        ForegroundColor(Color.Black, True)
        BackColor = BackgroundColorChange(Color.Firebrick, True)
        DrawingPictureBox.BackColor = PictureForegroundColor(Color.LemonChiffon, True)
    End Sub

    Sub ClearForm()
        'Clears the form's picture box
        DrawingPictureBox.Image = Nothing
    End Sub

    Sub mousedraw(x As Integer, y As Integer, updateCord As Boolean)
        'This sub is what allows the user to draw on the picturebox.
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
        'Changes and saves the color of the cursor based on user input.
        Static newColorVar As Color
        If update Then
            newColorVar = newColor

        End If

        Return newColorVar

    End Function
    Function BackgroundColorChange(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        'Changes and saves the Color of the Form's background. Background color is unified for all forms
        Static newColorVar As Color

        If update Then
            newColorVar = newColor

        End If

        Return newColorVar

    End Function

    Function PictureForegroundColor(Optional newcolor As Color = Nothing, Optional update As Boolean = False) As Color
        'Changes and saves the color for the Drawing Picture Box background
        Static newColorVar As Color
        If update Then
            newColorVar = newcolor

        End If
        Return newColorVar

    End Function


    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        'Gives a display of the cursors position on the drawing pad to the user when the mouse is moved.
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        'mousedraw(e.X, e.Y)
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        'Gives a display of the cursors location when any of the mouse's buttons are pressed.
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, True)
        End If
    End Sub

    Private Sub CursorColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, ChangeColorToolStripMenuItem.Click, SelectColorToolStripMenuItem1.Click
        ' loads the color change form
        ColorForm.LoadColors()

    End Sub
    Sub ChangeCursorColor()
        'Changes the cursor color based on user input
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ForegroundColor(ColorDialog.Color, True)
        End If
    End Sub
    Sub DrawingPadColorClick()
        'Changes the background color of the Drawing Picture Box based on a user set color
        'The sub is called from the color change form. For this particular sub the 
        'screen is cleared as the color would just cover existing drawings
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            PictureForegroundColor(ColorDialog.Color, True)
        End If
        ShakeTheScreen(PlayAudio)
        ClearForm()
        DrawingPictureBox.BackColor = PictureForegroundColor(, False)
    End Sub

    Sub BackgroundColorClick()

        If ColorDialog.ShowDialog() = DialogResult.OK Then
            BackgroundColorChange(ColorDialog.Color, True)
        End If

        BackColor = BackgroundColorChange(, False)
    End Sub

    'TODO
    '[*] Shake Screen

    Sub ShakeTheScreen(maddness As Boolean)
        'Shakes the screen randomly and returns to its original point after it is done
        'Also stops the music from the music loop once the operation is complete
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
        If maddness = False Then
            For i = 0 To 15
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
            My.Computer.Audio.Stop()
        Else
            For i = 0 To 39
                modifiedX = modifiedX - RandomScreenCoord()
                modifiedY = modifiedY - RandomScreenCoord()
                Me.Location = New Point(modifiedX, modifiedY)
                Thread.Sleep(30)
                modifiedX = modifiedX + RandomScreenCoord()
                modifiedY = modifiedY + RandomScreenCoord()
                Me.Location = New Point(modifiedX, modifiedY)
                Thread.Sleep(30)
            Next
            Me.Location = New Point(originalScreenX, originalScreenY)
            My.Computer.Audio.Stop()
        End If

    End Sub

    Function RandomScreenCoord() As Integer
        'creates a random number to be used as a screen coordinate
        Dim temp As Integer
        Randomize()
        temp = CInt(Rnd() * 100)
        Return temp
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        'To mimic a real etch o sketch the screen shakes and then the content is cleared.
        ' PlayAudio()
        ShakeTheScreen(PlayAudio)
        ClearForm()
    End Sub

    Function PlayAudio() As Boolean
        Static clearedRuns As Integer
        If clearedRuns = 2 Then
            Try
                My.Computer.Audio.Play("..\..\WhyNot.wav", AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
                MsgBox("no audio found")
            End Try
            clearedRuns = clearedRuns + 1
            Return True
        Else
            Try
                My.Computer.Audio.Play("..\..\SHAKER.wav", AudioPlayMode.BackgroundLoop)
            Catch ex As Exception
                MsgBox("no audio found")
            End Try
        End If
        clearedRuns = clearedRuns + 1
        Return False
    End Function

    Sub DrawSinWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen
        'Produces a high resolution waveform at the expense of processing time
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer
        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height
        For i = 1 To screenEnd * 4
            y = Math.Sin(-i / screenEnd * 2 * pi) * (screenTop / 6) + (screenTop / 3)
            x = i
            g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            ' oldY = y
        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCosWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen
        'Produces a high resolution waveform at the expense of processing time
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer
        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height

        For i = 1 To screenEnd * 4
            y = Math.Cos(-i / screenEnd * 2 * pi) * (screenTop / 6) + (screenTop * 2 / 3)
            x = i
            g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            ' oldY = y
        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawGrid()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 2)
        Dim x As Double, y As Double
        Dim xIntcrement As Integer, yIntcrement As Integer
        xIntcrement = CInt(DrawingPictureBox.Width / 10)
        yIntcrement = CInt(DrawingPictureBox.Height / 10)
        x = DrawingPictureBox.Width
        y = DrawingPictureBox.Height

        For i = 1 To 9
            g.DrawLine(pen, xIntcrement, 0, xIntcrement, CType(y, Single))
            xIntcrement = xIntcrement + CInt(DrawingPictureBox.Width / 10)
        Next
        For i = 1 To 9
            g.DrawLine(pen, 0, yIntcrement, CType(x, Single), yIntcrement)
            yIntcrement = yIntcrement + CInt(DrawingPictureBox.Height / 10)
        Next
    End Sub

    Sub DrawTanWave()
        'Draws a one cycle sine wave that is matched to the dimensions of the screen

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Purple, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenEnd As Integer
        Dim screenTop As Integer

        screenEnd = DrawingPictureBox.Width
        screenTop = DrawingPictureBox.Height

        For i = 1 To screenEnd * 4
            y = Math.Tan(-i / screenEnd * 2 * pi) * (screenTop / 16) + (screenTop / 2)
            x = i
            Try
                g.DrawLine(pen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

            Catch ex As Exception
            End Try

        Next

        pen.Dispose()
        g.Dispose()
    End Sub
    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsToolStripMenuItem1.Click, DrawWaveformsToolStripMenuItem1.Click, DrawWaveformsToolStripMenuItem.Click
        'Calls all waveform subs
        ShakeTheScreen(PlayAudio())
        DrawGrid()
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
                ColorForm.LoadColors()
            Case MouseButtons.Right
            Case Else
        End Select
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays the about form and hides the main etch o sketch
        AboutForm.AboutShow()
    End Sub

End Class
