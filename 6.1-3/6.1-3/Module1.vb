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
        For radek As Integer = 1 To radky
            Dim tmp As Integer = 0
            For sloupec As Integer = 1 To sloupce
                tmp += matice(radek, sloupec)
            Next
            Console.WriteLine("Řádkový součet {0}: {1}", radek, tmp)
            tmp = 0
        Next
        For sloupec As Integer = 1 To sloupce
            Dim tmp As Integer = 0
            For radek As Integer = 1 To radky
                tmp += matice(radek, sloupec)
            Next
            Console.WriteLine("Sloupcový součet {0}: {1}", sloupec, tmp)
            tmp = 0
        Next
        Dim diag As Integer = 0
        For i As Integer = 1 To Math.Min(radky, sloupce)
            diag += matice(i, i)
        Next
        Console.WriteLine("Diagonálový součet : {0}", diag)
        Dim vdiag As Integer = 0
        For i As Integer = 1 To Math.Min(radky, sloupce)
            vdiag += matice(i, sloupce - i + 1)
        Next
        Console.WriteLine("Vedlejší diagonálový součet : {0}", vdiag)
        Dim nul As Integer
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                If matice(radek, sloupec) = 0 Then nul += 1
            Next
        Next
        Console.WriteLine("Počet nulových prvků: {0}", nul)
        Console.ReadKey()
    End Sub

End Module
