print("Ejemplo con arreglos unidimensionales")
can=int(input("Digite cantidad de edades:  "))
edades=[]
for i in range(can):
  edad=int(input(f"Edad ingresada en la posición {i}: "))
  edades.append(edad)
print("Lista de edades ingresadas")
for e in edades:
  print(e)
#ordenar por método burbuja
print("Lista ordenada con método de burbuja")
for i in range(can):
  for j in range(i+1, can):
    if(edades[i]>edades[j]):
      aux=edades[i]
      edades[i]=edades[j]
      edades[j]=aux
print("Lista de edades ordenadas(ascendente): ")
for e in edades:
  print(e)
#insertar edad
edades1=edades.copy() #copiar matriz edades a edades1
for e in edades1:
  print(e)
posi=int(input("Digite posición para insertar la nueva edad: "))
if posi<len(edades1): #si la posición es menor que la cantidad de edades
  edad=int(input("Digite la edad a insertar: "))
  edades1.insert(posi,edad)
for e in edades1:
  print(e)
