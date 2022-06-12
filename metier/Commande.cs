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
        private readonly DateTime dateCommande;
        private readonly double montant;

        public Commande(string id, double montant, DateTime dateCommande)
        {
            this.id = id;
            this.montant = montant;
            this.dateCommande = dateCommande;
        }

        public string Id { get => id; }

        public double Montant { get => montant; }

        public DateTime DateCommande { get => dateCommande; }





    }
}
