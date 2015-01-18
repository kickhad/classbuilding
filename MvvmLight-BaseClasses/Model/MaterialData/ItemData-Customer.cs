using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmLight_BaseClasses.MaterialData
{
    public class CustomerItemData
    {
        private int _mfs;
        private string _custnum;
        private int _refMaterial;
        private List<int> _warehouse;
        private List<int> _pplant;
        private ItemStatus _status;

        public ItemStatus Status
        {
            get { return _status}
        }
        public int MFS
        {
            get { return _mfs; }
        }

        public List<int> Pplant
        {
            get { return _pplant; }
        }
        public List<int> Warehouse
        {
            get { return _warehouse; }
        }
        public int RefMaterial
        {
            get { return _refMaterial; }
        }

        public string CustomerItemNumber
        {
            get { return _custnum; }
        }

    }
}
