num=int(input("Ingrese número de la tabla: "))

while num<=0:
    num=int(input("Número inválido: Ingrese número de la tabla: "))



i=1
print()
while i<=12:
    print(f"{num}x{i}={num*i}")
    i+=1