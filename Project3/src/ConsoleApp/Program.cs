double costados = 8;
double altura = 14;
double basem = 17;
double basemayor = 20;
double perimetro = Application.Trapecio251E13.Perimetro(costados, basem, basemayor);
double area = Application.Trapecio251E13.Area(basem, basemayor, altura);
double volumen = Application.Trapecio251E13.Volumen(area, altura);
Console.WriteLine($"El perímetro de un trapecio con costado de {costados}cm con una base menor de {basem}cm y base mayor de {basemayor}cm es {perimetro}cm");
Console.WriteLine($"El área de un trapecio de base menor {basem}cm por base mayor {basemayor}cm de altura {altura}cm es {area}cm2");
Console.WriteLine($"El volumen de un trapecio de area de {area}cm2 y altura de {altura}cm es {volumen}cm3");

