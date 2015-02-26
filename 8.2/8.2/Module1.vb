Module Module1

    Sub Main()
        vypis(Console.ReadLine)
    End Sub

    Sub vypis(s As String)
        If s.Count = 0 Then
            Console.ReadKey()
            Exit Sub
        End If
        Console.Write(s(s.Length - 1))
        vypis(s.Substring(0, s.Length - 1))
    End Sub

End Module
