Module Module1
    Dim n As Integer
    Dim prvocislo As Boolean = True
    Sub Main()
        n = Console.ReadLine
        For i As Integer = 2 To Math.Round(Math.Sqrt(n), MidpointRounding.AwayFromZero) Step 1
            If n Mod i = 0 Then
                prvocislo = False
                Exit For
            End If
        Next
        Console.WriteLine(prvocislo)
    End Sub

End Module
