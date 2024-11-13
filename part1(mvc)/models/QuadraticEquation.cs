using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class QuadraticEquation
    {
        //Input
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        //Internal
        public double D
        {
            get
            {
                return Math.Pow(B, 2) - 4 * A * C;
            }
        }
        //Output
        public QuadraticEquationSolution Solution
        {
            get
            {
                if (D > 0)
                {
                    return QuadraticEquationSolution.TwoRealRoot;
                }
                else
                {
                    if (D < 0)
                    {
                        return QuadraticEquationSolution.TwoComplexRoots;
                    }
                    else
                    {
                        return QuadraticEquationSolution.OneRealRoot;
                    }
                }
            }
        }
        public double X1
        {
            get
            {
                return (-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            }
        }
        public double X2
        {
            get
            {
                return (-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}x^2{3}{1}x{4}{2}=0, D={5}",
                A.ToString(),
                Math.Abs(B).ToString(),
                Math.Abs(C).ToString(),
                B > 0 ? '+' : '-',
                C > 0 ? '+' : '-',
                D.ToString()
                );
        }
        public enum QuadraticEquationSolution
        {
            OneRealRoot,
            TwoRealRoot,
            TwoComplexRoots
        }
    }
}
