// See https://aka.ms/new-console-template for more information
using OCP;

Console.WriteLine("Hello, World!");

//Principios SOLID
Figura figura = new Circulo { Medida = 10 };
Figura figura1 = new Cuadrado { Medida = 10 };
Figura figura2 = new Rectangulo { Medida = 10, Medida2=20 };


Console.WriteLine(figura.CalcularArea());
Console.WriteLine(figura1.CalcularArea());
Console.WriteLine(figura2.CalcularArea());


//Sin principio SOLID
CalculadoraAreas calculadora = new CalculadoraAreas();
Console.WriteLine(calculadora.CalcularArea("Cuadrado",10,0));
Console.WriteLine(calculadora.CalcularArea("Circulo",10,0));
Console.WriteLine(calculadora.CalcularArea("Rectangulo", 10, 20));


Console.Read();