Option Strict On
Option Explicit On

Public Class ColorForm
    Sub LoadColors()
        Me.Show()
        Dim buttonColors As Color = EtchOSketchForm.PictureForegroundColor(, False)
        BackColor = EtchOSketchForm.BackgroundColorChange(, False)
        ColorLabel.BackColor = buttonColors
        CursorColorButton.BackColor = buttonColors
        BackgroundColorButton.BackColor = buttonColors
        DrawingColorButton.BackColor = buttonColors

    End Sub

    Sub CursorColorButtonClicked(sender As Object, e As EventArgs) Handles CursorColorButton.Click
        Me.Hide()
        EtchOSketchForm.ChangeCursorColor()
    End Sub

    Sub BackgroundColorButtonClicked(sender As Object, e As EventArgs) Handles BackgroundColorButton.Click
        Me.Hide()
        EtchOSketchForm.BackgroundColorClick()
    End Sub

    Sub DrawingColorButtonClicked(sender As Object, e As EventArgs) Handles DrawingColorButton.Click
        Me.Hide()
        EtchOSketchForm.DrawingPadColorClick()
    End Sub
End Class