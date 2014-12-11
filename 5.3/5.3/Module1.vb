Module Module1
    Sub Main()
        Console.WriteLine("Prvky oddělujte mezerami pak enter")
        Dim pole() = Console.ReadLine().Split(" ")
        Dim pole2 As New List(Of Integer)
        For Each s As String In pole
            pole2.Add(CInt(s))
        Next
        pole2.Remove(pole2.Max)
        Console.WriteLine(pole2.Max)
    End Sub
End Module