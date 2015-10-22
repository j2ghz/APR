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
            Dim bmp As New BitmapImage(New Uri(OFD.FileName))
            Dim br As New ImageBrush(bmp)
            br.Stretch = Stretch.None
            br.AlignmentX = AlignmentX.Left
            br.AlignmentY = AlignmentY.Top
            canvas.Height = bmp.Height
            canvas.Width = bmp.Width
            canvas.ResizeEnabled = False
            canvas.Background = br
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As RoutedEventArgs) Handles save.Click
        If SFD.ShowDialog Then
            Dim fs = New FileStream(SFD.FileName, FileMode.Create)
            Dim bitmap As New RenderTargetBitmap(canvas.ActualWidth, canvas.ActualHeight, 96, 96, PixelFormats.Default)
            bitmap.Render(canvas)
            Dim encoder As New BmpBitmapEncoder()
            encoder.Frames.Add(BitmapFrame.Create(bitmap))
            encoder.Save(fs)
            fs.Close()
        End If
    End Sub
End Class