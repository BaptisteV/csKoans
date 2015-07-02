using System;

namespace FinalTest.Bases
{
    public class Somme : IOperation
    {
        public bool PeutCalculer(string exp)
        {
            return exp.Contains("+");
        }

        public double Calculer(string exp)
        {
            var strings = exp.Split('+');
            return Convert.ToDouble(strings[0]) + Convert.ToDouble(strings[1]);
        }
    }
}