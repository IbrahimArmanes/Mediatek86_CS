using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class CommandeLivreDvd : Commande
    {
        private readonly int nbExemplaire;
        private readonly string idLivreDvd;
        public CommandeLivreDvd(int nbExemplaire, string idLivreDvd, string id, double montant):base (id, montant)
        {
            this.nbExemplaire = nbExemplaire;
            this.idLivreDvd = idLivreDvd;
        }

        public int NbExemplaire { get => nbExemplaire; }
        public string IdLivreDvd { get => idLivreDvd; }
    }
}
