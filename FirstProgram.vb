Module Module1

    Sub Main()

        Dim userName As String
        Dim userNumber1 As Double
        Dim userNumber2 As Double
        Dim numberTotal As Double

        Console.WriteLine("Hello and Welcome to your first Visual Basic Console Application" & vbCrLf)

        Console.Write("To whom do I have the pleasure of talking to: ")
        userName = Console.ReadLine()

        Console.WriteLine("Hello " & userName & " and Welcome to your first VB app." & vbCrLf)
        Console.WriteLine("Today you will be asked to pick two numbers to be added, subtracted, multiply, and divided" & vbCrLf)

        Console.Write("What is your first number? : ")
        userNumber1 = Console.ReadLine()

        Console.Write("What is your second number? : ")
        userNumber2 = Console.ReadLine()

        Console.WriteLine(vbCrLf)
        Console.WriteLine("Your first number is: " & userNumber1)

        Console.WriteLine("Your second number is: " & userNumber2)

        numberTotal = userNumber1 + userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " + " & userNumber2 & " = " & numberTotal)

        numberTotal = userNumber1 - userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " - " & userNumber2 & " = " & numberTotal)

        numberTotal = userNumber1 * userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " * " & userNumber2 & " = " & numberTotal)

        numberTotal = userNumber1 / userNumber2

        Console.WriteLine(vbCrLf)
        Console.WriteLine(userNumber1 & " / " & userNumber2 & " = " & numberTotal)
        Console.ReadLine()

    End Sub

End Module
