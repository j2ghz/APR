Module Module1
    Dim a As New List(Of String)
    Sub Main()
        Console.Write("zadejte prvky oddělené čárkami: ")
        Dim s As String = Console.ReadLine()
        Dim b() As String = s.Split(",")
        a.AddRange(b)
        Console.WriteLine("Zadejte prvek k vyhledání: ")
        Console.WriteLine("Index je: " & a.BinarySearch(Console.ReadLine()))
        Console.ReadKey()
    End Sub

End Module
