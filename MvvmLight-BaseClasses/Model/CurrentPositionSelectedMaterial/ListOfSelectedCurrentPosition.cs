﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvvmLight_BaseClasses.Model
{
   
    public class ListOfSelectedCurrentPosition
    { 
        [JsonProperty("data")]
        public List<MaterialData> Data
        {
            get;
            set;
        }
        public class MonthlyBucket
        {

        }
        [JsonProperty("MonthlyBuckets")]
        public List<MonthlyBucket> MonthlyBuckets
        {
            get;
            set;

        }
    }
} 