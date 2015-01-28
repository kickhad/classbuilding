using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MvvmLight_BaseClasses.Model
{
    internal class MaterialDataService : IMaterialDataService
    {
        //public async Task<IEnumerable<ItemData>  BeginTask()
        //{
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM vItemData",@"Data Source=DEV\DEV;Initial Catalog=WBDB;Trusted_Connection=True");
        //    DataTable dt = new DataTable();
        //    dataAdapter.Fill(dt);
        //    var json = JsonConvert.SerializeObject()
        //    //SqlConnection conn = new SqlConnection(@"Data Source=DEV\DEV;Initial Catalog=WBDB;Trusted_Connection=True");
        //    //    SqlCommandBuilder sqlCommand = new SqlCommandBuilder();


        //}

        public async Task<IEnumerable<MaterialData>> Begin()
        {
            DataContext db = new DataContext
                (@"Data Source=DEV\DEV;Initial Catalog=WBDB;Trusted_Connection=True");

            // Get a typed table to run queries.

            Table<sqlMaterialData> vItemData = db.GetTable<sqlMaterialData>();
            // Attach the log to show generated SQL.

           // IQueryable<MaterialData> custQuery =
            var lnq = from row in vItemData
            select row;
            
            
            var json = JArray.FromObject(lnq.ToArray());
            // var jsonwhole = "{data:" & json.ToString()) & "}" ;
            StringBuilder str = new StringBuilder(@"{""data"":");
            str.Append(json.ToString());
            str.Append("}");


            var result = JsonConvert.DeserializeObject<ListOfMaterialData>(str.ToString()); 
            return result.Data;
            //var result = JsonConvert.DeserializeObject<ListOfMaterialData>(custQuery.AsEnumerable<ListOfMaterialData);
            


            //// Query for customers in London.

            //return vItemData;

        }
    }
}

