Imports System

'Crear un proyecto y un módulo “Tercero” 
'para resolver con If: ingresar 5 valores 
'enteros e informar cual es el mayor por su 
'posición de ingreso, por ejemplo, dado los 
'siguientes valores :   3,7,12,5,9 informar: “El tercer número es el mayor valor”

Module Tercero

    Sub Main(args As String())

        Dim A, B, C, D, E As Integer

        Console.WriteLine("Ingrese un numero: ")
        A = Console.ReadLine()

        Console.WriteLine("Ingrese un Segundo numero: ")
        B = Console.ReadLine()

        Console.WriteLine("Ingrese un Tercer numero: ")
        C = Console.ReadLine()

        Console.WriteLine("Ingrese un Cuarto numero: ")
        D = Console.ReadLine()

        Console.WriteLine("Ingrese un Quinto numero: ")
        E = Console.ReadLine()

        If A > B And A > C And A > D And A > E Then

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL Primer numero ingresado es el mayor: ", A, B, C, D, E)

        ElseIf B > A And B > C And B > D And B > E Then

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL Segundo numero ingresado es el mayor: ", A, B, C, D, E)

        ElseIf C > B And C > A And C > D And C > E Then

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL Tercero numero ingresado es el mayor: ", A, B, C, D, E)

        ElseIf D > B And D > C And D > A And D > E Then

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL Cuarto numero ingresado es el mayor: ", A, B, C, D, E)

        ElseIf E > B And E > C And E > D And E > A Then

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL Quinto numero ingresado es el mayor: ", A, B, C, D, E)

        Else

            Console.WriteLine("Dada la lista ({0},{1},{2},{3},{4}) EL numero Mayor se repite: ", A, B, C, D, E)

        End If
    End Sub
End Module
