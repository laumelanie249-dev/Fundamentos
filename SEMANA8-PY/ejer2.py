import os

def suma(a,b):
    print("\nLa suma es: ",a+b)

def resta(a,b):
    print("\nLa resta es: ",a-b)

def multi(a,b):
    print("\nLa multiplicación es: ",(a*b))

def divi(a,b):
    if b!=0:
        print("\nLa división es: ",(a/b))
    else: print("\nNo se puede dividir entre cero")

def operaciones():
    while True: 
        print("\nBienvenido al sistema de calculadora")
        print("[1]Suma")
        print("[2]Resta")
        print("[3]Multiplicación")
        print("[4]División")
        print("[5]Salir")

        op=int(input("\nSelecione una opción: "))

        a=int(input("\nIngrese el 1er número: "))
        b=int(input("\nIngrese el 2do número: "))
    
        match op:
            case 1: suma(a,b)
            case 2:resta(a,b)
            case 3: multi(a,b)
            case 4: divi(a,b)
            case _:
                print("Opción no válida. Intente de nuevo")
                continue

        conti=input("\nDesea continuar? Presione (y): ")

        if conti!="y":
            print("\nPrograma finalizado!")
            break 
        

    


operaciones()