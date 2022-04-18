using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    public class DeNormal : StructureDe
    {
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
        public DeNormal(int Faces, int Type):base(Faces,Type) {
            faces=Faces;
            type = Type;
        }
    }
}
