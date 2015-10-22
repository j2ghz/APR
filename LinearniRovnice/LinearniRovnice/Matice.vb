Imports System.Text

Public Class matice
    Public pole()() As Decimal
    Public rozmer As Integer
    Public ReadOnly Property trojuhelnikovy_tvar() As matice
        Get
            Dim a As New matice(rozmer)
            a.pole = pole.Select(Function(x)
                                     Return x.ToArray
                                 End Function).ToArray 'kopirovani pole
            For i As Integer = 0 To rozmer - 2
                For j As Integer = i + 1 To rozmer - 1
                    For k As Integer = rozmer - 1 To 0 Step -1
                        a(j, k) = a(i, k) * a(j, i) - a(j, k) * a(i, i)
                    Next
                    Dim vysl As Decimal = a(j, 0)
                    For Each p In a.pole(j)
                        vysl = System.Numerics.BigInteger.GreatestCommonDivisor(vysl, p)
                    Next
                    If vysl > 0 Then
                        a.pole(j) = a.pole(j).Select(Function(p)
                                                         Return p / vysl
                                                     End Function).ToArray
                    End If
                Next
            Next
            Return a
        End Get
    End Property
    Default Property item(radek As Integer, sloupec As Integer) As Decimal
        Get
            Return pole(radek)(sloupec)
        End Get
        Set(value As Decimal)
            pole(radek)(sloupec) = value
        End Set
    End Property

    Shared Operator +(a As matice, b As matice) As matice
        Dim result As New matice(a.rozmer)
        For x As Integer = 0 To a.rozmer - 1
            For y As Integer = 0 To a.rozmer - 1
                result.pole(x)(y) = a.pole(x)(y) + b.pole(x)(y)
            Next
        Next
        Return (result)
    End Operator

    Shared Operator *(a As matice, k As Decimal) As matice
        Dim result As New matice(a.rozmer)
        For x As Integer = 0 To a.rozmer - 1
            For y As Integer = 0 To a.rozmer - 1
                result.pole(x)(y) = a.pole(x)(y) * k
            Next
        Next
        Return (result)
    End Operator

    Shared Operator *(a As matice, b As matice)
        Dim result As New matice(a.rozmer)
        For x As Integer = 0 To a.rozmer - 1
            For y As Integer = 0 To a.rozmer - 1
                result.pole(x)(y) = vynasob_radek_sloupec(a.radek(x), b.sloupec(y))
            Next
        Next
        Return (result)
    End Operator
    Shared Function vynasob_radek_sloupec(radek As IEnumerable(Of Decimal), sloupec As IEnumerable(Of Decimal)) As Decimal
        Dim result As Decimal = 0
        For i As Integer = 0 To radek.Count - 1
            result += radek(i) * sloupec(i)
        Next
        Return (result)
    End Function
    Sub New(_rozmer As Integer)
        rozmer = _rozmer
        Dim p(rozmer - 1)() As Decimal
        For i As Integer = 0 To rozmer - 1
            Dim po(rozmer - 1) As Decimal
            p(i) = po
        Next
        pole = p
    End Sub
    Sub New(_rozmer As Integer, random As Random)
        rozmer = _rozmer
        Dim p(rozmer - 1)() As Decimal
        For x As Integer = 0 To rozmer - 1
            Dim po(rozmer - 1) As Decimal
            For y As Integer = 0 To rozmer - 1
                po(y) = random.Next(10)
            Next
            p(x) = po
        Next
        pole = p
    End Sub

    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.AppendLine()
        For x As Integer = 0 To rozmer - 1
            sb.AppendLine(String.Join(Constants.vbTab, pole(x)))
        Next
        Return sb.ToString()
    End Function

    Public Property radek(x As Integer) As IEnumerable(Of Decimal)
        Get
            Return (pole(x))
        End Get
        Set(v As IEnumerable(Of Decimal))
            pole(x) = v
        End Set
    End Property

    Public ReadOnly Property radek(x As Integer, k As Decimal) As IEnumerable(Of Decimal)
        Get
            Return pole(x).Select(Function(a As Decimal)
                                      Return a * k
                                  End Function)
        End Get
    End Property

    Public ReadOnly Iterator Property sloupec(x As Integer) As IEnumerable(Of Decimal)
        Get
            For i As Integer = 0 To rozmer - 1
                Yield pole(i)(x)
            Next
        End Get
    End Property
End Class
Public Class rovnice
    Inherits matice
    Sub New(n As Integer)
        MyBase.New(n)
        Dim p(rozmer - 1)() As Decimal
        For i As Integer = 0 To rozmer - 1
            Dim po(rozmer - 1 + 1) As Decimal '+1 pro vysledky
            p(i) = po
        Next
        pole = p
    End Sub
    Public Shadows ReadOnly Property trojuhelnikovy_tvar() As rovnice
        Get
            Dim a As New rovnice(rozmer)
            a.pole = pole.Select(Function(x)
                                     Return x.ToArray
                                 End Function).ToArray 'kopirovani pole
            For i As Integer = 0 To rozmer - 2
                For j As Integer = i + 1 To rozmer - 1
                    For k As Integer = rozmer To 0 Step -1
                        a(j, k) = a(i, k) * a(j, i) - a(j, k) * a(i, i)
                    Next
                    Dim vysl As Decimal = a(j, 0)
                    For Each p In a.pole(j)
                        vysl = System.Numerics.BigInteger.GreatestCommonDivisor(vysl, p)
                    Next
                    If vysl > 0 Then
                        a.pole(j) = a.pole(j).Select(Function(p)
                                                         Return p / vysl
                                                     End Function).ToArray
                    End If
                Next
            Next
            Return a
        End Get
    End Property
End Class