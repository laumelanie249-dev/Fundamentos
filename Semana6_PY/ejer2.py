sumaI=sumaP=0
while True:
    num=int(input("Ingrese un número positivo (0 salir): "))

    if num<0: 
        print("Número invalido. Ingrese número positivo")
        continue
    if(num==0):
        break 

    if num%2==0:
        sumaP+=num
    else:
        sumaI+=num

    print("\nSuma de pares: ",sumaP)
    print("Suma de impares: ",sumaI)