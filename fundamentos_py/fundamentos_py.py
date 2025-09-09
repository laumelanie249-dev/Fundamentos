def ejer1():
    nom=input("Ingrese su nombre: ")
    carrera=input("Ingrese su carrera: ")
    print(f"{nom}, bienvenida al curso de Fundamentos de Algoritmos de la carrera {carrera}")

def ejer2():           
    print("\"Melanie\"")

def ejer3():
    num1=int(input("Ingrese número 1: "))
    num2=int(input("Ingrese número 2: "))

    print("Suma: ",(num1+num2))
    print("Resta: ",(num1-num2))
    print("Multiplicación: ",(num1*num2))
    print("División: ",(num1/num2))

import math #importando librería math

def ejer4():
    num=float(input("Ingrese número decimal: "))

    raiz=math.sqrt(num)
    redo=round(num,2)
    cubo=math.pow(num,3)
    cubica=num**(1/3)

    print("Raíz cuadrada: ",raiz)
    print("Redondeado: ",redo)
    print("Al cubo: ",cubo)
    print("Raíz cúbica: ",cubica)

ejer4()
