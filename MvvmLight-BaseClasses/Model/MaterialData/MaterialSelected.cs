using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_BaseClasses.Model
{
    public class MaterialSelected : ObservableObject 
    {
        public MaterialSelected()
        {
            Forecasts = new List<Forecast>();
            Incomings = new List<Incoming>();
            OrderChanges = new List<OrderChange>();
            Transits = new List<Transit>();
            Inventorys = new List<Inventory>();
            Usages = new List<MaterialUsage>();
            

        }


        public List<MaterialUsage> Usages { get; set; }
        public List<MaterialData> Materials     {get;set;}
        public List<Incoming> Incomings         { get; set; }
        public List<Forecast> Forecasts         { get; set; }
        public List<Inventory> Inventorys       { get; set; }
        public List<Transit> Transits           { get; set; }
        public List<OrderChange> OrderChanges   { get; set; }

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
