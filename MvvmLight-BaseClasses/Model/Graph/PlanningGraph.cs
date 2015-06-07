using GalaSoft.MvvmLight;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Annotations;

namespace MvvmLight_BaseClasses.Model
{
    public class PlanningGraph
    {
       
        public static string ConsoleGraph()
        { /*
           * 
Constructor
           ??? Dictionary not array?
           * 
           WITH SelectedMaterial
           
           x[-1]        := .Inventorys[0]
           Avg          := .MaterialUsage.Avg6
           t_fc[n,q]    := .Forecasts.ToArray(offset,Qty)
           t_inc[n,q]   := .Inventorys.ToArray(offset,Qty)
           Min/Max      := .MaterialUsage.Min/Max
           
           
             
              
              
             
             
           if t_fc[n.upboud] > t_inc[n.upbond] 
           ELSE 
                UB == t_inc[n.upbound]
            
           for(int x 0 to UB)
                IF EXIST t_inc[x]
                    inc[x] = t_inc[qty]
                ELSE
                    inc[x] = 0
           
           for(int x 0 to UB)
                IF EXIST t_fc[x]
                    fc[x] = fc[qty]
                ELSE
                    fc[x] = 0
            
             
    
    Projected inventory                            
               Case Averages:
                   Consumption = const con
                  x[-1] = Current Inv - all locations
                  
                   For x [0 to n]
                      FixedInv  := x[n-1]      --- Bottom of Candle Box
                      TopBox    := x[n-1] + Incoming[n]
                       x[n]      := TopBox - Avg*n
             
             * 
             * 
             *  Case Forecast
             *  Consuption = Arry fc[]
             *  For x = [0 to n]
             *      FixedInv    :=  x[n-1]
             *      TopBox      :=  x[n-1] + Incoming[n]
             *      x[n]        :=  TopBox - Σ(fc[n])
             *      
             * Update
           * 
           * 
           * 
           * 
           * for(x = 0 to UB)
           *    cs.Items.Add(new HighLowItem(x,TopBox[x],FixedInv[x],Mix,Max)) 
    
                 */


            return null;
        }

    }
}
