using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
namespace MvvmLight_BaseClasses.Model
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    ///     public class Forecast : TinyDataItem
    public class Transit : ObservableObject
    {
        [JsonProperty]
        public int Material { get; set; }

        [JsonProperty]
        public int Warehouse { get; set; }

        public DateTime Month
        {
            get
            {
                return DateTime.Now.AddMonths(this.Offset);
            }
            set
            {
                // int x = new int();
                int x = 1;
            }
        }

        [JsonProperty]
        public int Offset { get; set; }

        [JsonProperty]
        public int Qty { get; set; }
    }
    public class Forecast : ObservableObject
    {

        [JsonProperty]
        public int Material{get;set;} 

        [JsonProperty]
        public int Offset{get;set;}

        [JsonProperty]
        public int Qty{get;set;}

        public DateTime Month
        {
            get
            {
                return DateTime.Now.AddMonths(this.Offset);
            }
            set
            {
                int x = new int();
                x = 1;
            }
        }

    }    
    public class Incoming : ObservableObject

    {
        [JsonProperty]
        public int Material{get;set;} 

        [JsonProperty]
        public int Offset{get;set;}

        [JsonProperty]
        public int Qty { get; set; }

        public DateTime Month
        {
            get
            {
                return DateTime.Now.AddMonths(this.Offset);
            }
            set
            {
                int x = new int();
                x = 1;
            }
        }
    }
    public class Inventory : ObservableObject
    {
        [JsonProperty]
        public int Material { get; set; }

        [JsonProperty]
        public int Warehouse { get; set; }

        [JsonProperty]
        public int Qty { get; set; }


    }
    public class OrderChange : ObservableObject
        
    {
        [JsonProperty]
        public int Material{get;set;}        

        [JsonProperty]
        public int Offset{get;set;}

        [JsonProperty]
        public int Qty { get; set; }

        //removeable on rollout
        public DateTime Month
        {
            get
            {
                return DateTime.Now.AddMonths(this.Offset);
            }
            set
            {
                int x = new int();
                x = 1;
            }
        }
    }
    public class TinyDataItem : ObservableObject
    {
        /// <summary>
        /// Initializes a new instance of the MonthlyBucketTinySet class.
        /// </summary>        

        [JsonProperty] int Material { get; set; }
        public int Offset { get; set; }
        public int Qty { get; set; }
        public DateTime Month
        {
            get            
            {                
                return DateTime.Now.AddMonths(this.Offset);
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        
    }
}