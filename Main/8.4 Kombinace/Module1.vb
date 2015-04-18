Module Module1
    Dim task As New TaskFactory(Of ULong)
    Dim vysledky As New Dictionary(Of String, Integer)
    Sub Main()
        Console.WriteLine("Zadejte m a n oddelene mezerou: ")
        Dim vstup() = Console.ReadLine.Split(" ")
        Console.WriteLine("Počítám... ")
        Console.WriteLine("Výsledek je: " & kombinace(vstup(0), vstup(1)))
        Console.ReadKey()
    End Sub

    Function kombinace(m As ULong, n As ULong) As ULong
        Console.WriteLine(m & " " & n)
        Select Case True
            Case n = 0
                Return 1
            Case n = 1
                Return n
            Case n = m
                Return 1
            Case Else
                If Not vysledky.ContainsKey(m & " " & n) Then
                    vysledky.Add(m & " " & n, kombinace(m - 1, n - 1) + kombinace(m - 1, n))
                End If
                Return vysledky(m & " " & n)
        End Select
    End Function

End Module
