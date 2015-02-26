Module Module1
    Dim i As Integer = 0
    Sub Main()
        Console.Write("Zadejte počet: ")
        i = Console.ReadLine
        hvezdicka()
        Console.ReadKey()
    End Sub

    Sub hvezdicka()
        If i > 0 Then
            Console.WriteLine("*")
            i -= 1
            hvezdicka()
        End If
    End Sub

End Module
