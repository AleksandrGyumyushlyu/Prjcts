using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Prjcts
{
    internal class Parabola
    {
        private double a;
        private double b;
        private double c;

        /*
            I activated feature in KDE plasma so when I press right alt and 2, it prints ², also it has ³ and ¹, so it's me
            I'm wasting on documentation most of the time, I write functions faster than documentation, I hate it but I
            can't stop cuz I would have to delete documentation in rest of the files because I want to be consistent. anyway
            it's me and not AI, also can type «Text», „Text” and ∞, ° all sorts of useless bs 😏(emoji is from win + .)
        */

        /// <summary>
        /// Function will create <c>Parabola</c> function instance with 3 <b>paramers</b>: <b>a</b>, </b>b</b> and <b>c</b>
        /// </summary>
        /// <param name="a"><b>a parameter</b> for the function (the slope)</param>
        /// <param name="b"><b>b parameter</b> for the function</param>
        /// <param name="c"><b>c parameter</b> for the function</param>
        /// <remarks>0 if passed as <b>a parameter</b> will crash the function and cause an error</remarks>
        public Parabola(double a, double b, double c)
        {
            if (a != 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        /// <summary>
        /// Function will create <c>Parabola</c> function with <b>p</b>, and <b>k</b> parameters like in (x + <b>p</b>)² - <b>k</b> formula
        /// </summary>
        /// <param name="p"><b>p parameter</b>, horizontal shift of the vertex of the <c>parabola</c></param>
        /// <param name="k"><b>p parameter</b>, vertical shift of the vertex of the <c>parabola</c></param>
        public Parabola(double p, double k) : this(1, -2 * p, (p * p) + k) { }

        /// <summary>
        /// Function will find current's <c>Parabola</c> instance a <b>Y axis</b> interception point
        /// </summary>
        /// <returns>Current's <c>Parabola</c> instance <b>Y axis</b> interception point</returns>
        public Point Yintercept()
        {
            return new Point(0 ,this.c);
        }

        /// <summary>
        /// Function will find current's <c>Parabola</c> instance interception <c>Points</c> with <b>X axis</b>
        /// </summary>
        /// <returns>
        /// Array of <c>Points</c> where current <c>Parabola</c> instance intercepting with <b>X axis</b>
        /// </returns>
        /// <remark> Should be used only with safety checks if it's returning null or it will crash </remark>
        public Point[] Xintercept()
        {
            if ((Math.Pow(this.b, 2) - 4 * this.a * this.c) < 0)
            {
                return null;
            }
            else if ((this.c - (Math.Pow(this.b, 2) / (4 * this.a)) == 0))
            {
                Point xIntercept = new Point(-this.b / (a * 2), 0);

                Point[] point = { xIntercept, null };
                return point;
            }
            else
            {
                Point firstIntercept = new Point((-this.b + Math.Sqrt(Math.Pow(this.b, 2) - 4 * this.a * this.c)) / (this.a * 2), 0);
                Point secondIntercept = new Point((-this.b - Math.Sqrt(Math.Pow(this.b, 2) - 4 * this.a * this.c)) / (this.a * 2), 0);

                Point[] points = { firstIntercept, secondIntercept };
                return points;
            }
        }

        /// <summary>
        /// Function prints all interception <c>Points<c/> of <b>parameter</b> <c>Parabola</c> instance with <b>X axis</b>
        /// </summary>
        /// <param name="parabola">Any <c>Parabula</c> instance/'function'</param>
        public static void PrintXintercept(Parabola parabola)
        {
            if (parabola.Xintercept() != null)
            {
                Console.Write($"{parabola} has interception point with X axis: ");
                Console.Write(parabola.Xintercept()[0   ]);
                Console.Write(parabola.Xintercept()[1] != null ? $" and {parabola.Xintercept()[1]}\n" : "\n");
            }
            else
            {
                Console.WriteLine($"{parabola} has no interception points with X axis");
            }
        }

        /// <summary>
        /// Function will find <b>Y</b> coordinate that will be on <b>X</b> coordinate passed as <b>parameter</b> 
        /// </summary>
        /// <param name="x"><b>X</b> coordinate for the <c>Point</c> which's <b>Y</b> coordinate function will find</param>
        public double GetY(double x)
        {
            return this.a * (x * x) + this.b * x + c;
        }

        /// <summary>
        /// Function will find out whether a <b>parameter</b> <c>Point</c> is on current <c>Parabola</c> instance, or not
        /// </summary>
        /// <param name="p"><c>Point</c> to find out if it's on current <c>Parabola</c> or not</param>
        /// <returns>Whether a <b>parameter</b> <c>Point</c> is on current <c>Parabola</c> instance, or not</returns>
        public bool IsOnParabola(Point p)
        {
            return p.GetY() == GetY(p.GetX());
        }

        public Point Extreme()
        {

        }

        // TODO Do the rest of the functions
    
        /// <summary>
        /// When printing the instance of <c>Parabola</b> forses to print it in f(x) = ax² + bx + c format
        /// </summary>
        /// <returns>String with all <b>parameters</b> of <c>parabola</c> instance in f(x) = ax² + bx + c format</returns>
        public override string ToString()
        {
            return $"f(x) = {(this.a != 1 ? $"{this.a}" : "")}x^2{this.b: + #x; - #x;''}{this.c: + #; - #;''}";
        }

        public static void UnitTest()
        {
            Parabola parabola1 = new Parabola(1, 0, 0);
            Console.WriteLine(parabola1);

            Parabola parabola2 = new Parabola(3, -12, +20);
            Console.WriteLine(parabola2);

            Parabola parabola3 = new Parabola(3, 5);
            Console.WriteLine(parabola3);

            Parabola parabola4 = new Parabola(3, 0);
            Console.WriteLine(parabola4);

            Console.WriteLine($"Y intercepts: {parabola1.Yintercept()}, {parabola2.Yintercept()}, {parabola3.Yintercept()}, {parabola4.Yintercept()}");
            Console.WriteLine("Xintercepts:");

            PrintXintercept(parabola1);

            PrintXintercept(parabola2);

            PrintXintercept(parabola3);

            PrintXintercept(parabola4);

            Console.WriteLine("GET Y:");
            Console.WriteLine(parabola1.GetY(5));
            Console.WriteLine(parabola2.GetY(5));
            Console.WriteLine(parabola3.GetY(5));
            Console.WriteLine(parabola4.GetY(5));

            Console.WriteLine("Is on parabola:");
            Console.WriteLine($"Is ( 1, 1 ) on {parabola1}: {parabola1.IsOnParabola(new Point(1, 1))}");
            Console.WriteLine($"Is ( 0, 1 ) on {parabola1}: {parabola1.IsOnParabola(new Point(0, 1))}");

            Console.WriteLine($"Is ( 2, 8 ) on {parabola2}: {parabola2.IsOnParabola(new Point(2, 8))}");
            Console.WriteLine($"Is ( 0, 1 ) on {parabola2}: {parabola2.IsOnParabola(new Point(0, 1))}");

            Console.WriteLine($"Is ( 4, 6 ) on {parabola3}: {parabola3.IsOnParabola(new Point(4, 6))}");
            Console.WriteLine($"Is ( 0, 1 ) on {parabola3}: {parabola3.IsOnParabola(new Point(0, 1))}");

            Console.WriteLine($"Is ( 2, 1 ) on {parabola4}: {parabola4.IsOnParabola(new Point(2, 1))}");
            Console.WriteLine($"Is ( 0, 1 ) on {parabola4}: {parabola4.IsOnParabola(new Point(0, 1))}");



        }
    }
}
