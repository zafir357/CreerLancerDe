using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Classes
{
    class DeGenerique : StructureDe
    {
        private int faces;
        private int type;
        private Array contenuDe;
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

        public Array ContenuDe
        {
            get { return contenuDe; }
            set { contenuDe = value; }
        }

        public DeGenerique(int Faces, int Type, Array ContenuDe) : base(Faces, Type)
        {
            faces = Faces;
            type = Type;
            contenuDe = ContenuDe;
        }
    }
}
