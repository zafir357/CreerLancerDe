using CreerLancerDe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Classes
{
    public class TypeDeModel
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public DeModel DeModel { get; set; }

    }
}
