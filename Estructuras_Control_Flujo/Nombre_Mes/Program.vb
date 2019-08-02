Imports System

'Crear un proyecto y un módulo “NombreMes” para resolver con Case. 
'Crear una enumeración para los meses del año. Ingresar un valor 
'numérico y mostrar a que mes corresponde. Si el valor es inválido 
'mostrar el mensaje correspondiente

Module NombreMes

    Enum meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum

    Sub Main(args As String())

        Dim mesingresado As Byte
        Console.WriteLine("Ingrese el numero del mes")
        mesingresado = Console.ReadLine()
        Select Case mesingresado
            Case meses.Enero
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Enero)
            Case meses.Febrero
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Febrero)
            Case meses.Marzo
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Marzo)
            Case meses.Abril
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Abril)
            Case meses.Mayo
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Mayo)
            Case meses.Junio
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Junio)
            Case meses.Julio
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Julio)
            Case meses.Agosto
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Agosto)
            Case meses.Septiembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Septiembre)
            Case meses.Octubre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Octubre)
            Case meses.Noviembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Noviembre)
            Case meses.Diciembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, meses.Diciembre)
            Case Else
                Console.WriteLine("No existe tal numero de MES")


        End Select






    End Sub
End Module
