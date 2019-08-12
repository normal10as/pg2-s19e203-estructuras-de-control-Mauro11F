Imports System

'Crear un proyecto y un módulo “Venta” para resolver 
'con Case: ingresar dos valores relacionados a un producto 
'en venta: cantidad y precio unitario. Si la cantidad es 
'entre a 10 y 50 el producto recibe un descuento de 5%, si 
'es entre 51 y 250 el descuento es del 10% y si es 251 o más 
'el descuento es del 20%. Informar subtotal (cantidad por precio unitario), 
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto descontado).

Module Venta2_0

    Sub Main(args As String())

        Dim cantidad, precio, descuento, SubTotal, total As Double
        Console.WriteLine("Ingrese la cantidad de tomate que desea comprar: ")
        cantidad = Console.ReadLine()

        Console.WriteLine("Ingrese el precio a pagar por unidad: ")
        precio = Console.ReadLine()

        Select Case cantidad
            Case 10 To 50
                descuento = 0.05
            Case 51 To 250
                descuento = 0.1
            Case Is > 250
                descuento = 0.2
            Case Is < 10
                Console.WriteLine("La compra no tendra ningun descuento")
                descuento = 0
        End Select

        SubTotal = cantidad * precio
        Console.WriteLine("Subtotal de: " & SubTotal)

        Console.WriteLine("Porcentaje descontado {0}% y Monto descontado {1}", descuento * 100, SubTotal * descuento)
        total = SubTotal - (SubTotal * descuento)

        Console.WriteLine("Total a pagar: " & total)

    End Sub
End Module
