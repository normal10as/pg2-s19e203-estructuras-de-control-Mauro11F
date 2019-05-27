Imports System

'Crear un proyecto y un módulo “Menor” para resolver 
'con If: ingresar tres valores y mostrar el menor

Module Menor

    Sub Main(args As String())

        Dim A, B, C As Single

        Console.WriteLine("ingrese un numero: ")
        A = Console.ReadLine()

        Console.WriteLine("ingrese un segundo numero: ")
        B = Console.ReadLine()

        Console.WriteLine("ingrese un tercer numero: ")
        C = Console.ReadLine()

        If A < B And A < C Then

            Console.WriteLine("El primer numero ingresado en menor: " & A)

        ElseIf B < A And B < C Then

            Console.WriteLine("El segundo numero ingresado en menor: " & B)

        ElseIf C < A And C < B Then

            Console.WriteLine("El tercer numero ingresado en menor: " & C)

        Else
            Console.WriteLine("Hay numeros menores ingresados que son iguales: " & A & "," & B & "," & C)
        End If

    End Sub
End Module
