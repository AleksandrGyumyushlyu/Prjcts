using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public Parabola(double p, double k) : this(1, 2 * p, (p * p) - k) { }

        /// <summary>
        /// Function will find current's <c>Parabola</c> instance a <b>Y axis</b> interception point
        /// </summary>
        /// <returns>Current's <c>Parabola</c> instance <b>Y axis</b> interception point</returns>
        public Point Yintercept()
        {
            return new Point(0 ,this.c);
        }

        public Point[] Xintercept()
        {
            if ((Math.Pow(this.b, 2) - 4 * this.a * this.c) < 0)
            {
                return null;
            }
            else if ((this.c - (Math.Pow(this.b, 2) / (4 * this.a)) == 0))
            {
                Point xIntercept = new Point(-this.b / (a * 2), 0);

                Point[] point = { xIntercept };
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

        // TODO Do the rest of the functions
    
        /// <summary>
        /// When printing the instance of <c>Parabola</b> forses to print it in f(x) = ax² + bx + c format
        /// </summary>
        /// <returns>String with all <b>parameters</b> of <c>parabola</c> instance in f(x) = ax² + bx + c format</returns>
        public override string ToString()
        {
            return $"f(x) = {(this.a != 1 ? $"{this.a}" : "")}x^2 {this.b:+ #;- #;+ 0} {this.c:+ # ;- # ;+ 0}";
        }

        public static void UnitTest()
        {
            Parabola parabola1 = new Parabola(1, 2, 4);
            Console.WriteLine(parabola1);

            Parabola parabola2 = new Parabola(3, -12, +20);
            Console.WriteLine(parabola2);

            Parabola parabola3 = new Parabola(3, 5);
            Console.WriteLine(parabola3);

            Console.WriteLine($"Y intercepts: {parabola1.Yintercept()}, {parabola2.Yintercept()}, {parabola3.Yintercept()}");
            Console.WriteLine("Xintercepts1:");
            if (parabola1.Xintercept() != null)
            {
                Console.WriteLine(parabola1.Xintercept()[0] != null ? $"{parabola1.Xintercept()[0]}" : "null");
                Console.WriteLine(parabola1.Xintercept()[1] != null ? $"{parabola1.Xintercept()[1]}" : "null");
                Console.WriteLine($"{parabola1.Xintercept()[0]} : { parabola1.Xintercept()[1]}");
            }
            Console.WriteLine("Xintercepts2:");
            if (parabola2.Xintercept() != null)
            {
                Console.WriteLine(parabola2.Xintercept()[0] != null ? $"{parabola2.Xintercept()[0]}" : "null");
                Console.WriteLine(parabola2.Xintercept()[1] != null ? $"{parabola2.Xintercept()[1]}" : "null");
                Console.WriteLine($"{parabola2.Xintercept()[0]} : {parabola2.Xintercept()[1]}");
            }
            Console.WriteLine("Xintercepts3:");
            if (parabola3.Xintercept() != null)
            {
                Console.WriteLine(parabola3.Xintercept()[0] != null ? $"{parabola3.Xintercept()[0]}" : "null");
                Console.WriteLine(parabola3.Xintercept()[1] != null ? $"{parabola3.Xintercept()[1]}" : "null");
                Console.WriteLine($"{parabola3.Xintercept()[0]} : {parabola3.Xintercept()[1]}");
            }
        }
    }
}
