using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Classes
{
   public class ContenuDe
    {
        public int Contenu_de_id { get; set; }
        public string Contenu { get; set; }
        public ContenuDe()
        {
        }
        public ContenuDe(int id, string contenuDe)
        {
            Contenu_de_id = id;
            Contenu = contenuDe;
        }

        /// <summary>
        /// ORM
        /// </summary>
        public ICollection<De> De { get; set; }
    }
}
