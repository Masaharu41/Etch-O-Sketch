﻿'Owen Fujii
'RCET 2265
'Spring 2024
'Etch-O-Sketch
'https://github.com/Masaharu41/Etch-O-Sketch.git

Option Explicit On
Option Strict On


Imports System.IO.Ports
Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class EtchOSketchForm

    Dim sp As String
    Dim port As Boolean = False
    Dim startCh As Byte
    Dim msbX As Byte
    Dim lsbX As Byte
    Dim msbY As Byte
    Dim lsbY As Byte

    Private Sub LoadDefaults(sender As Object, e As EventArgs) Handles Me.Load
        'loads the default colors of the form on load

        DefaultColors()
        OpenPort()
    End Sub

    Sub OpenPort(Optional force As Boolean = False)
        Dim portValid As Boolean = False
        Dim portName As String
        ' auto test "all" COM port values until a valid connection or nothing reports back
        If force = True Then
            Try
                portName = ComComboBox.Text
                EtchSerialPort.BaudRate = 9600
                EtchSerialPort.PortName = portName
                EtchSerialPort.Open()
                portValid = True
            Catch ex As Exception
                portValid = False
                portName = ComComboBox.Text
                EtchSerialPort.Close()
            End Try
        Else
            For i = 0 To 50

                portName = $"COM{i}"
                Try
                    EtchSerialPort.BaudRate = 9600
                    EtchSerialPort.PortName = portName
                    EtchSerialPort.Open()
                    portValid = True
                    Exit For
                Catch ex As Exception
                    ' MsgBox("Com was not Valid")
                    portValid = False
                    EtchSerialPort.Close()
                End Try
            Next
        End If

        If portValid = True Then
            PortLabel.Text = "Port Is Open"
            ComComboBox.Text = portName
            port = True
        Else
            PortLabel.Text = "Port Is Closed"
            port = False
        End If
    End Sub



    Sub DefaultColors()
        'Loads the default color scheme of the form
        DrawingPictureBox.Refresh()
        ForegroundColor(Color.Black, True)
        BackColor = BackgroundColorChange(Color.Firebrick, True)
        DrawingPictureBox.BackColor = PictureForegroundColor(Color.LemonChiffon, True)
    End Sub

    Sub ClearForm()
        'Clears the form's picture box
        DrawingPictureBox.Refresh()
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
        If e.Button = MouseButtons.Left And ExternalCheckBox.Checked = False Then
            mousedraw(e.X, e.Y, False)
        Else
        End If
    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        'Gives a display of the cursors location when any of the mouse's buttons are pressed.
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        If e.Button = MouseButtons.Left And ExternalCheckBox.Checked = False Then
            mousedraw(e.X, e.Y, True)
        Else

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
        Dim x As Integer, y As Integer
        Dim xIncrement As Integer, yIncrement As Integer
        xIncrement = CInt(DrawingPictureBox.Width / 10)
        yIncrement = CInt(DrawingPictureBox.Height / 10)
        x = DrawingPictureBox.Width
        y = DrawingPictureBox.Height

        For i = 1 To 9
            g.DrawLine(pen, xIncrement, 0, xIncrement, y)
            xIncrement = xIncrement + CInt(DrawingPictureBox.Width / 10)
        Next
        For i = 1 To 9
            g.DrawLine(pen, 0, yIncrement, x, yIncrement)
            yIncrement = yIncrement + CInt(DrawingPictureBox.Height / 10)
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
        ClearForm()
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


    ''' <summary>
    ''' Converts the upper 8 bits to an aspect of the screen
    ''' This gives full screen range regardless of size of picture box
    ''' </summary>
    ''' <param name="axis"></param>
    ''' <param name="currentHex%"></param>
    ''' <returns></returns>
    Public Function CovertToCords(axis As Boolean, currentHex%) As Integer
        Dim xAspect As Double = DrawingPictureBox.Width / 1000
        Dim yAspect As Double = DrawingPictureBox.Height / 1000
        Dim cordReturn%

        If axis = True Then
            cordReturn = CInt(xAspect * currentHex) - 10
        Else
            cordReturn = CInt(yAspect * currentHex) - 10
        End If
        Return cordReturn
    End Function

    Private Sub XTrackBar_DragLeave(sender As Object, e As EventArgs) Handles XTrackBar.ValueChanged
        If ExternalCheckBox.Checked Then
            mousedraw(CovertToCords(True, XTrackBar.Value), CovertToCords(False, YTrackBar.Value), False)
        Else
        End If
    End Sub

    Private Sub YTrackBar_DragLeave(sender As Object, e As EventArgs) Handles YTrackBar.ValueChanged
        If ExternalCheckBox.Checked Then
            mousedraw(CovertToCords(True, XTrackBar.Value), CovertToCords(False, YTrackBar.Value), False)
        Else

        End If
    End Sub

    Sub PollX()
        ' Sends byte to get the adc result for ADC1
        Dim x(1) As Byte
        x(0) = &H51
        EtchSerialPort.Write(x, 0, 2)
    End Sub

    Sub PollY()
        ' Sends byte to get the adc result for ADC2
        Dim y(0) As Byte
        y(0) = &H52
        EtchSerialPort.Write(y, 0, 1)
    End Sub

    Sub PollCycle()
        Static alt As Boolean
        ' Alternate polling the two ADCs
        If alt Then
            PollX()
            alt = False
        Else
            PollY()
            alt = True
        End If
    End Sub

    Sub ConvertWriteX()
        ' Convert the incoming data into integers that represent the decimal value of the hex
        Dim xDec%, yDec%
        Dim shiftByte As Byte
        shiftByte = lsbX >> 6
        xDec = CInt(msbX) * 4 + CInt(shiftByte)
        shiftByte = lsbY >> 6
        yDec = CInt(msbY) * 4 + CInt(shiftByte)
        Console.WriteLine(xDec)
        Console.WriteLine(yDec)

        mousedraw(CovertToCords(True, xDec), CovertToCords(False, yDec), False)

    End Sub

    Private Sub EtchSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles EtchSerialPort.DataReceived
        Thread.Sleep(5)
        Static both As Boolean
        'startCh = data(0)
        Try
            Dim data(EtchSerialPort.BytesToRead) As Byte
            EtchSerialPort.Read(data, 0, EtchSerialPort.BytesToRead)
            If both Then

                msbX = data(0)
                lsbX = data(1)
                both = False
            Else
                ' waits to write data until both x and y have been polled
                msbY = data(0)
                lsbY = data(1)
                both = True
                ConvertWriteX()

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If AutoCheckBox.Checked Then
            ' enables auto connect for the serial port
            OpenPort()
        Else
            OpenPort(True)
        End If
    End Sub



    Private Sub ExternalCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExternalCheckBox.CheckedChanged
        ' Selects whether the the sliders are used or the external serial device.
        ' port must be open to enable
        If ExternalCheckBox.Checked And port Then
            Timer.Enabled = True
        Else
            Timer.Enabled = False
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' activates polling when timer is done
        If port = True Then
            PollCycle()
        Else
            Timer.Enabled = False
        End If
    End Sub
End Class
