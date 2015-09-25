Module Module1

    Sub Main()

        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car
        'Dim myOtherCar As Car = myNewCar

        'Dim myOtherCar As New Car("BMW", 2005, 30000)


        CarLot.AddToInventory(myNewCar)


        myNewCar.Make = "Oldsmobile"
        myNewCar.Model = "Cutlas Supreme"
        myNewCar.Year = 1986
        myNewCar.Color = "Silver"

        'With (myNewCar)
        '   .Make = "Olds"
        '   .Model = "Cutlas"
        '   .Year = 1986
        '   .Color = "Silver"
        'End With

        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString())

        'Console.WriteLine(determineMarketValue(myNewCar))

        'Console.WriteLine(myNewCar.determineMarketValue())

        Console.WriteLine("Before: " & myNewCar.Make)
        doByValue(myNewCar)
        Console.WriteLine("After By Value: " & myNewCar.Make)

        doByReference(myNewCar)
        Console.WriteLine("After By Reference: " & myNewCar.Make)


        Console.ReadLine()


    End Sub

    'Function determineMarketValue(ByVal myCar As Car) As Double
    '    'Super secret formula

    '    Return 100.0

    'End Function


    Sub doByValue(ByVal myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

    Sub doByReference(ByRef myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub



End Module
