Module Module1
	Sub Main()
		Console.WriteLine("Prvky oddělujte mezerami pak enter")
		dim pole() = console.readline().split(" ")
		for i = 0 to pole.length-2
			if pole(i) > pole(i+1) then
				console.writeline("Neni seřazena")
				exit sub
			end if
		next
		console.writeline("Je seřazena")
	End Sub
End Module