Imports System.Runtime.CompilerServices
Module Module1
    Dim n, k, d As Integer
    Dim pole() As Integer
    Sub Main()
        Dim temp = Console.ReadLine.Split(" ")
        n = temp(0) : k = temp(1) : d = temp(2)
        pole = Console.ReadLine.Split(" ").convert
        For i = 1 To n

        Next
    End Sub
    <Extension()>
    Function convert(pole As String()) As Integer()
        Dim r(pole.Length) As Integer
        For i = 0 To pole.Length - 1
            r(i) = CInt(pole(i))
        Next
        Return r
    End Function
End Module
