using System;
class Program
{
    static void Main (string[] args)
    {
        double x = 0;
        x = double.Parse(Console.ReadLine());
        Console.WriteLine(F(x));
    }
    static double F (double x)
    {
        if ( x > 1 )
        {
            return F( x - 2 );
        }
        else if ( 0 < x && x <= 1 )
        {
            return -(Math.Sqrt(1-Math.Pow(x,2)));
        }
        else if ( -1 < x && x <= 0 )
        {
            return Math.Sqrt(1-Math.Pow(x,2));
        }
        else
        {
            return F( x + 2 );
        }
    }
}