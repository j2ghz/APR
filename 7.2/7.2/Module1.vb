Module Module1
    Sub Main()
        Try
            Console.Write("Zadejte mocninu pro výpočet Eulerova čísla: ")
            Dim x As Double = CDbl(Console.ReadLine)
            Dim e As Double = 1 + x
            Dim i = 3
            Dim f = 2
            Dim eps = 0
            Dim n = x * x
            Do
                pripocitej(eps, n, f, e, i, x)
            Loop While eps > 0.0001
            Console.WriteLine(e)
            Console.ReadKey()
        Catch e As Exception
            MsgBox(e.ToString, MsgBoxStyle.Critical, "ERROR " & Err.Number & " - " & Err.Description)
        End Try
    End Sub
    Sub pripocitej(ByRef eps, ByRef n, ByRef f, ByRef e, ByRef i, ByRef x)
        eps = (n) / (f)
        e += eps
        f = f * i
        x *= x
        i += 1
    End Sub
End Module