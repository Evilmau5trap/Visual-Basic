Module Module1

    Sub Main()
        'Console.WriteLine("Please Type Something and press Enter")
        'Dim uservalue As String

        'userValue = Console.ReadLine()
        'Console.WriteLine("You types: " & userValue
        'Console.ReadLine()

        Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3")

        Dim userValue As String = Console.ReadLine

        If userValue = "1" Then
            Console.WriteLine("You won a new car!")
            Console.ReadLine()
        ElseIf userValue = "2" Then
            Console.WriteLine("You won a new boat!")
            Console.ReadLine()
        ElseIf userValue = "3" Then
            Console.WriteLine("You won a new cat!")
        Else
            Console.WriteLine("Sorry, we did not understand your response. You lose!")
            Console.ReadLine()
        End If
    End Sub

End Module
