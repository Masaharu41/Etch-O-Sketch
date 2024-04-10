'Owen Fujii
'RCET 2265
'Spring 2024
'Etch-O-Sketch
'




Public Class EtchOSketchForm

    Sub mousedraw(x As Integer, y As Integer, updateCord As Boolean)
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
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

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        'mousedraw(e.X, e.Y)
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Me.Text = $"({e.X},{e.Y} Button: {e.Button})"
        If e.Button = MouseButtons.Left Then
            mousedraw(e.X, e.Y, True)
        End If
    End Sub
End Class
