using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MvvmLight_BaseClasses.Model
{


   
    public class ListOfForecasts
    {
        [JsonProperty("Forecasts")]
        public List<Forecast> Forecasts{get;set;}
    }

    public class ListOfIncomings
    {
        [JsonProperty]
        public List<Incoming> Incomings{get;set;}

    }

    public class ListOfOrderChanges
    {
        [JsonProperty]
        public List<OrderChange> OrderChanges{get;set;}
    }


    public class ListOfTransit
    {
        [JsonProperty]
        public List<Transit> Transits{get;set;}
    }

    public class ListOfUsages
    {
        [JsonProperty]
        public List<MaterialUsage> Usages { get; set; }
    }

    public class ListOfInventorys
    {
        [JsonProperty]
        public List<Inventory> Inventorys { get; set; }
    }
}

        
            

