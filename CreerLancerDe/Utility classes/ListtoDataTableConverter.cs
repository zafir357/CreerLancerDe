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
              //  int count=dt.Columns.Count;
         
            


                if (prop.Name != "TypeDes" && prop.Name != "Contenu_de")
                {
                    dt.Columns.Add(prop.Name);
                }
                if(prop.Name == "Contenu_de")
                {
                  
                    for (int i = 1; i <= maxVal; i++)
                    {
                   
                        dt.Columns.Add("Face" + (i),typeof(int)).SetOrdinal(i+2);
                    }
                    dt.Columns.Add("Dés lancés", typeof(string));
                /*    dataGridView1.ColumnCount = 4 + maxAge;
                    dataGridView1.Columns[1].Name = "Nom";
                    dataGridView1.Columns[2].Name = "Faces";
                    dataGridView1.Columns[3].Name = "Type";
                    for (int i = 1; i <= maxAge; i++)
                    {
                        dataGridView1.Columns[i + 3].Name = "Face" + (i);
                    }*/
                }
                //Setting column names as Property names
              
            }
            foreach (dynamic item in items)
            {
                dynamic contenu = item.Contenu_de.Contenu_de;
                string[] faces = contenu.Split('|');
                List<object> values = new List<object>();
                dynamic nullPointer = 0;
               //var x = item.DeModel;
                for (int i = 0; i < Props.Length; i++)
                {
/*                    if (Props[i].Name == "Contenu_de")
                    {
                            values[]
    
                    }*/

                    if ( Props[i].Name!= "TypeDes" && Props[i].Name != "Contenu_de")
                    {
                       
                        values.Add(Props[i].GetValue(item, null));
                    }
      /*              else
                    {
                        if (values[i] == null)
                        {
                            nullPointer =i;
                        }
                    }*/
               
                    //inserting property values to datatable rows
                }
              
                  
                    for (int j= 0;j<faces.Length;j++)
                    {
                       var x = faces[j];
                      values.Add(faces[j]);
                    }
                   // }
                //}



                dt.Rows.Add(values.ToArray());

            }
            //put a breakpoint here and check datatable
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
