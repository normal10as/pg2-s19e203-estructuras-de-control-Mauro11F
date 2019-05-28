Imports System

'100% - porcentaje que descontar% = porcentaje pasar a decimal y hacer calculo *

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

        Dim Unidades, PrecioUnidad, Subtotal, Descuento, Total As Single

        Console.WriteLine("Cuanto quiere llevar de Vino Tinto (unidades)?")
        Unidades = Console.ReadLine()

        Console.WriteLine("Precio unitario (Vino Tinto):")
        PrecioUnidad = Console.ReadLine()

        If Unidades >= 10 And Unidades <= 50 Then

            SubTotal = Unidades * PrecioUnidad
            'Descuento de 5% // 100% - 5% = 95% => 95%/100% = 0.95
            Descuento = (Subtotal * 5) / 100
            Total = SubTotal - Descuento

            Console.WriteLine("Subtotal: " & SubTotal)
            Console.WriteLine("Descuento aplicado 5% ")
            Console.WriteLine("Monto descontado: " & Descuento)
            Console.WriteLine("Total: " & Total)

        ElseIf Unidades >= 51 And Unidades <= 250 Then


            Subtotal = Unidades * PrecioUnidad
            'Descuento de 10% // 100% - 10% = 90% => 90%/100% = 0.90
            Descuento = (Subtotal * 10) / 100
            Total = Subtotal - Descuento

            Console.WriteLine("Subtotal: " & Subtotal)
            Console.WriteLine("Descuento aplicado 10% ")
            Console.WriteLine("Monto descontado: " & Descuento)
            Console.WriteLine("Total: " & Total)

        ElseIf Unidades >= 251 Then


            Subtotal = Unidades * PrecioUnidad
            'Descuento de 20% // 100% - 20% = 80% => 80%/100% = 0.80
            Descuento = (Subtotal * 20) / 100
            Total = Subtotal - Descuento

            Console.WriteLine("Subtotal: " & Subtotal)
            Console.WriteLine("Descuento aplicado 20% ")
            Console.WriteLine("Monto descontado: " & Descuento)
            Console.WriteLine("Total: " & Total)

        Else
            Console.WriteLine("GRATIS")
        End If

    End Sub
End Module
