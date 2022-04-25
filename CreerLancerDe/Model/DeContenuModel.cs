using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Model
{
   public class DeContenuModel
    {
        public int Id { get; set; }
        public string Contenu_de { get; set; }

        public DeModel DeModel { get; set; }
    }
}
