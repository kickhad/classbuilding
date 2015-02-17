using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_BaseClasses.Model
{
    public interface IMaterialDataService 
    {
        Task<IEnumerable<MaterialData>> Begin();
      //  Task<MaterialSelected> SelectItem();
        Task<List<Forecast>> PullForecasts();
        Task<List<Incoming>> PullIncomings();
        Task<List<Inventory>> PullInventorys();
        Task<List<OrderChange>> PullOrderChanges();
        Task<List<Transit>> PullTransits();
        Task<List<MaterialUsage>> PullUsages();
     
        
    }
}
