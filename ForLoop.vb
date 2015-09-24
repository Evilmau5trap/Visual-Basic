Module Module1

    Sub Main()

        Dim i = 0
        For i = 1 To 10
            'Console.WriteLine(index)

            If (i = 7) Then
                Console.WriteLine("Found Seven!")
                Exit For
            End If

        Next

        For i = 5 To 10 Step 2
            Console.WriteLine()

        Next

        Console.ReadLine()



    End Sub

End Module
