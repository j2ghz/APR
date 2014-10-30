Module Module1
  Sub Main()
    Dim x as double = Cdbl(Console.readline)
    Dim e as double = 1+x
    Dim i = 2
    dim f = 2
    While true
        e+=(x^i)/(f)
        f=f*i
        i+=1
        Console.writeline(e)
    End while
  End Sub
End Module
