using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_BaseClasses.Model.Planning
{
    class PlanningItem
    // There are cases where >1 materials need to be counted together. For this purpouse, for forecast
        // consumption, planning, etc. A 'Reference Material' is selected for grouping. Typically the current 
        // or active item is suggested. 
    {
        private PlanningItemForecast _fc;
        private PlanningItemHorizon _horizon;

        public PlanningItemForecast Forecast
        {
            get { return _fc; }
        }
        public PlanningItemHorizon Horizon
        {
            get { return _horizon; }
        }


    }
}
