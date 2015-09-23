Module Module1

	Sub Main()
	
		Dim x = 0
		Dim y = 0
		Dim a = 0
		Dim b = 0
	
		' Assignment Operator
		x = 3
		
		' Addition Operator
		x = 3 + 4
		
		' Subtraction Operator
		x = 4 - 3
		
		' Multiplication Operator
		x = 10 * 5
		
		' Division Operator
		x = 10 / 5

		' Equality Operator 
		If x = y Then
			'Stuff goes here
		EndIf
		
		'Greater than Operator
		If x > y Then
			'Stuff goes here 
		EndIf
		
		'Less than Operator
		if x < y Then
			'Stuff goes here
		EndIf
		
		'Greater than or equal to operator
		If x >= y Then
			'Stuff goes here
		EndIf
		
		'Less than or equal to operator
		If x <= y Then
			'Stuff goes here
		EndIf
		
		'Conditional OR operator
		if x > y and a > b Then
			'Stuff goes here
		EndIf
		
		'Conditional AND operator
		if x > y and a > b Then
			'Stuff goes here
		EndIf
		
		'Member access and Method Invocation
		Console.WriteLine("Hi!")
		
		
		
	End Sub

End Module
