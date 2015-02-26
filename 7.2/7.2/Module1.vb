Module Module1
    Sub Main()
        For i As Integer = -1 To 50
            Console.WriteLine(spocitej(i))
        Next
        Console.ReadKey()
    End Sub
    Function spocitej(ByVal x As Double) As Double
        Dim e As Double = 1 + x
        Try
            Dim i = 3
            Dim f = 2
            Dim eps As Double = 0
            Dim n = x * x
            Do
                eps = (n) / (f)
                e += eps
                f = f * i
                x *= x
                i += 1
            Loop While Math.Abs(eps) > 0.0001
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine("ERROR " & Err.Number & " - " & Err.Description)
            Console.WriteLine(ex.ToString)
        End Try
        Return e
    End Function
End Module