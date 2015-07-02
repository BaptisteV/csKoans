using System;
using System.Collections.Generic;
using FinalTest.Patterns;

namespace FinalTest.Tests
{
    public class CompteBancaire
    {
        private IEvenementMetier[] _events;
        public Montant MontantCompte { get; private set; }
        public string NuméroDeCompte { get; private set; }

        public CompteBancaire(CompteCréé compteCréé)
        {
            Gérer(compteCréé);
        }

        public CompteBancaire(params IEvenementMetier[] events)
        {
            foreach (var evenement in events)
            {
                if (evenement is CompteCréé)
                {
                    Gérer( evenement as CompteCréé);
                }
                else if (evenement is RetraitRéalisé)
                {
                    Gérer(evenement as RetraitRéalisé);
                }
                else if (evenement is DépotRéalisé)
                {
                    Gérer(evenement as DépotRéalisé);
                }
            }
        }

        private void Gérer(CompteCréé compteCréé)
        {
            MontantCompte = compteCréé.MontantCompte;
            NuméroDeCompte = compteCréé.NuméroDeCompte;
        }

        private void Gérer(DépotRéalisé dépotRéalisé)
        {
            MontantCompte = MontantCompte.Add(dépotRéalisé.MontantDepot);
        }

        private void Gérer(RetraitRéalisé retraitRéalisé)
        {
            MontantCompte = MontantCompte.Substract(retraitRéalisé.MontantRetrait);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(NuméroDeCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(NuméroDeCompte, montantRetrait, dateRetrait);
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }
    }
}