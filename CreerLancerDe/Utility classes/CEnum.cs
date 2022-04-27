using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe
{
    class CEnum
    {
        public static class Queries
        {
            public static readonly string QueryTypeDe = "SELECT * FROM dbo.type_de";
            public static readonly string QueryDe = "SELECT * FROM dbo.de";
            public static readonly string QueryInsertDe = "DECLARE @InsertedRows AS TABLE (id int)Insert into dbo.de(nom_de,faces,type_de_id,contenu_de_id)OUTPUT INSERTED.[id]" +
                "Values(@Nom,@NFaces,@Type,@Contenu_de); SELECT id from @InsertedRows";
            public static readonly string QueryInsertContenuDe = "DECLARE @InsertedRows AS TABLE (id int)" +
                "Insert into dbo.contenu_de(contenu_de) OUTPUT INSERTED.[id]Values(@StrContenu);" +
                "SELECT id from @InsertedRows";
        }
        public static class Erreurs
        {
            public const string errNumType = "La valeur n'est pas valide. C'est un champ numerique";
            public const string errNumNull = "Ce champ est obligatoire";
        }
        public static class Variables
        {
            public const string empty = "";
        }

        public static class TypeDeId
        {
            public const string deNormal = "Dé Normal";
            public const string deCouleur = "Dé couleur";
            public const string deDynamic = "Dé dynamic";

        }


    }
}
