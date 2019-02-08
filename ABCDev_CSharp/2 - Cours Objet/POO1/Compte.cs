using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Compte
    {
        public int decouvertAutorise;
        public string nom;
        public int numero;
        public int solde;

        public bool soldeOk = false;
        public bool supOk = false;

        public Compte()
        {
            numero = 0;
            nom = "DEFAULT";
            solde = 0;
            decouvertAutorise = 0;
        }
        public Compte(int _numero, string _nom, int _solde, int _decouvertAutorise)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        public void Crediter(int _montant)
        {
            solde = solde + _montant;
        }
        public bool Debiter(int _montant)
        {
            solde = solde - _montant;
            return soldeOk;
        }
        public bool Superieur(Compte _autreCompte)
        {
            if (solde > _autreCompte.solde)
            {
                supOk = true;
            }
            else
            {
                supOk = false;
            }
            return supOk;
        }
        public override string ToString()
        {
            string retour = "Numéro : " + this.numero + "\tNom : " + this.nom + "\tSolde : " + this.solde + "\tDécouvert autorisé : " + this.decouvertAutorise + ".";
            return retour;
        }
        //public bool Transferer(int _montant, Compte _compteDestinataire)
        //{

        //}
    }
}
