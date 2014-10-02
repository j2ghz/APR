Module Module1 'https://github.com/j2ghz/APS
    Dim n As Integer
    Dim i As Integer = 2
    Sub Main()
        n = Console.ReadLine()
        While Not n Mod i = 0
            i += 1
        End While
        If i = n Then
            Console.WriteLine("Je prvocislo")
        Else
            Console.WriteLine("Neni prvocislo")
        End If
        Console.ReadKey()
    End Sub

End Module
