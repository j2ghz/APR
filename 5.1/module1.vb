Module Module1
	Sub Main()
		Console.WriteLine("Prvky oddělujte mezerami pak enter")
		dim pole() = console.readline().split(" ")
		dim temp = pole(pole.length-1)
		for i as integer = pole.length -1 to 1 step -1
			pole(i)=pole(i-1)
		next
		pole(0) = temp
		dim sb as new system.text.stringbuilder
		for each s in pole
			sb.append(s)
			sb.append(" ")
		next
		console.writeline(sb.tostring)
	End Sub
End Module