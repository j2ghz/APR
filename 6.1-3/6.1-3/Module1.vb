Module Module1

    Sub Main()
        Console.Write("Zadejte počet řádků:") : Dim radky = Console.ReadLine
        Console.Write("Zadejte počet sloupců:") : Dim sloupce = Console.ReadLine
        Dim matice(radky, sloupce) As Integer
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                Console.WriteLine("Zadejte prvek {0},{1}: ", radek, sloupce)
                matice(radek, sloupec) = Console.ReadLine
                Console.Write(vbCr)
            Next
        Next
    End Sub

End Module
