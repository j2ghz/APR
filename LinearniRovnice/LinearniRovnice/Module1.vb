Module Module1

    Sub Main()
        Console.Write("počet rovnic = ")
        Dim N As Integer = Console.ReadLine
        Dim r As New rovnice(N)
        For i As Integer = 0 To N - 1
            For a As Integer = 0 To N
                Console.Write(IIf(a = N, "b", "a") & "({0},{1}) = ", i, a)
                r(i, a) = Console.ReadLine()
            Next
        Next
        Console.WriteLine(r)
        r = r.trojuhelnikovy_tvar
        Console.WriteLine(r)
        Dim x(N - 1) As Decimal
        For i As Integer = N - 1 To 0 Step -1
            Console.Write("x" & i + 1 & " = ")
            Dim v = r(i, N)
            For a As Integer = i + 1 To N - 1
                v -= x(a) * r(i, a)
            Next
            x(i) = v
            Console.WriteLine(v)
        Next
        Console.ReadKey()
        'TODO: predelat na funkci, pridat testy
    End Sub

End Module