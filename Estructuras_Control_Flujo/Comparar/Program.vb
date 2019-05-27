Imports System

'Crear un proyecto y un módulo “Comparar” para resolver 
'con If: se ingresan dos valores numéricos e informar por 
'pantalla cuál es la relación entre ambos: mayor, menor o igual. 

Module Comparar

    Sub Main(args As String())

        Dim A, B As Integer

        Console.WriteLine("Ingrese un numero entero: ")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese un segundo numero entero: ")
        B = Console.ReadLine()

        If A >= B Then

            If A > B Then

                Console.WriteLine("El primer numero ingresado es mayor")

            Else
                Console.WriteLine("Ambos numeros son iguales")
            End If

        Else
            Console.WriteLine("El segundo numero ingresado es mayor")

        End If

    End Sub
End Module
