namespace FinalTest.Patterns
{
    public struct Montant
    {
        private int _montant;

        public Montant(int montant)
        {
            _montant = montant;
        }

        public Montant Add(Montant montantDepot)
        {
            return  new Montant(_montant + montantDepot._montant);
        }

        public Montant Substract(Montant montantRetrait)
        {
            return new Montant(_montant - montantRetrait._montant);
        }

        public bool Equals(Montant mnt)
        {
            return mnt._montant == _montant;
        }
    }
}