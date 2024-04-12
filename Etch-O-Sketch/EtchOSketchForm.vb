'Owen Fujii
'RCET 2265
'Spring 2024
'Etch-O-Sketch
'

Option Explicit On
Option Strict On


Public Class EtchOSketchForm

    Private Sub LoadDefaults(sender As Object, e As EventArgs) Handles Me.Load
        ForegroundColor(Color.Black, True)
        BackColor = BackgroundColorChange(Color.Firebrick, True)
        DrawingPictureBox.BackColor = PictureForegroundColor(Color.LemonChiffon, True)
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

    Private Sub CursorColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursorColorToolStripMenuItem.Click
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
End Class
