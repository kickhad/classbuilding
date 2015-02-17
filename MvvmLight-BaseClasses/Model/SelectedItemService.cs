using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_BaseClasses.Model
{
    public interface ISelectedItemService 
    {
        Task<MaterialSelected> SelectItem(IEnumerable<int> materials);           
    }

    public class SelectedItemService : ISelectedItemService
    {
        private IMaterialDataService _materialDataService;
        public SelectedItemService(IMaterialDataService materialDataService)
        {
#pragma warning disable 1998
            _materialDataService = materialDataService;
            Forecasts = new List<Forecast>();
            //Incomings = new List<Incoming>();
            //OrderChanges = new List<OrderChange>();
            //Transits = new List<Transit>();
            //Inventorys = new List<Inventory>();
            Task.Run(() => PullForecasts());
            Task.Run(() => PullIncomings());
            Task.Run(() => PullInventorys());
            Task.Run(()=> PullOrderChanges());
            Task.Run(()=> PullTransits());
            Task.Run(() => PullUsages());

            //PullForecasts();
           // PullIncomings();
           // PullInventorys();
          //  PullOrderChanges();
         //   PullTransits();
#pragma warning disable 1998


        }


        
        
        public async Task<MaterialSelected> SelectItem(IEnumerable<int> refmats)
        {
            List<MaterialSelected> _selectItem = new List<MaterialSelected>();
            _selectItem.Add(new MaterialSelected());            
            foreach(int i in refmats)                        
            
            {
                
                if (_Forecasts != null)
                { _selectItem[0].Forecasts.AddRange(_Forecasts.Where(fc => fc.Material == i)); }

                if (_Inventorys != null)
                { _selectItem[0].Inventorys.AddRange(_Inventorys.Where(inv => inv.Material == i)); }

                if(_Transits != null) 
                {_selectItem[0].Transits.AddRange(_Transits.Where(tr => tr.Material == i));}

                if (_OrderChanges != null) 
                {_selectItem[0].OrderChanges.AddRange(_OrderChanges.Where(oc => oc.Material == i));}
                
                if (_Incomings != null)
                { _selectItem[0].Incomings.AddRange(_Incomings.Where(oc => oc.Material == i)); }
            }     
       
            return _selectItem[0];
            

            
        }

        public List<Inventory> Inventorys
        { get; private set; }

        public List<Forecast> Forecasts
        { get; private set; }

        
        private List<Forecast> _Forecasts;
        private async Task PullForecasts()
        {

            _Forecasts = new List<Forecast>();
            var forecasts = await _materialDataService.PullForecasts();

            if (forecasts != null)
            {
                foreach (var forecast in forecasts)
                {
                    _Forecasts.Add(forecast);
                }
            }

        }
        private List<MaterialUsage> _Usages{ get; set; }
        private async Task PullUsages()
        {

            _Usages = new List<MaterialUsage>();
            var uses = await _materialDataService.PullUsages();
            if (uses != null)
            {
                foreach (var use in uses)
                {
                    _Usages.Add(use);
                }
            }
        }

        

        private List<Inventory> _Inventorys { get; set; }
        private async Task PullInventorys()
        {

            _Inventorys = new List<Inventory>();
            var invs = await _materialDataService.PullInventorys();
            if (invs != null)
            {
                foreach (var inv in invs)
                {
                    _Inventorys.Add(inv);
                }
            }

        }



        public List<Incoming> Incomings
        { get; private set; }
        public List<OrderChange> OrderChanges
        { get; private set; }
        public List<Transit> Transits
        { get; private set; }




        private List<Incoming> _Incomings { get; set; }
        private async Task PullIncomings()
        {

            _Incomings = new List<Incoming>();
            var incomings = await _materialDataService.PullIncomings();
            if (incomings != null)
            {
                foreach (var incoming in incomings)
                {
                    _Incomings.Add(incoming);
                }
            }

        } 

        private List<OrderChange> _OrderChanges { get; set; }
        private async Task PullOrderChanges()
        {

            _OrderChanges = new List<OrderChange>();
            var changes = await _materialDataService.PullOrderChanges();
            if (changes != null)
            {
                foreach (var change in changes)
                {
                    _OrderChanges.Add(change);
                }
            }

        } 

        private List<Transit> _Transits { get; set; }
        private async Task PullTransits()
        {

            _Transits = new List<Transit>();
            var transits = await _materialDataService.PullTransits();
            if (transits != null)
            {
                foreach (var transit in transits)
                {
                    _Transits.Add(transit);
                }
            }

        }// 


        



       
    }
}
