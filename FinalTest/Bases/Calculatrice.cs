using System.Linq;
using FinalTest.Bases;

namespace FinalTest.Tests
{
    public class Calculatrice
    {
        private IOperation[] _operation;

        public Calculatrice(IOperation[] operation)
        {
            _operation = operation;
        }

        public bool PeutCalculer(string exp)
        {
            if (_operation.Any(ope => ope.PeutCalculer(exp)))
            {
                return true;
            }
            return false;
        }

        public double? Calculer(string exp)
        {
            foreach (var ope in _operation)
            {
                if (ope.PeutCalculer(exp))
                {
                    return ope.Calculer(exp);
                }
            }
            return null;
        }
    }
}