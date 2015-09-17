Module Module1

    Sub Main()
        Dim st As New Stopwatch
        st.Start()
        Dim a As Decimal = 0
        Dim b As Decimal = 1
        Dim last As Decimal
        Dim fx As Decimal
        Dim konec As Boolean = False
        Do
            Dim fa As Decimal = f(a)
            Dim fb As Decimal = f(b)
            Dim x = (a + b) / 2
            fx = f(x)
            Select Case Math.Sign(fx)
                Case Math.Sign(fa)
                    a = x
                Case Math.Sign(fb)
                    b = x
            End Select
            konec = last = fx
            last = fx
            'Console.WriteLine(String.Join(Environment.NewLine, fx, a, b, x))
            Console.WriteLine(x)
        Loop Until konec
        st.Stop()
        Console.WriteLine(st.Elapsed)
        Console.ReadKey()
    End Sub

    Function f(x As Decimal) As Decimal
        Return x - Math.Cos(x)
    End Function

End Module