Module Module1
    Sub Main()
        'lepsi by bylo pouzit v .netu uz naimplementovany LinkedList<T>
        'vytvorit
        Dim prvni As New prvek(1)
        Dim ted As prvek = prvni
        For i As Integer = 2 To 10
            Dim a As New prvek(i * i)
            ted.dalsi = a
            ted = a
        Next
        'zemnsit o jedna
        ted = prvni
        For i As Integer = 1 To 10
            ted.hodnota -= 1
            ted = ted.dalsi
        Next
        'vypsat
        ted = prvni
        For i As Integer = 1 To 10
            Console.WriteLine(ted.hodnota)
            ted = ted.dalsi
        Next
        'najit
        ted = prvni
        Console.WriteLine("zadejte cislo:")
        Dim x = Console.ReadLine
        For i As Integer = 1 To 10
            If ted.hodnota = x Then
                Console.WriteLine("cislo v seznamu je")
                Console.ReadKey()
                Exit Sub
            End If
            ted = ted.dalsi
        Next
        Console.WriteLine("neni")
        Console.ReadKey()
    End Sub
End Module
Public Class prvek
    Public hodnota As Integer
    Public dalsi As prvek
    Sub New(h As Integer)
        hodnota = h
    End Sub
End Class