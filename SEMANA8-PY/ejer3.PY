dolar=3.78
euro=4.20

def convertir():
    while True:
        print("\nBIenvenido al conversor de monedas")
        print("[1]Dólares")
        print("[2]Euros")
        print("[3]Salir")

        op=int(input("\nIngrese una opción: "))

        soles=float(input("\nIngrese el monto en soles: "))

        match op: 
            case 1:
                conv_d=soles/dolar
                print("Conversión a dólares: ",round(conv_d))
            case 2:
                conv_e=soles/euro
                print("Conversión a euro: ",round(conv_e))
            case 3: 
                print("\nSaliendo del programa")
                break
            case _:
                print("\nOpción no válida")
                continue

        conti=input("\nDesea continuar? Presione (y): ")

        if conti!="y":
            print("\nPrograma finalizado!")
            break 

convertir()