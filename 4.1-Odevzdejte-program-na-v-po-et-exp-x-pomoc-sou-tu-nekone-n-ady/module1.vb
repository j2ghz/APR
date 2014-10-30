Module Module1
  Sub Main()
  Try
	Console.Write("Zadejte mocninu pro výpočet Eulerova čísla: ")
    Dim x as double = Cdbl(Console.readline)
    Dim e as double = 1+x
    Dim i = 3
    dim f = 2
    dim eps
	dim n = x*x
    Do
        eps=(n)/(f)
        e+=eps
        f=f*i
		x*=x
		i+=1
    Loop While eps>0.0001
	Console.writeline(e)
	Console.readkey
	Catch e as Exception
		msgbox(e.ToString,MsgBoxStyle.Critical,"ERROR " & err.number & " - " & err.description)
	end try
  End Sub
End Module
