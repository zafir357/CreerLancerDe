using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    class DeCouleur : StructureDe
    {
        private int faces;
        private int type;
        private Array couleurs;
        public override int Faces
        {
            get { return faces; }
            set { faces = value; }
        }

        public Array Couleurs
        {
            get { return couleurs; }
            set { couleurs = value; }
        }
        public override int Type
        {
            get { return type; }
            set { type = value; }
        }
        public DeCouleur(int Faces, int Type, Array couleur) : base(Faces,Type)
        {
            faces = Faces;
            type = Type;
        }
    }
}
