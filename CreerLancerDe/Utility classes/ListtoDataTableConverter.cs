using CreerLancerDe.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreerLancerDe.Utility_classes
{
    public class ListtoDataTableConverter
    {
        public DataTable ToDataTable(List<DeModel> items)
        {
            DataTable dt = new DataTable();
            //Get all the properties
            PropertyInfo[] Props = typeof(DeModel).GetProperties(BindingFlags.Public | BindingFlags.Instance);
     
            int maxVal = items.Max(t => t.Faces);
            Props.Switch(0, 4);
            Props.Switch(1, 3);
            Props.Switch(2,0);
            foreach (PropertyInfo prop in Props)
            {
                if (prop.Name != "TypeDes" && prop.Name != "Contenu_de")
                {
                    dt.Columns.Add(prop.Name);
                }
                if(prop.Name == "Contenu_de")
                {
                  
                    for (int i = 1; i <= maxVal; i++)
                    {
                   
                        dt.Columns.Add("Face" + (i),typeof(string)).SetOrdinal(i+2);
                    }
                    dt.Columns.Add("Dés lancés", typeof(string));
                }
            }
            foreach (dynamic item in items)
            {
                dynamic contenu = item.Contenu_de.Contenu_de;
                string[] faces = contenu.Split('|');
                List<object> values = new List<object>();
                dynamic nullPointer = 0;
                for (int i = 0; i < Props.Length; i++)
                {

                    if ( Props[i].Name!= "TypeDes" && Props[i].Name != "Contenu_de")
                    {
                       
                        values.Add(Props[i].GetValue(item, null));
                    }
                }
              
                  
                    for (int j= 0;j<faces.Length;j++)
                    {
                       var x = faces[j];
                      values.Add(faces[j]);
                    }

                dt.Rows.Add(values.ToArray());

            }
            return dt;
        }
    }
   static class ArraySwitch
    {

        public static void Switch<T>(this IList<T> array, int index1, int index2)
        {
            var aux = array[index1];
            array[index1] = array[index2];
            array[index2] = aux;
        }
    }

}
