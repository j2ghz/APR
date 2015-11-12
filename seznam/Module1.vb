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

        vypis(prvni)

        ted = prvni
        For i As Integer = 1 To 10
            Dim a As New prvek(0)
            a.dalsi = ted.dalsi
            ted.dalsi = a
            ted = ted.dalsi.dalsi
        Next

        vypis(prvni)

        ted = prvni
        While ted IsNot Nothing AndAlso ted.dalsi IsNot Nothing
            If ted.dalsi.hodnota = 0 Then
                ted.dalsi = ted.dalsi.dalsi
            End If
            ted = ted.dalsi
        End While

        vypis(prvni)

        Dim b As New prvek(0)
        b.dalsi = prvni
        prvni = b

        vypis(prvni)

        ted = prvni
        While ted.dalsi IsNot Nothing
            ted = ted.dalsi
        End While
        Dim c As New prvek(121)
        ted.dalsi = c

        vypis(prvni)

        prvni = prvni.dalsi

        vypis(prvni)

        ted = prvni
        While ted.dalsi.dalsi IsNot Nothing
            ted = ted.dalsi
        End While
        ted.dalsi = Nothing

        vypis(prvni)

        Console.ReadKey()
    End Sub
    Sub vypis(prvni As prvek)
        Dim ted As prvek = prvni
        While IsNothing(ted) = False
            Console.Write(ted.hodnota & ", ")
            ted = ted.dalsi
        End While
        Console.WriteLine()
        Console.WriteLine("=================================================================")
    End Sub
End Module
Public Class prvek
    Public hodnota As Integer
    Public dalsi As prvek
    Sub New(h As Integer)
        hodnota = h
    End Sub
End Class