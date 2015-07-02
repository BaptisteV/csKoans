using System;

namespace FinalTest.Patterns
{
    public class RetraitR�alis� : IEvenementMetier
    {
        private string _num�roDeCompte;
        public Montant MontantRetrait { get; private set; }
        private DateTime _dateRetrait;

        public RetraitR�alis�(string num�roDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _dateRetrait = dateRetrait;
            MontantRetrait = montantRetrait;
            _num�roDeCompte = num�roDeCompte;
        }

        public override bool Equals(object obj)
        {
            var item = obj as RetraitR�alis�;
            if (item == null)
            {
                return false;
            }
            return (this.MontantRetrait.Equals(item.MontantRetrait)) && (item._num�roDeCompte == this._num�roDeCompte) && (item._dateRetrait == this._dateRetrait);
        }
    }
}