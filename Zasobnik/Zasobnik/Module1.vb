Imports System.IO

Module Module1

    Sub Main()
        Console.Write("Zadejte cestu k souboru: ")
        Dim zas As New Zasobnik
        Dim encoding
        Using sr As New StreamReader(Path.GetFullPath(Console.ReadLine))
            While Not sr.EndOfStream
                zas.Pridat(ChrW(sr.Read()))
            End While
            encoding = sr.CurrentEncoding
        End Using
        Console.Write("Zadejte cestu k souboru pro ulozeni: ")
        Using sw As New StreamWriter(Path.GetFullPath(Console.ReadLine), False, encoding)
            While Not IsNothing(zas.Prvni)
                sw.Write(zas.Odebrat)
            End While
        End Using
    End Sub

End Module
Class Prvek
    Public Property Hodnota As Char
    Public Property Dalsi As Prvek
    Sub New(_hodnota As Char)
        Hodnota = _hodnota
    End Sub
End Class
Class Zasobnik
    Public Property Prvni As Prvek
    Public ReadOnly Property Posledni As Prvek
        Get
            Dim a As Prvek = Prvni
            While IsNothing(a.Dalsi) = False
                a = a.Dalsi
            End While
            Return a
        End Get
    End Property
    Public ReadOnly Property PredPosledni As Prvek
        Get
            Dim a As Prvek = Prvni
            While IsNothing(a.Dalsi.Dalsi) = False
                a = a.Dalsi
            End While
            Return a
        End Get
    End Property
    Public Sub Pridat(pismeno As Char)
        If IsNothing(Prvni) Then
            Prvni = New Prvek(pismeno)
        Else
            Posledni.Dalsi = New Prvek(pismeno)
        End If
    End Sub
    Public Function Odebrat() As Char
        Dim a = Posledni.Hodnota
        If Not IsNothing(Prvni.Dalsi) Then
            PredPosledni.Dalsi = Nothing
        Else
            Prvni = Nothing
        End If

        Return a
    End Function
End Class