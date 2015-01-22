Module Module1

    Sub Main()
        Console.Write("Zadejte počet řádků:") : Dim radky As Integer = Console.ReadLine
        Console.Write("Zadejte počet sloupců:") : Dim sloupce As Integer = Console.ReadLine
        Dim matice(radky, sloupce) As Integer
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                Console.Write("Zadejte prvek {0},{1}: ", radek, sloupec)
                matice(radek, sloupec) = Console.ReadLine
                Console.SetCursorPosition(0, Console.CursorTop - 1)
                Console.WriteLine("                              ")
                Console.SetCursorPosition(0, Console.CursorTop - 1)
            Next
        Next
        Console.Clear()
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                Console.Write(matice(radek, sloupec) & IIf(sloupec = sloupce, "", ","))
            Next
            Console.WriteLine()
        Next
        Console.Write("Který řádek vyměnit? ") : Dim Vradek As Integer = Console.ReadLine
        Console.Write("S kterým? ") : Dim Vradek2 As Integer = Console.ReadLine
        Dim matice2(radky, sloupce) As Integer
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                matice2(radek, sloupec) = matice(IIf(radek = Vradek, Vradek2, IIf(radek = Vradek2, Vradek, radek)), sloupec)
            Next
        Next
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                Console.Write(matice2(radek, sloupec) & IIf(sloupec = sloupce, "", ","))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
