using System;

namespace FinalTest.Patterns
{
    public class RetraitRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        public Montant MontantRetrait { get; private set; }
        private DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _dateRetrait = dateRetrait;
            MontantRetrait = montantRetrait;
            _numéroDeCompte = numéroDeCompte;
        }

        public override bool Equals(object obj)
        {
            var item = obj as RetraitRéalisé;
            if (item == null)
            {
                return false;
            }
            return (this.MontantRetrait.Equals(item.MontantRetrait)) && (item._numéroDeCompte == this._numéroDeCompte) && (item._dateRetrait == this._dateRetrait);
        }
    }
}