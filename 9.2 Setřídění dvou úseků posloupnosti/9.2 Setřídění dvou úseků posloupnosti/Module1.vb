Imports System.Text

Module Module1
    Dim rnd As New Random
    Sub Main()
        Dim a As New Queue
        Dim b As New Queue
        Dim delka As Integer = rnd.Next(10, 25)
        a.Enqueue(rnd.Next(0, 5))
        For i As Integer = 0 To delka
            a.Enqueue(a(i) + rnd.Next(1, 5))
        Next
        b.Enqueue(rnd.Next(0, 5))
        For i As Integer = 0 To delka
            b.Enqueue(b(i) + rnd.Next(1, 5))
        Next
        Console.WriteLine(display(a))
        Console.WriteLine(display(b))
        Console.WriteLine(display(Sort(a, b)))
        Console.ReadKey
    End Sub

    Function display(q As Queue) As String
        Dim sb As New StringBuilder()
        For Each a In q
            sb.Append(a.ToString & " ")
        Next
        Return (sb.ToString)
    End Function

    Private Function Sort(a As Queue, b As Queue) As Queue
        Dim result As New Queue
        While a.Count > 0 AndAlso b.Count > 0
            Select Case a.Peek() - b.Peek()
                Case Is < 0
                    result.Enqueue(a.Dequeue())
                Case Else
                    result.Enqueue(b.Dequeue())
            End Select
        End While
        If a.Count > 0 AndAlso b.Count = 0 Then
            While a.Count > 0
                result.Enqueue(a.Dequeue)
            End While
        ElseIf b.Count > 0 AndAlso a.Count = 0 Then
            While b.Count > 0
                result.Enqueue(b.Dequeue)
            End While
        Else
            Throw New Exception("Při skládání došlo k chybě, aspoň jedna fronta nebyla nulové délky, i když měla. Tahle chyba by neměla nastat. Nikdy.")
        End If
        Return result
    End Function

End Module
