using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    public abstract class StructureDe
    {
        public abstract int Faces { get; set; }
        public abstract int Type { get; set; }
        public StructureDe(int faces, int type)
        {
            Faces = faces;
            Type = type;
        }
        /*
         COMMENTAIRE IMPORTANT
        Si je voulais obliger l'utilisateur a definir(Set) le nombre Faces avec au moment de l'implementation du class,
        j'aurais utiliser un Interface avec ces méthodes:
            void setFaces(int Faces);
            void SetType (string Type);
        Et Donc ,e je les aurais obliger a implementer ces methodes

        Mais ici, je veux utiliser le constructeur pour l'initialisation du dé.  Donc au moment ou le constructeur de la
        classe qui implement cette classe(class fille/child class) definit son constructeur a lui, je lui oblige a utiliser Faces et Types dans le constructeur
         
        De plus l'utilisateur peut modifier plus tard l'objet existant grace a la propriete abstract int Faces qui assure que
        ces proprietes doit etre override dans la class fille(child class)
         */


    }
}
