using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Utility_classes
{
   public static class MethodsLancementDe
    {
        public static bool bouclerList(int parsedValue, List<dynamic> dynList, DynamicParameters ParamContenuDe)
        {
            string strFaces;
            for (int i = 1; i <= parsedValue; i++)
            {
                dynList.Add(i);
            }
            strFaces = String.Join("|", dynList.ToArray());
            if (strFaces != "")
            {
                ParamContenuDe.Add("@strContenu", strFaces);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
