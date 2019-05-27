Imports System

'Crear un proyecto y un módulo “Venta” para 
'resolver con If: ingresar dos valores relacionados 
'a un producto en venta: cantidad y precio unitario. 
'Si la cantidad es entre a 10 y 50 el producto recibe un 
'descuento de 5%, si es entre 51 y 250 el descuento es 
'del 10% y si es 251 o más el descuento es del 20%. Informar 
'subtotal(cantidad por precio unitario), porcentaje de 
'descuento aplicado, monto descontado y el total (subtotal – monto descontado)

Module Venta

    Sub Main(args As String())

        Dim Unidades, PrecioUnidad As Single

        Console.WriteLine("Cuanto quiere llevar de Vino Tinto (unidades)?")
        Unidades = Console.ReadLine()

        Console.WriteLine("Cuanto quiere llevar de Vino Tinto (unidades)?")
        PrecioUnidad = Console.ReadLine()

        If Unidades >= 10 And Unidades <= 50 Then




        End If


    End Sub
End Module
