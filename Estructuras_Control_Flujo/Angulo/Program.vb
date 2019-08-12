Imports System

Module Angulo

    Sub Main(args As String())

        Dim AnguloIngresado As Short

        Console.WriteLine("Ingrese el angulo: ")
        AnguloIngresado = Console.ReadLine()

        Select Case AnguloIngresado
            Case Is <= 0
                Console.WriteLine("Error: Angulo igual a cero o menor")
            Case Is < 90
                Console.WriteLine("Angulo Agudo")
            Case 90
                Console.WriteLine("Angulo Recto")
            Case 90 To 180
                Console.WriteLine("Angulo Obtuso")
            Case 180
                Console.WriteLine("Angulo Llano")
            Case 180 To 360
                Console.WriteLine("Angulo Concavo")
            Case Else
                Console.WriteLine("Error: Angulo Mayor a 360")
        End Select
    End Sub
End Module
