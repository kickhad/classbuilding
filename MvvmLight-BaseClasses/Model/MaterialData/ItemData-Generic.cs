using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmLight_BaseClasses.MaterialData
{
    public class GenericItemData
    {
        
        public double _pcwt;
        private int _material;
        private string _brand;
        private string _shape;
        private int _materialExternal;
        
        public GenericItemData()
        {
            throw new NotImplementedException();
            //fetch item data from material
            //just material is sufficent as this info doesn't change
        }
        public double PcWt
        {
            get{return _pcwt;}
        }
       public int Material
        {
            get { return _material; }
        }
       public int MaterialExternal
       {
           get { return _materialExternal; }
       }
       public string Brand
       {
           get { return _brand; }
       }
        public string Shape
       {
           get { return _shape; }
       }

    }
}
