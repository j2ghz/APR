Imports System.Security.Policy
Imports Strom

Module Module1

    Sub Main()
        Console.WriteLine("Zadavejte cisla do stromu, 0 pro konec")
        Dim strom As New Strom
        Dim a = console.ReadLine()
        While a <> 0
            strom.Pridat(a)
            a = console.ReadLine()
        End While
       Console.Write("Vyhledat: ")
        Dim x As Integer = Console.ReadLine()

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
        select Case uzel.Hodnota
            Case <hodnota
                If uzel.Levy Is Nothing then
                    uzel.Levy = new Uzel(hodnota)
                    Else
                    Pridat(hodnota,uzel.Levy)
                End If
                Case > hodnota
                If uzel.pravy Is Nothing then
                    uzel.pravy = new Uzel(hodnota)
                    Else
                    Pridat(hodnota,uzel.pravy)
                End If
        End Select
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
