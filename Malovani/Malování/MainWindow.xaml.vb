Imports System.IO

Class MainWindow
    Dim OFD As New Microsoft.Win32.OpenFileDialog
    Dim SFD As New Microsoft.Win32.SaveFileDialog
    Private Sub exit_Click(sender As Object, e As RoutedEventArgs) Handles [exit].Click
        Me.Close()
    End Sub

    Private Sub greyscale_Click(sender As Object, e As RoutedEventArgs) Handles greyscale.Click
        Dim file As String = Path.GetTempFileName
        Dim fs = New FileStream(file, FileMode.Create)
        Dim bitmap As New RenderTargetBitmap(canvas.ActualWidth, canvas.ActualHeight, 96, 96, PixelFormats.Default)
        bitmap.Render(canvas)
        Dim encoder As New BmpBitmapEncoder()
        encoder.Frames.Add(BitmapFrame.Create(bitmap))
        encoder.Save(fs)
        canvas.Strokes.Clear()
        fs.Close()

        Dim image As New System.Drawing.Bitmap(file)
        For x = 0 To image.Width - 1
            For y = 0 To image.Height - 1
                Dim c As System.Drawing.Color = image.GetPixel(x, y)
                Dim g As Integer = c.R * 0.2989 + c.G * 0.5868 + c.B * (1 - 0.2989 - 0.5868)
                Dim newColor As System.Drawing.Color = System.Drawing.Color.FromArgb(g, g, g) 'pro separaci napriklad Red by to bylo FromArgb(c.R,0,0)

                image.SetPixel(x, y, newColor)
            Next
        Next

        Dim file2 As String = Path.GetTempFileName

        image.Save(file2)

        Dim bmp As New BitmapImage(New Uri(file2))
        Dim br As New ImageBrush(bmp)
        br.Stretch = Stretch.None
        br.AlignmentX = AlignmentX.Left
        br.AlignmentY = AlignmentY.Top
        canvas.Height = bmp.Height
        canvas.Width = bmp.Width
        canvas.ResizeEnabled = False
        canvas.Background = br
    End Sub

    Private Sub negative_Click(sender As Object, e As RoutedEventArgs) Handles negative.Click
        Me.IsEnabled = False
        Dim file As String = Path.GetTempFileName
        Dim fs = New FileStream(file, FileMode.Create)
        Dim bitmap As New RenderTargetBitmap(canvas.ActualWidth, canvas.ActualHeight, 96, 96, PixelFormats.Default)
        bitmap.Render(canvas)
        Dim encoder As New BmpBitmapEncoder()
        encoder.Frames.Add(BitmapFrame.Create(bitmap))
        encoder.Save(fs)
        canvas.Strokes.Clear()
        fs.Close()

        Dim image As New System.Drawing.Bitmap(file)
        For x = 0 To image.Width - 1
            For y = 0 To image.Height - 1
                Dim c As System.Drawing.Color = image.GetPixel(x, y)
                Dim newColor As System.Drawing.Color = System.Drawing.Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B)

                image.SetPixel(x, y, newColor)
            Next
        Next

        Dim file2 As String = Path.GetTempFileName

        image.Save(file2)

        Dim bmp As New BitmapImage(New Uri(file2))
        Dim br As New ImageBrush(bmp)
        br.Stretch = Stretch.None
        br.AlignmentX = AlignmentX.Left
        br.AlignmentY = AlignmentY.Top
        canvas.Height = bmp.Height
        canvas.Width = bmp.Width
        canvas.ResizeEnabled = False
        canvas.Background = br
        Me.IsEnabled = True
    End Sub

    Private Sub new_Click(sender As Object, e As RoutedEventArgs) Handles [new].Click
        canvas.Strokes.Clear()
        canvas.Background = Brushes.White
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
            canvas.Strokes.Clear()
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

    Private Sub undo_Click(sender As Object, e As RoutedEventArgs) Handles undo.Click
        canvas.Strokes.RemoveAt(canvas.Strokes.Count - 1)
    End Sub
End Class