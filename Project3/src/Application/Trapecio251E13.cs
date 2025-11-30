using System;

namespace Application;

public class Trapecio251E13
{
    public static double Perimetro(double costados, double basem, double basemayor )
    {
        double perimetro = 2*costados+basem+basemayor;
        return perimetro;
    }
    public static double Area(double altura, double basem, double basemayor )
    {
        double area = ((basem+basemayor)*altura)/2;
        return area;
    }
    public static double Volumen(double area, double altura)
    {
        double volumen = area * altura;
        return volumen;
    }
}
 