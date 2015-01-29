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
        //[Column]
        //public string CustomerMaterial
        //{ get; set; }

        ////[Column]
        ////public string ItemStatus
        ////{ get; set; }
        //////private List<int> _pplant;

        ////[Column]
        ////public int RefMaterial
        ////{ get; set; }

        //private List<int> _warehouse;

       

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
        public int ExtMaterial
        { get; set; }
        
        //[JsonProperty]
        //public string CustomerMaterial
        //{get;set;}
        [JsonProperty]
        public int MFS
        { get; set; }

        [JsonProperty]
        public string ItemStatus
        {get;set;}
        //private List<int> _pplant;
        
        [JsonProperty]
        public  int RefMaterial
        {get;set;}

        //private List<int> _warehouse;

        private bool _isDirty;

        public bool IsDirty
        {
            get
            {
                return _isDirty;
            }
            set
            {
                Set(() => IsDirty, ref _isDirty, value);
            }
        }
        
    }
}
