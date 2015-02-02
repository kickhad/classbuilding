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
    internal class SelectedCurrentPostionDataService : ISelectedCurrentPositionService
    {
      
#pragma warning disable 1998
        public async Task<IEnumerable<SelectedCurrentPosition>> Begin()
        {
           /*
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
            */
            var str = @"{  ""data"": [    {      ""Material"": 8214479,      ""Brand"": ""HA-DC25"",      ""PcWt"": 1,      ""Shape"": ""2000KG"",      ""ExtMaterial"": 8214479,      ""MFS"": 130,      ""MonthlyBucket"": {        ""MB"": [          {            ""Offset"": 0,            ""Incoming"": 100,            ""Forecast"": 200,            ""Changes"": 2000          }          ,          {            ""Offset"": 1,            ""Incoming"": 125,            ""Forecast"": 240,            ""Changes"": -200          }        ]      },      ""CurrentPosition"": {        ""Transit"": [          {            ""Offset"": 0,            ""Qty"": 25          }          ,          {            ""Offset"": 1,            ""Qty"" : 50          }        ]        ,        ""Inventory"": [          {            ""Warehouse"": 4910,            ""Qty"": 200          }          ,          {            ""Warehouse"": 4901,            ""Qty"" : 50          }        ]      }    }    ,    {      ""Material"": 8214517,      ""Brand"": ""HA-NN25"",      ""PcWt"": 1,      ""Shape"": ""2000KG"",      ""ExtMaterial"": 8214517,      ""MFS"": 130    },    {      ""Material"": 8215537,      ""Brand"": ""HA-DC25"",      ""PcWt"": 1,      ""Shape"": ""1000KG"",      ""ExtMaterial"": 8215537,      ""MFS"": 130    },    {      ""Material"": 8215806,      ""Brand"": ""FT-041"",      ""PcWt"": 1,      ""Shape"": "" 25 KG"",      ""ExtMaterial"": 8215806,      ""MFS"": 130    }}";
            var result = JsonConvert.DeserializeObject<ListOfMaterialData>(str.ToString());
            return null;
            //return result.Data;
            //var result = JsonConvert.DeserializeObject<ListOfMaterialData>(custQuery.AsEnumerable<ListOfMaterialData

        }
        public async Task<IEnumerable<MaterialUsage>> UsageBegin()
        {
            throw new NotImplementedException();
        }
#pragma warning disable 1998
    }
}

