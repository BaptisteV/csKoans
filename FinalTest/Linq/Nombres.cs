using System.Collections.Generic;
using System.Linq;

namespace FinalTest.Linq
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;


        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return _keyValuePairs.Where(pair => pair.Value%2 == 0).Select(pair => pair.Value);}
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

        public string PremierNombreDontLeTexteContientPlusDe5Caractères {
            get { return _keyValuePairs.First(pair => pair.Key.Length > 5).Key; }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return _keyValuePairs.OrderBy(pair => pair.Value).SkipWhile(pair => (pair.Value <= 3)).Select(pair => pair.Value).Take(4); }
        }
    }
}