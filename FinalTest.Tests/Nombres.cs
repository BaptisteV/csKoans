using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> _keyValuePairs;


        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return from pair in _keyValuePairs where pair.Value%2 == 0 select pair.Value;}
        }

        private bool Paire(int num)
        {
            return (num%2 == 0);
        }

        public string TexteNombresImpairs
        {
            get
            {
                return _keyValuePairs.OrderBy(x => x.Value).Where(number => !Paire(number.Value))
                    .Select(pair => pair.Key).Aggregate((i, j) => i + ", " + j);
            }
        }
    }
}