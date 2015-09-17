Imports System.Text
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Console.WriteLine("Zadávejte pouze čísla")
        Dim cislo1 As New Stack(Of String)(Regex.Split(Console.ReadLine, "").Where(Function(s)
                                                                                       Return Not String.IsNullOrWhiteSpace(s)
                                                                                   End Function))
        Dim cislo2 As New Stack(Of String)(Regex.Split(Console.ReadLine, "").Where(Function(s)
                                                                                       Return Not String.IsNullOrWhiteSpace(s)
                                                                                   End Function))
        Dim vysledek As New StringBuilder
        Dim prebytek As Byte = 0
        While (Not cislo1.Count = 0 Or Not cislo2.Count = 0) Or Not prebytek = 0
            If Not cislo1.Count = 0 Then prebytek += cislo1.Pop
            If Not cislo2.Count = 0 Then prebytek += cislo2.Pop
            Dim x = prebytek
            prebytek = 0
            While x > 9
                x -= 10
                prebytek += 1
            End While
            vysledek.Append(x)
        End While
        Console.WriteLine(New String(vysledek.ToString.ToCharArray.Reverse.ToArray))
        Console.ReadKey()
    End Sub

End Module
