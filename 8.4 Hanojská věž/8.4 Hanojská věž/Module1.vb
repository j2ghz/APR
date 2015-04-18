Module Module1
    Dim A, B, C As New List(Of Integer)
    Sub Main()
        Console.Write("Zadejte počet disků: ")
        Dim disky As Integer = Console.ReadLine()

    End Sub
    Sub presun(ByRef start As List(Of Integer), ByRef cil As List(Of Integer), ByRef pomocny As List(Of Integer), ByVal pocet As Integer)
        presun(start, pomocny, cil, pocet - 1)
        cil.Add(start(0))
        'start.Remove()
        presun(pomocny, cil, start, pocet - 1)
    End Sub

End Module
