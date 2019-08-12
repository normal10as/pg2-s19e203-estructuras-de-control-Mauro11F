Imports System

'Crear un proyecto y un módulo “ConversionMedidas”, 
'para resolver con Case: Elabore un algoritmo que 
'permita hacer conversiones de equivalencias entre 
'metros, centímetros, yardas, pies y pulgadas:  

'• Presentar un menú y preguntar que unidad de medida desea 
'convertir(pie, pulgadas, yarda, pulgada, cms y metros), 
'el valor a convertir y después mostrar las equivalencias.  

'• Utilizar únicamente las equivalencias conocidas: 
'1 pie = 12 pulgadas, 1 yarda = 3 pies, 1 pulgada = 2.54 cm, 1 metro = 100 cm. 

'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a 
'convertir, luego imprimir la equivalencia en centímetros, pies, yardas y pulgadas

Module ConversionMedidas
    Private PieAPulgadas As Byte = 12
    Private YardaAPies As Byte = 3
    Private PulgadaACentimetros As Single = 2.54
    Private MetroACentimetros As Byte = 100

    Enum Medidas
        pies = 1
        pulgadas
        yardas
        centimetros
        metros
    End Enum

    Sub Main(args As String())

        Dim numero As Single
        Dim medida As Byte

        'ejemplo 5 pulgadas
        Console.WriteLine("Ingrese el tipo de medida: ")
        TipoMedida()
        medida = Console.ReadLine()
        Console.WriteLine("Ingrese el valor a convertir: ")
        numero = Console.ReadLine()

        MedidaConvertida(numero, medida)
    End Sub

    Sub TipoMedida()

        Console.WriteLine("{0} - {1}", Medidas.pies.GetHashCode, Medidas.pies.ToString())
        Console.WriteLine("{0} - {1}", Medidas.pulgadas.GetHashCode, Medidas.pulgadas.ToString())
        Console.WriteLine("{0} - {1}", Medidas.yardas.GetHashCode, Medidas.yardas.ToString())
        Console.WriteLine("{0} - {1}", Medidas.centimetros.GetHashCode, Medidas.centimetros.ToString())
        Console.WriteLine("{0} - {1}", Medidas.metros.GetHashCode, Medidas.metros.ToString())

    End Sub

    Function MedidaConvertida(valor As Single, medida As Byte) As Single
        '1 pie = 12 pulgadas, 1 yarda = 3 pies, 1 pulgada = 2.54 cm, 1 metro = 100 cm.
        'Ejemplo 5 pulgadas
        Select Case medida

            Case 1
                'de pie a pulgadas a yardas a centimetros a metros
                Console.WriteLine("Equivalencias: {0} pies son {1} pulgadas ; {2} yardas ; {3} centimetros y {4} metros",
                                  valor, valor * PieAPulgadas, valor / YardaAPies, (valor * PieAPulgadas) * PulgadaACentimetros, ((valor * PieAPulgadas) * PulgadaACentimetros) / MetroACentimetros)
            Case 2
                'de pulgadas a centimetros a metros a pies a yardas
                Console.WriteLine("Equivalencias: {0} pulgadas son {1} centimetros ; {2} metros ; {3} pies y {4} yardas",
                                  valor, valor * PulgadaACentimetros, (valor * PulgadaACentimetros) / MetroACentimetros, valor / PieAPulgadas, (valor / PieAPulgadas) / YardaAPies)
            Case 3
                'de yardas a pie a pulgadas a centimwtros a metros
                Console.WriteLine("Equivalencias: {0} yardas son {1} pies ; {2} pulgadas ; {3} centimetros y {4} metros",
                                  valor, valor * YardaAPies, (valor * YardaAPies) * PieAPulgadas, ((valor * YardaAPies) * PieAPulgadas) * PulgadaACentimetros, (((valor * YardaAPies) * PieAPulgadas) * PulgadaACentimetros) / MetroACentimetros)
            Case 4
                'de centimetros a metros a pulgadas a pie a yardas
                Console.WriteLine("Equivalencias: {0} centimetros son {1} metros ; {2} pulgadas ; {3} pies y {4} yardas",
                                  valor, valor / MetroACentimetros, valor / PulgadaACentimetros, (valor / PulgadaACentimetros) / PieAPulgadas, ((valor / PulgadaACentimetros) / PieAPulgadas) / YardaAPies)
            Case 5
                'metros a centimetros a pulgadas a pies a yardas
                Console.WriteLine("Equivalencias: {0} metros son {1} centimetros ; {2} pulgadas ; {3} pies y {4} yardas",
                                  valor, valor * MetroACentimetros, (valor * MetroACentimetros) / PulgadaACentimetros, ((valor * MetroACentimetros) / PulgadaACentimetros) / PieAPulgadas, (((valor * MetroACentimetros) / PulgadaACentimetros) / PieAPulgadas) / YardaAPies)
            Case Else
                Console.WriteLine("No pue, nada que ver lo que pones (tipo de medida incorrecta)")
        End Select
    End Function

End Module
