using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_BaseClasses.Model
{
    public interface IMaterialDataService 
    {
        Task<IEnumerable<MaterialData>> Begin();
    }
}
