Module Module1
    Enum _smer
        up
        down
        left
        right
    End Enum
    Sub Main()
        Console.Write("Zadejte počet řádků a sloupců:") : Dim radky As Integer = Console.ReadLine
        'Console.Write("Zadejte počet sloupců:") : 
        Dim sloupce As Integer = radky
        Dim matice(radky, sloupce) As Integer
        Console.Clear()
        Dim r As Integer = 1
        Dim s As Integer = 1
        Dim i = 1
        Dim smer As _smer = _smer.right
        Dim plus As Integer = 0
        While i <= sloupce * sloupce
            Console.Clear()
            Select Case smer
                Case _smer.right
                    matice(r, s) = i
                    i += 1
                    s += 1
                    If s = radky - plus Then
                        smer = _smer.down
                    End If
                Case _smer.down
                    matice(r, s) = i
                    i += 1
                    r += 1
                    If r = radky - plus Then
                        smer = _smer.left
                    End If
                Case _smer.left
                    matice(r, s) = i
                    i += 1
                    s -= 1
                    If s = 1 + plus Then
                        smer = _smer.up
                        plus += 1
                    End If
                Case _smer.up
                    matice(r, s) = i
                    i += 1
                    r -= 1
                    If r = 1 + plus Then
                        smer = _smer.right
                    End If
            End Select
        End While
        For radek As Integer = 1 To radky
            For sloupec As Integer = 1 To sloupce
                Console.Write(CStr(matice(radek, sloupec)).PadLeft(Math.Round(Math.Log10(i * i), 0, MidpointRounding.AwayFromZero)), "0" & IIf(sloupec = sloupce, "", ","))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub


End Module
