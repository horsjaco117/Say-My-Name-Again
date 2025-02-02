'Jacob Horsley
'Spring 2025
'RCET 2265
'SayMyName

Option Explicit On
Option Strict On

Module Module1



    Sub Main()

        Dim userInput As String

        Console.WriteLine("What is your Name?") 'Ask name
        Console.WriteLine()

        userInput = Console.ReadLine() 'give it name

        If userInput = "Jacob" Then
            Console.WriteLine("Hello There Handsome!")
        ElseIf userInput = "Emily" Then
            Console.WriteLine("How's it going Emily?")
        ElseIf userInput = "Joe" Then
            Console.WriteLine("Joe Mama!!!")
        Else
            Console.WriteLine()
            Console.WriteLine("Hello there " & userInput)
        End If

        Console.WriteLine()



    End Sub

End Module
