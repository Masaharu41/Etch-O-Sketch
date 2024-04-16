Option Strict On
Option Explicit On

Public Class AboutForm
    Sub AboutShow()
        BackColor = EtchOSketchForm.BackgroundColorChange(, False)
        EtchOSketchForm.Hide()
        Me.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
        EtchOSketchForm.Show()
    End Sub
End Class