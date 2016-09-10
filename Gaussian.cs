using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quant
{
    public class Gaussian
    {
        //Properties
        public double Avg { get; set; }             // The average value of the normal distribution
        public double StDev { get; set; }           // The standard deviation of the normal distribution


        //Constructors
        public Gaussian()                           // Default constructor: returns Dirac's Delta centered on the zero
        {
            Avg = 0;
            StDev = 0;
        }
        
        public Gaussian(double avg, double stdev)   // Constructor with specific average and standard deviation
        {
            Avg = avg;
            StDev = stdev;
        }


        //Overloaded Operators
        public static Gaussian operator +(Gaussian g1, Gaussian g2) // Sum of two random variables
        {
            return new Gaussian(g1.Avg + g2.Avg, Math.Sqrt(Math.Pow(g1.StDev, 2) + Math.Pow(g2.StDev, 2)));
        }
        
        public static Gaussian operator -(Gaussian g1, Gaussian g2) // Difference of two random variables
        {
            return new Gaussian(g1.Avg - g2.Avg, Math.Sqrt(Math.Pow(g1.StDev, 2) + Math.Pow(g2.StDev, 2)));
        }

        public static Gaussian operator *(double c, Gaussian g)    // Product of a scalar by a random variable
        {
            return new Gaussian(c * g.Avg, Math.Abs(c) * g.StDev);
        }

        public static Gaussian operator *(Gaussian g, double c)     // Product of a random variable by a scalar
        {
            return c * g;
        }

        public static Gaussian operator /(Gaussian g, double c)     // Division of a random variable by a scalar
        {
            return (1 / c) * g;
        }

    }
}
