class Triangulo:
    @staticmethod
    def area()->None:
        b=int(input("Ingresa la base: "))
        h=int(input("Ingrese la altura: "))
        print("\nÁrea: ",((b+h)/2)) 

    @staticmethod
    def perimetro()->None:
        l1=int(input("Ingrese lado 1: "))
        l2=int(input("Ingrese lado 2: "))
        l3=int(input("Ingrese lado 3: "))
        print("\nPerímetro: ",(l1+l2+l3))