Module Module1
  Sub Main()
  Try
	Console.Write("Zadejte x pro výpočet sin x: ")
    Dim x as double = Cdbl(Console.readline)
    Dim sin as double = x
    Dim i = 5
    dim f = 3
    dim eps
	dim n = x*-x
    Do
        eps=(n)/(f)
        sin+=eps
        f=f*i
		n*=x*-x
		i+=2
		console.writeline(sin)
    Loop While eps>0.0001
	Console.writeline(sin)
	Console.readkey
	Catch sin as Exception
		msgbox(sin.ToString,MsgBoxStyle.Critical,"ERROR " & err.number & " - " & err.description)
	end try
  End Sub
End Module
