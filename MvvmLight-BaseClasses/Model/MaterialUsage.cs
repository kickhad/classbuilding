using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvvmLight_BaseClasses.Model
{
    public class MaterialUsage : ObservableObject
    {
        [JsonProperty]
        public int MaxIn8
        {
            get;set;
           // set { throw new NotImplementedException(); }
        }

        [JsonProperty]
        public int MinIn8
        {
            get;
            set;
            //   get { return 90; }
            // set { throw new NotImplementedException(); }        
        }
        [JsonProperty]
        public int OpenDelivery
        { get; set; }

        [JsonProperty]
        public int BackLogs
        { get; set; }

        [JsonProperty]
        public double MonthlyAverage3
        {
            get;
            set;            
        }

        [JsonProperty]
        public double MonthlyAverage6
        {
            get;
            set; 
            //get { return 431.443; }
            //set { throw new NotImplementedException(); }
        }

        [JsonProperty]
        public double MonthlyAverage12
        {
            get;
            set;
            //get { return 131.443; }
            //set { throw new NotImplementedException(); }
        }
        }
}
