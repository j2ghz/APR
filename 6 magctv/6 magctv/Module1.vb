Module Module1
    Dim pole(,) As Integer
    Sub Main()
        Console.Write("Zadejte n:")
        Dim n As Integer = Console.ReadLine()
        ReDim pole(n + 1, n + 1)
        Dim k, j As Integer
        k = n 'radek
        j = (n + 1) / 2 'sloupec
        For i As Integer = 0 To n * n - 1
            pole((k + i) Mod n, (j - i) Mod n) = i + 1
        Next
        For k = 1 To n
            For j = 1 To n
                Console.Write(pole(k, j) & "    ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
