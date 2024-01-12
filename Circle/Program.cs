using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        class circle
        {
            public double Radius { get; set; }

            public circle(double initialRadius)
            {
                this.Radius = initialRadius;
            }
            public double CalculateArea()
            {
                double area = Math.PI * Radius * Radius;

                return area;
            }
            public double circumference()
            {
                double C = 2 * Math.PI * Radius;
                return C;
            }

            public void Displaye()
            {
                Console.WriteLine("Area : " + CalculateArea());
                Console.WriteLine("Circumference:  " +  circumference());
             }
        
        }
        static void Main(string[] args)
        {
            circle c = new circle(2);
            
            c.Displaye();


            Console.ReadLine();
        }
    }
}
