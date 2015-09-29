Module Module1

    Sub Main()
        Dim userName As String

        Console.WriteLine("Welcome To Luck Or No Luck!" & vbCrLf)

        Console.Write("What Is The Name Of Our First Constestant? : ")
        userName = Console.ReadLine()

        Console.WriteLine("Welcome " & userName & " To Luck Or No Luck!" & vbCrLf)
        Console.Write("What Door Would You Like To Choose? Door 1, Door 2, or Door 3?" & vbCrLf)

        Dim userValue As String = Console.ReadLine()

        If userValue = "1" Then
            Console.WriteLine("You Just Won A $10 Gift Card To McDonalds! Congrats!")
            Console.ReadLine()
        ElseIf userValue = "2" Then
            Console.WriteLine("You Just Won A New Custom Built 2015 Ferrari 458 Spider With A 562-HP V-8 Engine! Congrats!")
            Console.ReadLine()
        ElseIf userValue = "3" Then
            Console.WriteLine("You Just Won A Brand New Apple IPad Air 2! Congrats!")
            Console.ReadLine()
        ElseIf userValue = "4" Then
            Console.WriteLine("Oh My! You Just Said The Hidden 4th Door! This Door Grants You The $10 Gift Card To McDonalds, The New Custom Built 201 Ferrari 458 Spider, And The Brand New Apple IPad Air 2! Congrats!")
            Console.ReadLine()
        Else
            Console.WriteLine("Sorry But That Is Not An Answer! Thanks For Playing!")
            Console.ReadLine()
        End If

    End Sub

End Module
