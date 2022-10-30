using System;
public class Exercise1_5
{
    public static void Main()
    {

        double r, per_cir, area_cir;
        double PI = 3.14;
        Console.WriteLine("Input the radius of the circle : ");
        r = Convert.ToDouble(Console.ReadLine());
        per_cir = 2 * PI * r;
        area_cir = PI * r * r;
        Console.WriteLine("Perimeter of Circle : {0}", per_cir);
        Console.WriteLine("Area of Circle :{0} ", area_cir);
        Console.Read();
    }
}