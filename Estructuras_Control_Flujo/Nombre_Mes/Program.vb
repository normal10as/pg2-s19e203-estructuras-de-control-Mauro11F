Imports System

'Crear un proyecto y un módulo “NombreMes” para resolver con Case. 
'Crear una enumeración para los meses del año. Ingresar un valor 
'numérico y mostrar a que mes corresponde. Si el valor es inválido 
'mostrar el mensaje correspondiente

Module NombreMes

    Enum Meses
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
            Case Meses.Enero
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Enero)
            Case Meses.Febrero
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Febrero)
            Case Meses.Marzo
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Marzo)
            Case Meses.Abril
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Abril)
            Case Meses.Mayo
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Mayo)
            Case Meses.Junio
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Junio)
            Case Meses.Julio
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Julio)
            Case Meses.Agosto
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Agosto)
            Case Meses.Septiembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Septiembre)
            Case Meses.Octubre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Octubre)
            Case Meses.Noviembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Noviembre)
            Case Meses.Diciembre
                Console.WriteLine("El numero de mes ingresado es: {0} y corresponde al mes de {1} ", mesingresado, Meses.Diciembre)
            Case Else
                Console.WriteLine("No existe tal numero de MES")


        End Select


    End Sub
End Module
