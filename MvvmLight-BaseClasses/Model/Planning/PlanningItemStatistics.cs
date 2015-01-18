using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmLight_BaseClasses.Model.Planning
{
    public class ItemStatistics
    {
        /// <summary>
        /// from SCOPE
        /// </summary>
        private double _avg3mo;
        /// <summary>
        /// from SCOPE
        /// </summary>
        private double _avg6month;
        /// <summary>
        /// from SCOPE
        /// </summary>
        private double _avg9month;
        /// <summary>
        /// from SCOPE
        /// </summary>
        private double _avg12month;
        /// <summary>
        /// Highest in 12 months
        /// </summary>
        private int _maxUse;
        /// <summary>
        /// Lowest
        /// </summary>
        private int _minNaturalNumber;
        /// <summary>
        /// n12 monthson zero in
        /// </summary>
        private int _countNullMonths;
    
        public int Index
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
