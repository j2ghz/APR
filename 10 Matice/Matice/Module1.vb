Imports MathNet.Numerics.LinearAlgebra

Module Module1

    Sub Main()
        Dim A = Matrix(Of Integer).Build
        A.Random(3, 4)
        Dim B = Matrix(Of Integer).Build.Random(4, 3, 2)
        Dim C = A * B
        Console.WriteLine(C.ToString)
        Console.ReadKey()
    End Sub

End Module