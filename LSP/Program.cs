// See https://aka.ms/new-console-template for more information

using LSP;

FiguraGeometrica rectangulo = new Rectangulo { Ancho = 5, Altura = 10 };
FiguraGeometrica cuadrado = new Cuadrado { Lado = 5 };

double areaRectangulo = rectangulo.CalcularArea(); // Esperado: 50, Actual: 25
double areaCuadrado = cuadrado.CalcularArea(); // Esperado: 25, Actual: 25

Console.WriteLine(areaRectangulo);
Console.WriteLine(areaCuadrado);

Console.Read();
