Option Strict On
Option Explicit On

Public Class AboutForm
    Sub AboutShow()
        'Shows the about form and hides the primary form. Matchs the background to the main form.
        BackColor = EtchOSketchForm.BackgroundColorChange(, False)
        EtchOSketchForm.Hide()
        Me.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Closes the form
        Me.Hide()
        EtchOSketchForm.Show()
    End Sub
End Class