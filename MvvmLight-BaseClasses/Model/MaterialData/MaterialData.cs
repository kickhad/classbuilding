using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;

namespace MvvmLight_BaseClasses.Model
{
   
    [Table(Name="vItemData")]
    public class sqlMaterialData : ObservableObject
    {

        [Column]
        public int Material
        { get; set; }

        [Column]
        public string Brand
        { get; set; }

        [Column]
        public decimal PcWt
        { get; set; }


        [Column]
        public string Shape
        { get; set; }

        [Column]
        public int ExtMaterial
        { get; set; }

        [Column]
        public int MFS
        { get; set; }
             

    }
    public class MaterialData : ObservableObject
    {
        [JsonProperty]
        public decimal PcWt
        { get; set; }
        
        [JsonProperty]
        public int Material
        { get; set; }

        [JsonProperty]
        public string Brand
        { get; set; }

        [JsonProperty]
        public string Shape
        { get; set; }

        [JsonProperty]
        public List<MonthlyBucket> MonthlyBuckets
        {
            get;
            set;

        }
        [JsonProperty]
        public int ExtMaterial
        { get; set; }
        
        //[JsonProperty]
        //public string CustomerMaterial
        //{get;set;}
        [JsonProperty]
        public int MFS
        { get; set; }

        [JsonProperty]
        public string Status
        {
            get
            { return "Active";}
            set
            {
                throw new NotImplementedException();
            }
        }
        //private List<int> _pplant;
        
        [JsonProperty]
        public  int RefMaterial
        {get;set;}

     

        //public int PlCt
        //{
        //    get
        //    {
        //        Random rnd = new Random(2);
        //        int pl = rnd.Next(50, 500);
        //        return pl;
        //    }
        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //public int Warehouse
        //{
        //    get
        //    {
        //        return 4999;
        //    }
        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //#region MoveToMaterialUsage
        //      public int MaxIn8
        //{
        //    get { return 128;}
        //    set { throw new NotImplementedException();}
        //}
        //public int MinIn8
        //{ 
        //    get { return 90; }
        //    set { throw new NotImplementedException(); }        
        //}

        //public double MonthlyAverage3
        //{
        //    get { return 239.443; }
        //    set { throw new NotImplementedException(); }
        //}
        //public double MonthlyAverage6
        //{
        //    get { return 431.443; }
        //    set { throw new NotImplementedException(); }
        //}
        //public double MonthlyAverage12
        //{
        //    get { return 131.443; }
        //    set { throw new NotImplementedException(); }
        //}
        
        //#endregion
        //private List<int> _warehouse;

        
        
    }
    
    
}
