using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    class DeCouleur : StructureDe
    {
        public override int Type { get; set; }
        public override int Faces { get; set; }
        public Array Couleurs { get; set; }

        public DeCouleur(int faces, int type, Array couleur) : base(faces, type)
        {
            Faces = faces;
            Type = type;
            Couleurs = couleur;
        }
        /*        public override int Faces
                {
                    get { return faces; }
                    set { faces = value; }
                }
        */
        /*public Array Couleurs
        {
            get { return couleurs; }
            set { couleurs = value; }
        }*/
        /*        public override int Type
                {
                    get { return type; }
                    set { type = value; }
                }*/

    }
}
