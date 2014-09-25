Module Module1
    Dim n As Integer
    Dim i As Integer = 2
    Sub Main()
        n = Console.ReadLine()
        While Not n Mod i = 0
            i += 1
        End While
        Console.WriteLine("Nejmensi delitel je: " & i)
        Console.ReadKey()
    End Sub

End Module
