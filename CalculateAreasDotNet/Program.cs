using System;

namespace CalculateAreasDotNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For calculating area rectangle input 1");
            Console.WriteLine("For calculating area circle input 2");
            Console.WriteLine("For calculating area triangle input 3");
            if (uint.TryParse(Console.ReadLine(), out uint type))
            {
                double a;
                double b;
                double c;
                double result = 0;
                double radius;

                switch (type)
                {
                    case 1:
                        {
                            Console.Write($"a = ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write($"b = ");
                            b = double.Parse(Console.ReadLine());
                            result = AreaRectangleOrSquare(a, b);
                            break;
                        }
                    case 2:
                        {
                            Console.Write($"radius = ");
                            radius = double.Parse(Console.ReadLine());
                            result = AreaCircle(radius);
                            break;
                        }
                    case 3:
                        {
                            Console.Write($"a = ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write($"b = ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write($"c = ");
                            c = double.Parse(Console.ReadLine());
                            if (a + b > c && a + c > b && b + c > a)
                            {
                                result = AreaTriangle(a, b, c);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input: make sure a+b>c, a+c>b and b+c>a");
                                result = 0;
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.WriteLine($"Area = {result}");
            }
            else Console.WriteLine("Please enter number!");
            Console.ReadKey();
        }

        public static Func<double, double, double> AreaRectangleOrSquare = (a, b) => (a * b);

        public static Func<double, double> AreaCircle = (radius) => (Math.Pow(radius, 2) * Math.PI);

        public static Func<double, double, double, double> AreaTriangle =
            (a, b, c) => (Math.Sqrt((a + b + c) * (b + c - a) * (a + b - c) * (a - b + c))) / 4;
    }
}
