Module Module1
    Sub Main()
        Try
            Console.Write("Zadejte mocninu pro výpočet Eulerova čísla: ")
            Dim x As Double = CDbl(Console.ReadLine)
            Dim e As Double = 1 + x
            Dim i = 3
            Dim f = 2
            Dim eps
            Dim n = x * x
            Do
                eps = (n) / (f)
                e += eps
                f = f * i
                x *= x
                i += 1
            Loop While eps > 0.0001
            Console.WriteLine(e)
            Console.ReadKey()
        Catch e As Exception
            MsgBox(e.ToString, MsgBoxStyle.Critical, "ERROR " & Err.Number & " - " & Err.Description)
        End Try
    End Sub
End Module