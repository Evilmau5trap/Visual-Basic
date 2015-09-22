Module Module1
	
	Sub Main()
	
		Dim myValue As Date = Now()
		'Console.WriteLine(myValue.ToShortDateString())
		'Console.WriteLine(myValue.ToShortTimeString())
		'Console.WriteLine(myValue.AddDays(3).ToShortDateString())
		'Console.WriteLine(myValue.AddHours (-3).ToShortTimeString())
		'Console.WriteLine(myValue.Month)
		
		'Dim myBirthDate As New Date(1969, 12, 7)
		'Dim myBirthDate As New Date
		'myBirthDate = Date.Parse("12/7/1969")
		'Dim myBirthDate = #12/7/1969#
		
		Dim myAge = Date.Now.Subtract(myBirthDate)
		Console.WriteLine(myAge.TotalDays.ToString())
		
		'Console.WriteLine(myBirthDate)
		
		Console.ReadLine() 

	End Sub

End Module
