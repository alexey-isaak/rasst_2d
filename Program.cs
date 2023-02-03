using System;
 
namespace krasst_2d
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точки А (в одну строку, через запятую): ");
            string tochkaA = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B (в одну строку, через запятую): ");
            string tochkaB = Convert.ToString(Console.ReadLine());
            
            char[] a = tochkaA.ToCharArray();
            int a_x = (int)Char.GetNumericValue(a[0]);
            int a_y = (int)Char.GetNumericValue(a[2]);

            char[] b = tochkaB.ToCharArray();
            int b_x = (int)Char.GetNumericValue(b[0]);
            int b_y = (int)Char.GetNumericValue(b[2]);

            int x = a_x - b_x;
            int y = a_y - b_y;

            double S = Math.Sqrt(x*x + y*y);

            Console.WriteLine("Расстояние между точками S: " + S);
        }
    }
}
