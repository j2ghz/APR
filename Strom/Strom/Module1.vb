Module Module1

    Sub Main()
        Console.WriteLine("Zadavejte cisla do stromu, 0 pro konec")
        Dim strom As New Strom
        Dim a = Console.ReadLine()
        While a <> 0
            strom.Pridat(a)
            a = Integer.Parse(Console.ReadLine())
        End While
        Console.WriteLine("===================================")
        strom.Prochazej()
        Console.WriteLine("===================================")
        Console.Write("Vyhledat: ")
        Dim x As Integer = Console.ReadLine()
        strom.Najdi(x)
        Console.ReadLine()
    End Sub

End Module
Class Strom
    Private Property Koren As Uzel
    Sub Pridat(hodnota As Integer)
        If Koren Is Nothing Then
            Koren = New Uzel(hodnota)
        Else
            Pridat(hodnota, Koren)
        End If
    End Sub

    Sub Pridat(hodnota As Integer, uzel As Uzel)
        Select Case uzel.Hodnota
            Case < hodnota
                If uzel.Levy Is Nothing Then
                    uzel.Levy = New Uzel(hodnota)
                Else
                    Pridat(hodnota, uzel.Levy)
                End If
            Case > hodnota
                If uzel.Pravy Is Nothing Then
                    uzel.Pravy = New Uzel(hodnota)
                Else
                    Pridat(hodnota, uzel.Pravy)
                End If
        End Select
    End Sub

    Public Sub Najdi(x As Integer)
        Najdi(x, Koren)
    End Sub

    Private Sub Najdi(x As Integer, uzel As Uzel)
        If uzel Is Nothing Then
            Console.WriteLine("Nenalezeno")
        Else
            Console.WriteLine(uzel.Hodnota)
            Select Case uzel.Hodnota
                Case x
                    Console.WriteLine("Nalezeno")
                Case < x
                    Najdi(x, uzel.Levy)
                Case > x
                    Najdi(x, uzel.Pravy)
            End Select
        End If
    End Sub

    Public Sub Prochazej()
        Prochazej(Koren)
    End Sub

    Sub Prochazej(uzel As Uzel)
        If uzel IsNot Nothing Then
            Prochazej(uzel.Levy)
            Console.WriteLine(uzel.Hodnota)
            Prochazej(uzel.Pravy)
        End If
    End Sub
End Class
Class Uzel
    Public Sub New(hodnota As Integer)
        Me.Hodnota = hodnota
    End Sub
    Public Property Hodnota As Integer
    Public Property Levy As Uzel
    Public Property Pravy As Uzel
End Class
