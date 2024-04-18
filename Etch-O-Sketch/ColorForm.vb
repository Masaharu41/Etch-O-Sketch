Option Strict On
Option Explicit On

Public Class ColorForm
    Sub LoadColors()
        'On form call the background color is matched with the primary form. This does not hid the main form.
        Me.Show()
        Dim buttonColors As Color = EtchOSketchForm.PictureForegroundColor(, False)
        BackColor = EtchOSketchForm.BackgroundColorChange(, False)

    End Sub

    Sub CursorColorButtonClicked(sender As Object, e As EventArgs) Handles CursorColorButton.Click
        'When user selects cursor color the etch o sketch is called again and transfers to the color dialog
        Me.Hide()
        EtchOSketchForm.ChangeCursorColor()
    End Sub

    Sub BackgroundColorButtonClicked(sender As Object, e As EventArgs) Handles BackgroundColorButton.Click
        'When user selects background color the etch o sketch is called again and transfers to the color dialog
        Me.Hide()
        EtchOSketchForm.BackgroundColorClick()
    End Sub

    Sub DrawingColorButtonClicked(sender As Object, e As EventArgs) Handles DrawingColorButton.Click
        'When user selects the Drawing pad color the etch o sketch is called again and transfers to the color dialog.
        Me.Hide()
        EtchOSketchForm.DrawingPadColorClick()
    End Sub

    Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        'Loads the default color scheme that the form had upon load.
        Me.Hide()
        EtchOSketchForm.DefaultColors()
    End Sub
End Class