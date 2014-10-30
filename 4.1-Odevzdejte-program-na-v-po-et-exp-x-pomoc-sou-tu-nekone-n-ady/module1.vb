Module Module1
  Sub Main()
    Dim x as double = Cdbl(Console.readline)
    Dim e as double = 1+x
    Dim i = 2
    dim f = 2
    dim eps
    Do
        eps=(x^i)/(f)
        e+=eps
        f=f*i
        i+=1
        Console.writeline(e)
    Loop while eps>0.0001
  End Sub
End Module
