using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Classes
{
    class TypeDe
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public TypeDe()
        {
   
        }

        public TypeDe(int type_id, string type_de)
        {
            ID = type_id;
            Type = type_de;
        }


    }
}
