Module Module1
    Dim rand As New Random
    Sub Main()
        Console.Write("Zadejte délku náhodně vygenerovaného pole čísel: ")
        Dim delka As Integer = Console.ReadLine()
        Dim pole(delka) As Integer
        For i As Integer = 0 To delka - 1
            pole(i) = rand.Next(0, delka * 10)
        Next
        Console.WriteLine(vypsatpole(pole))
        Console.WriteLine(vypsatpole(SelectSort(pole)))
        Console.WriteLine(vypsatpole(InsertSort(pole)))
        Console.WriteLine(vypsatpole(BubbleSort(pole)))
    End Sub

    Function SelectSort(vstup() As Integer) As Integer()

    End Function

    Function InsertSort(vstup() As Integer) As Integer()

    End Function

    Function BubbleSort(vstup() As Integer) As Integer()

    End Function

    Function vypsatpole(vstup() As Integer) As String
        Return String.Join(",", vstup)
    End Function

End Module
