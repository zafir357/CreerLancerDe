using CreerLancerDe.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Model
{
    public class DeModel
    {
        public DeContenuModel Contenu_de { get; set; }
        public TypeDeModel TypeDes { get; set; }
        public string Nom_de { get; set; }
        public int Faces { get; set; }
     
        private string typeDe;
        public string TypeDe {get { return typeDe; } set
            {
                typeDe = TypeDes.Type;
            }
            
        }




       
    }
}
