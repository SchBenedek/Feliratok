using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feliratok
{
    internal class IdozitettFelirat
    {
        private string idozites;
        private string felirat;

        public IdozitettFelirat(string idozites, string felirat)
        {
            this.idozites = idozites;
            this.felirat = felirat;
        }

        public string Idozites { get => idozites; set => idozites = value; }
        public string Felirat { get => felirat; set => felirat = value; }
        public override string ToString()
        {
            return $"{this.idozites} --- {this.felirat}";
        }
    }
}
