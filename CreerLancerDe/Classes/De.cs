using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    public class De : StructureDe
    {

        public override int Type { get; set; }
        public override int Faces { get; set; }
        public string Nom {get; set;}
        public int Contenu_id { get; set; }

        public De(int faces, int type,string nom, int contenu_de):base(faces,type) {
            Faces=faces;
            Type=type;
            Nom=nom;
            Contenu_id = contenu_de;
        }
    }
}
