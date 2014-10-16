Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Console.Write("Zadejde číslo pro převod z do dvojkove, nebo d pro prevod z dvojkove: ")
        Dim tmp As String = Console.ReadLine
        Select Case IsNumeric(tmp)
            Case True
                Console.WriteLine(Convert.ToString(CInt(tmp), 2))
            Case False
                Console.Write("Zadejte číslo v dvojkove: ")
                tmp = Console.ReadLine
                Console.WriteLine(Convert.ToInt64(tmp, 2))
        End Select
        Console.ReadKey()

    End Sub

End Module
