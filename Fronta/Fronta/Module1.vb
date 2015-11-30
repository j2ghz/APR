Imports System.Numerics
Module Module1

    Sub Main()
        Dim fronta As New Fronta
        fronta.Pridej(0, 1, 0, 0)
        Console.Write("Zadejte pocet radku: ")
        Dim i As BigInteger = Console.ReadLine()
        While i > 0
            Dim cislo = fronta.Odeber()
            If Not cislo = 0 Then
                Console.Write(cislo.ToString() & " ")
            End If
            Dim dalsi As BigInteger = fronta.Prvni + cislo
            If dalsi = 0 Then
                fronta.Pridej(0, 0)
                Console.WriteLine()
                i += BigInteger.MinusOne
            Else
                fronta.Pridej(dalsi)
            End If
        End While
        Console.ReadKey()
    End Sub

End Module
Class Fronta
    Private Property Zacatek As Prvek
    Private Property Konec As Prvek
    Public ReadOnly Property Prvni As BigInteger
        Get
            Return Zacatek.Hodnota
        End Get
    End Property

    Dim _delka As BigInteger = 0
    Sub New()

    End Sub
    Sub Pridej(i As BigInteger)
        If _delka = 0 Then
            Dim p As New Prvek(i)
            Zacatek = p
            Konec = p
        Else
            Dim p As New Prvek(i)
            Konec.Dalsi = p
            Konec = p
        End If
        _delka += 1
    End Sub
    Sub Pridej(ParamArray prvky() As BigInteger)
        For Each prvek In prvky
            Pridej(prvek)
        Next
    End Sub
    Function Odeber() As BigInteger
        Select Case _delka
            Case 0
                Throw New Exception("Prazdna fronta!")
            Case 1
                _delka = 0
                Dim hodnota = Zacatek.Hodnota
                Zacatek = Nothing
                Konec = Nothing
                Return hodnota
            Case Else
                Dim hodnota = Zacatek.Hodnota
                Zacatek = Zacatek.Dalsi
                Return hodnota
        End Select
    End Function
End Class
Class Prvek
    Public Property Hodnota As BigInteger
    Public Property Dalsi As Prvek
    Sub New(hodnota As BigInteger)
        Me.Hodnota = hodnota
    End Sub
    Sub New(hodnota As BigInteger, dalsi As Prvek)
        Me.Hodnota = hodnota
        Me.Dalsi = dalsi
    End Sub
End Class
