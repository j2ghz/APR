Module Module1
    Dim a as integer
dim b As Integer
    Sub Main()
        Console.Write("a=")
        a = Console.ReadLine
        Console.Write("b=")
        b = Console.ReadLine
        Console.WriteLine("(Z)koušení nebo (E)uklidova metoda?")
        Select Case Console.ReadLine.ToLower
            Case "z"
                zkouseni()
            Case "e"
                euklidova()
        End Select
    End Sub
    Sub zkouseni()
        For i = Math.Min(a, b) To 1 Step -1
            If a Mod i = 0 AndAlso b Mod i = 0 Then
                Console.WriteLine(i)
                Console.ReadKey()
                Exit Sub
            End If
        Next
    End Sub
    Sub euklidova()
        If a < b Then
            Dim tmp = a
            a = b
            b = tmp
        End If
        While Not a Mod b = 0
            b = a Mod b
        End While
        Console.WriteLine(b)
        Console.ReadKey()
    End Sub
End Module
