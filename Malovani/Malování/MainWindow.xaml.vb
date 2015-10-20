Imports System.IO

Class MainWindow
    Dim OFD As New Microsoft.Win32.OpenFileDialog
    Dim SFD As New Microsoft.Win32.SaveFileDialog
    Private Sub exit_Click(sender As Object, e As RoutedEventArgs) Handles [exit].Click
        Me.Close()
    End Sub

    Private Sub new_Click(sender As Object, e As RoutedEventArgs) Handles [new].Click
        canvas.Strokes.Clear()
    End Sub

    Private Sub open_Click(sender As Object, e As RoutedEventArgs) Handles open.Click
        If OFD.ShowDialog() Then
            MsgBox("open")
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As RoutedEventArgs) Handles save.Click
        If SFD.ShowDialog Then
            Dim fs = New FileStream(SFD.FileName, FileMode.Create)
            canvas.Strokes.Save(fs)
            fs.Close()
        End If
    End Sub
End Class