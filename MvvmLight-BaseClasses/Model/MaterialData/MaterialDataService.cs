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
using System.IO;
using MvvmLight_BaseClasses.Helpers;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace MvvmLight_BaseClasses.Model
{
    public class MaterialDataService : IMaterialDataService
    {


#pragma warning disable 1998
        public async Task<MaterialSelected> SelectItem()
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<MaterialData>> Begin()
        {
            StringWriter sw = await GetJSONSW("SELECT * FROM MaterialData ORDER BY MFS, ExtMaterial", "data");
            var result = await Task.Factory.StartNew(
                () =>

                     JsonConvert.DeserializeObject<ListOfMaterialData>(sw.ToString())
            );
            if (result != null)
            {
                return result.Data;
            }
            else
            {
                return null;
            }
        }

        public async Task<StringWriter> GetJSONSW(string sqlCmd, string TableName)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DEV\DEV;Initial Catalog=Staging;Trusted_Connection=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn);
            DataSet ds = new DataSet(); da.Fill(ds);
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                JsonTextWriter jw = new JsonTextWriter(sw);
                DataTableConverter dtc = new DataTableConverter();
                JsonSerializer ser = new JsonSerializer();
                dtc.TextWriteJson(jw, dt, ser, TableName);
                conn.Close();

            }
            return sw;
        }
        public async Task<List<Forecast>> PullForecasts()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM Forecasts", "Forecasts");

            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfForecasts>(sw.ToString())
          );
            if (result != null)
            {
                return result.Forecasts;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Incoming>> PullIncomings()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM Incomings", "Incomings");
            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfIncomings>(sw.ToString())
          );

            if (result != null)
            {
                return result.Incomings;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Inventory>> PullInventorys()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM Inventorys", "Inventorys");
            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfInventorys>(sw.ToString())
          );

            if (result != null)
            {
                return result.Inventorys;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Transit>> PullTransits()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM Transits", "Transits");
            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfTransit>(sw.ToString())
            );

            if (result != null)
            {
                return result.Transits;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<MaterialUsage>> PullUsages()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM Usages", "Usage");

            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfUsages>(sw.ToString())
          );

            if (result != null)
            {
                return result.Usages;
            }
            else
            {
                return null;
            }

        }

        public async Task<List<OrderChange>> PullOrderChanges()
        {
            StringWriter sw = await GetJSONSW(@"SELECT * FROM OrderChanges", "OrderChanges");

            var result = await Task.Factory.StartNew(

                () =>

                   JsonConvert.DeserializeObject<ListOfOrderChanges>(sw.ToString())
          );

            if (result != null)
            {
                return result.OrderChanges;
            }
            else
            {
                return null;
            }
        }


    }
#pragma warning disable 1998
}

