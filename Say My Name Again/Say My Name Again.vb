'Jacob Horsley
'Spring 2025
'RCET 2265
'SayMyName
'URL: https://github.com/horsjaco117/Say-My-Name-Again

Option Explicit On
Option Strict On

Module sayMyNameAgain
    Sub Main()

        Dim userInput As String

        Console.WriteLine("What is your Name?") 'Ask name
        Console.WriteLine()

        userInput = Console.ReadLine() 'give it name

        If userInput = "Jacob" Then 'Curated responses only for special names
            Console.WriteLine()
            Console.WriteLine("Hello There Handsome!")
        ElseIf userInput = "Emily" Then 'Response for Emily
            Console.WriteLine()
            Console.WriteLine("How's it going Emily?")
        ElseIf userInput = "Joe" Then 'Response for Joe
            Console.WriteLine()
            Console.WriteLine("Joe Mama!!!")
        Else
            Console.WriteLine() 'Any other name will show generic salutation
            Console.WriteLine("Hello there " & userInput & ".")
        End If

    End Sub

End Module
