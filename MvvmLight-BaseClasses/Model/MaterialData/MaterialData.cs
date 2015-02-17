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
    public class MaterialData : ObservableObject
    {



        [JsonProperty]
        public int PlCt
        {
            get;
            set;
        }

        [JsonProperty]
        public string Status
        {
            get
            { return "Active"; }
            set
            {
                throw new NotImplementedException();
            }
        }
        #region GENERALMATERIALDATA
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

        [JsonProperty]
        public string CustomerMaterial { get; set; }

        [JsonProperty]
        public int MFS
        { get; set; }

        [JsonProperty]
        public int RefMaterial
        { get; set; }
        #endregion

        //private List<int> _pplant;



        
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