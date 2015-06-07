using System;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using System.Linq;
using OxyPlot;
using OxyPlot.Axes;
using System.Data.Linq;
using GalaSoft.MvvmLight.Command;
using MvvmLight_BaseClasses.Model;
using MvvmLight_BaseClasses;
using System.ComponentModel;
using OxyPlot.Annotations;
using OxyPlot.Series;

namespace MvvmLight_BaseClasses.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly ISelectedItemService _selectedItem;
        private readonly IMaterialDataService _materialDataService;
        public PlotModel plm { get; set; }

       
        #region Constructor


        public MainViewModel(
 IMaterialDataService materialDataService, ISelectedItemService SelectedItemService)
        {
            _materialDataService = materialDataService;
            _selectedItem = SelectedItemService;
            Materials = new ObservableCollection<MaterialData>();
            SideBarMaterials = new ObservableCollection<MaterialData>();
            //PlotModel PlotModel = new PlotModel();
            this.plm = TwoLineSeries();   





#if DEBUG
            if (IsInDesignMode)
            {
#pragma warning disable 1998
                Task.Run(() => Begin());
                MaterialSelected ms = new MaterialSelected();
                Transit tr = new Transit();
                Inventory inv = new Inventory();
                Incoming inc = new Incoming();
                Forecast fc = new Forecast();
                OrderChange oc = new OrderChange();
                tr.Qty = 2000; tr.Material = 8214517; tr.Offset = 2;
                ms.Transits.Add(tr);
                tr = new Transit();
                tr.Qty = 10000; tr.Material = 8214517; tr.Offset = 4;
                ms.Transits.Add(tr);

                inv = new Inventory();
                inv.Qty = 6000; inv.Material = 8214517;
                inv.Warehouse = 4911;
                ms.Inventorys.Add(inv);
                inv = new Inventory();
                inv.Qty = 18000; inv.Material = 8214517; inv.Warehouse = 4901;
                ms.Inventorys.Add(inv);

                fc = new Forecast();
                fc.Material = 8214517; fc.Offset = 3; fc.Qty = 10000;
                ms.Forecasts.Add(fc);

                inc.Material = 8214517; inc.Offset = 1; inc.Qty = 500;
                ms.Incomings.Add(inc);

                oc.Material = 8214517; oc.Offset = 3; oc.Qty = 900;
                ms.OrderChanges.Add(oc);

                SelectedMaterial = ms;

#pragma warning disable 1998



            }
#endif
        }

        
        #endregion


        #region DataSets
        private MaterialData _NavSelectedMaterial;
        public MaterialData NavSelectedMaterial
        {
            get
            { return _NavSelectedMaterial; }
            set
            {
                _NavSelectedMaterial = value;
                RefMaterials = Enumerable.Empty<int>();
                RefMaterials = SelectRefMaterials(value.Material);
                SelectItemCommand.Execute(null);

                // RaisePropertyChanged<MaterialSelected>("", SelectedMaterial, smat, true);
                //SelectedMaterial = _selectedItem.SelectItem(Materials.Where(mat => mat.RefMaterial == value.Material));


            }
        }

        public ObservableCollection<MaterialData> Materials
        {
            get;
            private set;
        }
        public ObservableCollection<MaterialData> SideBarMaterials
        {
            get;
            private set;
        }
        private MaterialSelected _selectedMaterial;
        public MaterialSelected SelectedMaterial
        {
            get
            {
                return _selectedMaterial;
            }
            set
            {
                _selectedMaterial = value;
            }
        }

        #endregion DataSets



        #region RelayCommand
        private RelayCommand _selectItemCommand;
        private IEnumerable<int> RefMaterials;

        public RelayCommand SelectItemCommand
        {
            get
            {
                return _selectItemCommand
                    ?? (_selectItemCommand = new RelayCommand(
                        async () =>
                        {
                            await SelectItem(RefMaterials);
                        }));
            }
        }

        private async Task<MaterialSelected> SelectItem(IEnumerable<int> refmats)
        {
            SelectedMaterial = new MaterialSelected();

            SelectedMaterial = await _selectedItem.SelectItem(refmats);  //smat;
            SelectedMaterial.Materials = new List<MaterialData>();
            foreach (MaterialData mat in Materials)
            {
                if (mat.RefMaterial == NavSelectedMaterial.Material)
                {
                    SelectedMaterial.Materials.Add(mat);
                }
            }
            //SelectedMaterial.Materials.AddRange(Materials.Where(p => p.RefMaterial == NavSelectedMaterial.Material));
            RaisePropertyChanged("SelectedMaterial");
            return SelectedMaterial;
        }

        private IEnumerable<int> SelectRefMaterials(int RefMaterial)
        {
            List<int> materials = new List<int>();

            IEnumerable<MaterialData> allmaterials = Materials.Where(mat => mat.RefMaterial == RefMaterial);
            materials.AddRange(allmaterials.Select(l => l.Material).ToList());
            return materials; //.AsEnumerable<int>();
        }

        #endregion SelectItem

        #region Begin

        private RelayCommand _beginCommand;

        public RelayCommand BeginCommand
        {
            get
            {
                return _beginCommand
                       ?? (_beginCommand = new RelayCommand(
                           async () =>
                           {
                               await Begin();
                           }));
            }
        }



        private async Task Begin()
        {
            Materials.Clear();
            var materials = await _materialDataService.Begin();
            foreach (var material in materials)
            {
                Materials.Add(material);
                if (material.RefMaterial == material.Material)
                {
                    SideBarMaterials.Add(material);
                }
            }

        }
        #endregion Begin
        public static PlotModel TwoLineSeries()
        {
            var plotModel1 = new PlotModel();
            plotModel1.Title = "Two LineSeries";
            plotModel1.PlotAreaBorderThickness = new OxyThickness(0);



            var rectangleAnnotation1 = new RectangleAnnotation();
            rectangleAnnotation1.MinimumY = 140;
            rectangleAnnotation1.MaximumY = 220;
            rectangleAnnotation1.Fill = OxyColor.FromArgb(30, 229, 139, 41);
            
            
            plotModel1.Annotations.Add(rectangleAnnotation1);

            var rectangleAnnotation2 = new RectangleAnnotation();
            rectangleAnnotation2.MinimumY = 180;
            rectangleAnnotation2.MaximumY = 285;
            rectangleAnnotation2.Fill = OxyColor.FromArgb(30, 53, 128, 12);
            
            
            
            plotModel1.Annotations.Add(rectangleAnnotation2);


            var cs1 = new CandleStickSeries
            {
                CandleWidth = 15,
                StrokeThickness = 2,
                DecreasingFill = OxyColor.FromAColor(60, OxyColor.FromRgb(120, 120, 144)),
                IncreasingFill = OxyColor.FromAColor(60, OxyColor.FromRgb(120, 120, 144))

            };

            cs1.Color = OxyColors.Black;
            double mininv = 120;
            double maxinv = 360;
            double begininv = 200;
            double orderchange = 260; // begin+change

            cs1.Items.Add(new HighLowItem(1, maxinv, mininv, begininv, orderchange));


            mininv = 120;
            maxinv = 360;
            begininv = 260;
            orderchange = 380; // begin+change

            cs1.Items.Add(new HighLowItem(2, maxinv, mininv, begininv, orderchange));


            mininv = 120;
            maxinv = 360;
            begininv = 300;
            orderchange = 320; // begin+change

            cs1.Items.Add(new HighLowItem(3, maxinv, mininv, begininv, orderchange));

            mininv = 120;
            maxinv = 360;
            begininv = 300;
            orderchange = 320; // begin+change

            cs1.Items.Add(new HighLowItem(6, maxinv, mininv, begininv, orderchange));

            mininv = 120;
            maxinv = 360;
            begininv = 300;
            orderchange = 320; // begin+change

            cs1.Items.Add(new HighLowItem(4, maxinv, mininv, begininv, orderchange));

            mininv = 120;
            maxinv = 360;
            begininv = 300;
            orderchange = 320; // begin+change

            cs1.Items.Add(new HighLowItem(5, maxinv, mininv, begininv, orderchange));
            plotModel1.Series.Add(cs1);
            var x = plotModel1.ToCode();
            return plotModel1;
        }
        
    }
}