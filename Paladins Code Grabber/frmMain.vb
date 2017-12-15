Imports AutoItX3Lib
Public Class frmMain
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function


    Dim mousehotkey As Boolean
    Dim a As New AutoItX3
    Private Sub tmrHotkey_Tick(sender As Object, e As EventArgs) Handles tmrHotkey.Tick
        mousehotkey = GetAsyncKeyState(Keys.RButton)
        If mousehotkey = True Then
            a.Send(lblClipboard.Text)
            My.Computer.Clipboard.Clear()
        End If
    End Sub

    Private Sub tmrCheckClipboard_Tick(sender As Object, e As EventArgs) Handles tmrCheckClipboard.Tick
        lblClipboard.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub tmrHotkey_Tick_1(sender As Object, e As EventArgs) Handles tmrHotkey.Tick
        mousehotkey = GetAsyncKeyState(Keys.RButton)
        If mousehotkey = True Then
            a.Send(lblClipboard.Text)
            My.Computer.Clipboard.Clear()
        End If
    End Sub
End Class