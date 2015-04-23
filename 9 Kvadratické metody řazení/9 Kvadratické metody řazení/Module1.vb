Module Module1
    Dim rand As New Random
    Sub Main()
        'Console.Write("Zadejte délku náhodně vygenerovaného pole čísel: ")
        'Dim delka As Integer = Console.ReadLine()
        'Dim pole(delka) As Integer
        'For i As Integer = 0 To delka - 1
        '    pole(i) = rand.Next(0, delka * 10)
        'Next
        Dim pole() = {6, 8, 7, 9, 3, 4, 5, 2, 1}
        Console.WriteLine(vypsatpole(pole))
        Console.WriteLine(vypsatpole(SelectSort(pole)))
        pole = {6, 8, 7, 9, 3, 4, 5, 2, 1}
        Console.WriteLine(vypsatpole(InsertSort(pole)))
        pole = {6, 8, 7, 9, 3, 4, 5, 2, 1}
        Console.WriteLine(vypsatpole(BubbleSort(pole)))
        pole = {6, 8, 7, 9, 3, 4, 5, 2, 1}
        Array.Sort(pole)
        Console.WriteLine(vypsatpole(pole))
        Console.ReadKey()
    End Sub

    Function SelectSort(ByVal vstup() As Integer) As Integer()
        For i As Integer = 0 To vstup.Count - 1
            Dim k As Integer = i
            For j As Integer = i + 1 To vstup.Count - 1
                If vstup(j) < vstup(k) Then k = j
            Next
            If k > i Then
                Dim x = vstup(k)
                vstup(k) = vstup(i)
                vstup(i) = x
            End If
        Next
        Return vstup
    End Function

    Function InsertSort(ByVal vstup() As Integer) As Integer()
        Dim i, j As Integer
        For i = 1 To vstup.Length - 1
            Dim x As Integer = vstup(i)
            Dim k As Integer = 0
            j = i - 1
            While (j >= 0 And k <> 1)
                If (x < vstup(j)) Then
                    vstup(j + 1) = vstup(j)
                    j -= 1
                    vstup(j + 1) = x
                Else : k = 1
                End If
            End While
        Next
        Return vstup
    End Function

    Function BubbleSort(ByVal vstup() As Integer) As Integer()
        Dim nesetrideno As Boolean = True
        While nesetrideno
            nesetrideno = False
            For i = 0 To vstup.Length - 2
                If vstup(i) > vstup(i + 1) Then
                    Dim tmp = vstup(i + 1)
                    vstup(i + 1) = vstup(i)
                    vstup(i) = tmp
                    nesetrideno = True
                End If
            Next
        End While
        Return vstup
    End Function

    Function vypsatpole(ByVal vstup() As Integer) As String
        Dim sb As String = ""
        For Each cislo As Integer In vstup
            sb &= cislo & ", "
        Next
        Return sb
    End Function

End Module
