using System;
using FinalTest.Tests;

namespace FinalTest.Patterns
{
    public class DépotRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        public Montant MontantDepot { get; private set; }
        private DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _dateDepot = dateDepot;
            MontantDepot = montantDepot;
            _numéroDeCompte = numéroDeCompte;
        }
        public override bool Equals(object obj)
        {
            var item = obj as DépotRéalisé;
            if (item == null)
            {
                return false;
            }
            return (this.MontantDepot.Equals(item.MontantDepot)) && (item._numéroDeCompte == this._numéroDeCompte) && (item._dateDepot == this._dateDepot);
        }
    }
}