using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Classes
{
    class ContenuDe
    {
        private int Id { get; set; }
        private string Contenu { get; set; }
        public ContenuDe()
        {
        }
        public ContenuDe(int id, string contenuDe)
        {
            this.Id = id;
            this.Contenu = contenuDe;
        }
    }
}
