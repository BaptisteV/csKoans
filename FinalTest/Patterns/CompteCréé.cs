using FinalTest.Tests;

namespace FinalTest.Patterns
{
    public class CompteCréé : IEvenementMetier
    {
        public Montant MontantCompte { get; private set; }
        public string NuméroDeCompte { get; private set; }

        public CompteCréé(string numéroDeCompte, int montant)
        {
            NuméroDeCompte = numéroDeCompte;
            MontantCompte = new Montant(montant);
        }

        public override bool Equals(object obj)
        {
            var item = obj as CompteCréé;
            if (item == null)
            {
                return false;
            }
            return (this.MontantCompte.Equals(item.MontantCompte)) && (item.NuméroDeCompte == this.NuméroDeCompte);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}