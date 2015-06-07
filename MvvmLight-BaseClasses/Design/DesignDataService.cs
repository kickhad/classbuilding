using System;
using MvvmLight_BaseClasses.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;

namespace MvvmLight_BaseClasses.Design
{
    public class DesignDataService : IMaterialDataService
    {
#pragma warning disable 1998
        public async Task<MaterialSelected> SelectItem()
        {
            return null;
        }

        public async Task<List<MaterialUsage>> PullUsages()
        {
            return null;
        }

        public Task<List<Forecast>> PullForecasts()
        {
            return null;
        }

        public Task<List<Incoming>> PullIncomings()
        {
            return null;
        }

        public Task<List<Inventory>> PullInventorys()
        {
            return null;
        }

        public Task<List<OrderChange>> PullOrderChanges()
        {
            return null;
        }
     

        public async Task<List<Transit>> PullTransits()
        {
            string json = @"{""Transit"":{ Material : 8214517, Offset : 0, Qty : 2000}}";
            var result = JsonConvert.DeserializeObject<ListOfTransit>(json);
            return result.Transits;
        }
     
     
       
        public async Task<IEnumerable<MaterialData>> Begin()
        {
            var json = @"{
   ""data"" : [
      {
         ""Amount"" : 335.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-C-S1T07BN"",
         ""CustomerMaterial"" : ""61/7251-0004"",
         ""ExtMaterial"" : 8691551,
         ""MFS"" : 150,
         ""Material"" : 5346561,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 20,
               ""Offset"" : 2,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S612"",
         ""PcWt"" : 147.44,
         ""PlCt"" : 130,
         ""Plant"" : 4,
         ""ProdHier."" : ""FBG"",
         ""Shape"" : ""SU645S24"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 19.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""AO-80MR5A"",
         ""CustomerMaterial"" : ""61/7251-0017"",
         ""ExtMaterial"" : 8578473,
         ""MFS"" : 150,
         ""Material"" : 5227057,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 1560,
               ""Offset"" : 2,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 650,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 11.21,
         ""PlCt"" : ""130"",
         ""Plant"" : 50,
         ""ProdHier."" : ""NGUKS"",
         ""Shape"" : ""S9X6X100"",
         ""TextLine"" : ""NONSTANDARDPACKAGINGREQD!"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 8.5,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-R-F6T10S"",
         ""CustomerMaterial"" : ""61/7251-0026"",
         ""ExtMaterial"" : 8693108,
         ""MFS"" : 150,
         ""Material"" : 5348118,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 4.33,
         ""PlCt"" : 300,
         ""Plant"" : 35,
         ""ProdHier."" : ""MGURO"",
         ""Shape"" : ""SU645H"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 9.77,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""AO-80MR5A"",
         ""CustomerMaterial"" : ""61/7251-0027"",
         ""ExtMaterial"" : 8646704,
         ""MFS"" : 150,
         ""Material"" : 5277996,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 5.603,
         ""PlCt"" : 270,
         ""Plant"" : 50,
         ""ProdHier."" : ""NGUKS"",
         ""Shape"" : ""S41/2X6X100"",
         ""TextLine"" : ""HalfBrick"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 1.31,
         ""BaseUnit"" : ""KG"",
         ""Brand"" : ""DIR-B82P-8-CD"",
         ""CustomerMaterial"" : ""61/7251-0028"",
         ""ExtMaterial"" : 8216868,
         ""MFS"" : 150,
         ""Material"" : 8216868,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""A952"",
         ""PcWt"" : 1.0,
         ""PlCt"" : 60,
         ""Plant"" : 41,
         ""ProdHier."" : ""NUSEH"",
         ""SalesUnit"" : ""KG"",
         ""Shape"" : ""25KGA952"",
         ""TextLine"" : """",
         ""UOM"" : ""KG""
      },
      {
         ""Amount"" : 16.7,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-R-F6T07SS"",
         ""CustomerMaterial"" : ""61/7251-0029"",
         ""ExtMaterial"" : 8692430,
         ""MFS"" : 150,
         ""Material"" : 5347446,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 3000,
               ""Offset"" : 1,
               ""Plant"" : 4921,
               ""Transit"" : 3000
            },
            {
               ""Incoming"" : 3000,
               ""Offset"" : 2,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 2550,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 9.27,
         ""PlCt"" : 150,
         ""Plant"" : 35,
         ""Predecessor"" : ""@BF@"",
         ""ProdHier."" : ""MGURN"",
         ""Shape"" : ""SU645"",
         ""TextLine"" : ""BarrelBrick"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 24.1,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-R-F6T18AS"",
         ""CustomerMaterial"" : ""61/7251-0032"",
         ""ExtMaterial"" : 8692017,
         ""MFS"" : 130,
         ""Material"" : 5347034,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 2800,
               ""Offset"" : 3,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 2576,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 2576,
               ""Offset"" : 6,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 12.080,
         ""PlCt"" : 112,
         ""Plant"" : 35,
         ""Predecessor"" : ""@BF@"",
         ""ProdHier."" : ""MGURO"",
         ""Shape"" : ""K15X3X6-51/4"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 5.8,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RE-B65-M"",
         ""CustomerMaterial"" : ""61/7251-0039"",
         ""ExtMaterial"" : 8535020,
         ""MFS"" : 150,
         ""Material"" : 5161015,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 5.060,
         ""PlCt"" : 248,
         ""Plant"" : 44,
         ""ProdHier."" : ""NGGBO"",
         ""Shape"" : ""S9X41/2X3"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 5.6,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RE-B65-M"",
         ""CustomerMaterial"" : ""61/7251-0040"",
         ""ExtMaterial"" : 8577050,
         ""MFS"" : 150,
         ""Material"" : 5205760,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 4.775,
         ""PlCt"" : 248,
         ""Plant"" : 44,
         ""ProdHier."" : ""NGGBO"",
         ""Shape"" : ""K9X3X41/2-4"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 5.75,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RE-B65-M"",
         ""CustomerMaterial"" : ""61/7251-0041"",
         ""ExtMaterial"" : 8617301,
         ""MFS"" : 150,
         ""Material"" : 5247716,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 248,
               ""Offset"" : 3,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 1736,
               ""Offset"" : 5,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 248,
               ""Offset"" : 7,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 4.953,
         ""PlCt"" : 248,
         ""Plant"" : 44,
         ""ProdHier."" : ""NGGBO"",
         ""Shape"" : ""A9X3X41/2N40"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 1.2,
         ""BaseUnit"" : ""KG"",
         ""Brand"" : ""DID-B83-6-CD"",
         ""CustomerMaterial"" : ""61/7251-0043"",
         ""ExtMaterial"" : 8216904,
         ""MFS"" : 150,
         ""Material"" : 8216904,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""A055"",
         ""PcWt"" : 1,
         ""PlCt"" : 60,
         ""Plant"" : 41,
         ""ProdHier."" : ""NUCCH"",
         ""SalesUnit"" : ""KG"",
         ""Shape"" : "">>>>25KGA055"",
         ""TextLine"" : """",
         ""UOM"" : ""KG""
      },
      {
         ""Amount"" : 1.19,
         ""BaseUnit"" : ""KG"",
         ""Brand"" : ""DID-B83-6-CD"",
         ""CustomerMaterial"" : ""61/7251-0044"",
         ""ExtMaterial"" : 8216905,
         ""MFS"" : 150,
         ""Material"" : 8216905,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""A902"",
         ""PcWt"" : 1,
         ""PlCt"" : 3,
         ""Plant"" : 41,
         ""ProdHier."" : ""NUCCH"",
         ""SalesUnit"" : ""KG"",
         ""Shape"" : ""454KGA902"",
         ""TextLine"" : ""NoSpout"",
         ""UOM"" : ""KG""
      },
      {
         ""Amount"" : 1.76,
         ""BaseUnit"" : ""KG"",
         ""Brand"" : "">>>>DID-A94-6-CD"",
         ""CustomerMaterial"" : ""61/7251-0045"",
         ""ExtMaterial"" : 8217530,
         ""MFS"" : 150,
         ""Material"" : 8217530,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""A055"",
         ""PcWt"" : 1,
         ""PlCt"" : 60,
         ""Plant"" : 41,
         ""ProdHier."" : ""NUCCH"",
         ""SalesUnit"" : ""KG"",
         ""Shape"" : ""25KGA055"",
         ""TextLine"" : """",
         ""UOM"" : ""KG""
      },
      {
         ""Amount"" : 1.74,
         ""BaseUnit"" : ""KG"",
         ""Brand"" : ""DID-A94-6-CD"",
         ""CustomerMaterial"" : ""61/7251-0046"",
         ""ExtMaterial"" : 8217531,
         ""MFS"" : 150,
         ""Material"" : 8217531,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""A923"",
         ""PcWt"" : 1,
         ""PlCt"" : 3,
         ""Plant"" : 41,
         ""ProdHier."" : ""NUCCH"",
         ""SalesUnit"" : ""KG"",
         ""Shape"" : ""454KGA923"",
         ""TextLine"" : """",
         ""UOM"" : ""KG""
      },
      {
         ""Amount"" : 4.6,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RE-M60-M"",
         ""CustomerMaterial"" : ""61/7251-0101"",
         ""ExtMaterial"" : 8555657,
         ""MFS"" : 150,
         ""Material"" : 5183381,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : """",
         ""PcWt"" : 4.070,
         ""PlCt"" : 310,
         ""Plant"" : 44,
         ""ProdHier."" : ""NGGHM"",
         ""Shape"" : ""S9X41/2X21/2"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 19.8,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-R-F2T10SSS"",
         ""CustomerMaterial"" : ""61/7251-0670"",
         ""ExtMaterial"" : 8692018,
         ""MFS"" : 150,
         ""Material"" : 5347035,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 1500,
               ""Offset"" : 1,
               ""Plant"" : 4921,
               ""Transit"" : 1500
            },
            {
               ""Incoming"" : 1500,
               ""Offset"" : 2,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 1500,
               ""Offset"" : 3,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 1050,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : """",
         ""PcWt"" : 9.24,
         ""PlCt"" : 150,
         ""Plant"" : 35,
         ""Predecessor"" : ""@BF@"",
         ""ProdHier."" : ""MGURF"",
         ""Shape"" : ""SU645"",
         ""TextLine"" : ""SlagLine"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 15.38,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RX-60S-D"",
         ""CustomerMaterial"" : ""61/7259-4201"",
         ""ExtMaterial"" : 8651995,
         ""MFS"" : 150,
         ""Material"" : 5315323,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 360,
               ""Offset"" : 0,
               ""Plant"" : 4921,
               ""Transit"" : 240
            },
            {
               ""Incoming"" : 480,
               ""Offset"" : 2,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 360,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 360,
               ""Offset"" : 6,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : ""S691"",
         ""PcWt"" : 12.736,
         ""PlCt"" : 120,
         ""Plant"" : 50,
         ""ProdHier."" : ""MGGMA"",
         ""Shape"" : ""S131/2X6X3"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 4.75,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""RX-60S-D"",
         ""CustomerMaterial"" : ""61/7260-0804"",
         ""ExtMaterial"" : 8652085,
         ""MFS"" : 150,
         ""Material"" : 5315324,
         ""MonthlyBuckets"" : [
            {
               ""Incoming"" : 589,
               ""Offset"" : 4,
               ""Plant"" : 4921,
               ""Transit"" : 0
            },
            {
               ""Incoming"" : 589,
               ""Offset"" : 6,
               ""Plant"" : 4921,
               ""Transit"" : 0
            }
         ],
         ""PackKey"" : """",
         ""PcWt"" : 2.656,
         ""PlCt"" : 589,
         ""Plant"" : 50,
         ""ProdHier."" : ""MGGMA"",
         ""Shape"" : ""S9X41/2X11/4"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 396.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""AFO-94MG-6-CD"",
         ""CustomerMaterial"" : ""61/7265-0009"",
         ""ExtMaterial"" : 8632209,
         ""MFS"" : 150,
         ""Material"" : 5263046,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""F245"",
         ""PcWt"" : 147.854,
         ""PlCt"" : 4,
         ""Plant"" : 41,
         ""ProdHier."" : ""FSLH"",
         ""Shape"" : ""SD1137"",
         ""TextLine"" : ""WellBlock"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 353.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""AFO-94MG-6-CD"",
         ""CustomerMaterial"" : ""61/7265-0010"",
         ""ExtMaterial"" : 8632208,
         ""MFS"" : 150,
         ""Material"" : 5263045,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : ""F245"",
         ""PcWt"" : 133.46,
         ""PlCt"" : 4,
         ""Plant"" : 41,
         ""ProdHier."" : ""FPL"",
         ""Shape"" : ""SLP007"",
         ""TextLine"" : ""PurgeBlock"",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 15.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""AC-F6T18AS"",
         ""CustomerMaterial"" : ""61/7251-0033"",
         ""ExtMaterial"" : 8617514,
         ""MFS"" : 130,
         ""Material"" : 5306283,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : """",
         ""PcWt"" : 9.76,
         ""PlCt"" : 120,
         ""Plant"" : 35,
         ""Predecessor"" : ""@BF@"",
         ""ProdHier."" : ""MGUKM"",
         ""Shape"" : ""K12X3X6-51/4"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 0.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : """",
         ""CustomerMaterial"" : ""TRIAL"",
         ""ExtMaterial"" : 8708320,
         ""MFS"" : 150,
         ""Material"" : 5364136,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : """",
         ""PcWt"" : 17.2,
         ""PlCt"" : 0,
         ""Plant"" : 8,
         ""Predecessor"" : ""@BF@"",
         ""ProdHier."" : ""FPP"",
         ""Shape"" : ""N920EX001SDIP-80/E"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 0.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-C-F2T12SS"",
         ""CustomerMaterial"" : ""TRIAL"",
         ""ExtMaterial"" : 8712869,
         ""MFS"" : 150,
         ""Material"" : 5368737,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : """",
         ""PcWt"" : 9.18,
         ""PlCt"" : 0,
         ""Plant"" : 35,
         ""ProdHier."" : ""MGUCD"",
         ""Shape"" : ""SU645"",
         ""TextLine"" : """",
         ""UOM"" : ""PC""
      },
      {
         ""Amount"" : 0.0,
         ""BaseUnit"" : ""PC"",
         ""Brand"" : ""SY-C-F6T07SS"",
         ""CustomerMaterial"" : ""TRIAL"",
         ""ExtMaterial"" : 8712870,
         ""MFS"" : 150,
         ""Material"" : 5368738,
         ""MonthlyBuckets"" : [],
         ""PackKey"" : """",
         ""PcWt"" : 9.211,
         ""PlCt"" : 0,
         ""Plant"" : 35,
         ""ProdHier."" : ""MGUCN"",
         ""Shape"" : ""SU645"",
         ""TextLine"" : ""BarrelBrick"",
         ""UOM"" : ""PC""
      }
   ]
}
";
            var result = JsonConvert.DeserializeObject<ListOfMaterialData>(json);
            return result.Data;
        }
#pragma warning disable 1998
    }
}