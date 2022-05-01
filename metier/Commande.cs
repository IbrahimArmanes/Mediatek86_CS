using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    public class Commande
    {
        private readonly string id;
        private readonly string dateCommande;
        private readonly double montant;
        private readonly int idStade;

        public Commande(string id, string dateCommande, double montant, int idStade)
        {
            this.id = id;   
            this.dateCommande = dateCommande;
            this.montant = montant;
            this.idStade = idStade
        }

        public string Id { get => id; }

        public double Montant { get => montant; }

        public int IdStade { get => idStade; }

        public string DateCommande { get => dateCommande; }





    }
}
