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
        private readonly int idStade;
        public CommandeLivreDvd(int nbExemplaire, string idLivreDvd, string id, double montant, DateTime dateCommande, int idStade = 1):base (id, montant, dateCommande)
        {
            this.nbExemplaire = nbExemplaire;
            this.idLivreDvd = idLivreDvd;
            this.idStade = idStade;
        }

        public int NbExemplaire { get => nbExemplaire; }
        public string IdLivreDvd { get => idLivreDvd; }
        public int IdStade { get => idStade; }
    }
}
