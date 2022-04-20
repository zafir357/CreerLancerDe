using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    public class De : StructureDe
    {
        private string nom;
        private int faces;
        private int type;
        public override int Faces
        {
            get { return faces; }
            set { faces = value; }
        }
        public override int Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public De(int Faces, int Type,string Nom):base(Faces,Type) {
            faces=Faces;
            type = Type;
            nom = Nom;
        }
    }
}
