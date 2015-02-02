using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using System.Linq;
using System.Data.Linq;
using GalaSoft.MvvmLight.Command;
using MvvmLight_BaseClasses.Model;
using MvvmLight_BaseClasses;
using System.Windows.Data;
using System.ComponentModel;

namespace MvvmLight_BaseClasses.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ICollectionView phraseView;
        private readonly IMaterialDataService _materialDataService;
        //private readonly IDialogService _dialogService;
        //private readonly INavigationService _navigationService;

        private RelayCommand _beginCommand;
       
        public ObservableCollection<MaterialData> Materials
        {
            get;
            private set;
        }

        public RelayCommand RefreshCommand
        {
            get
            {
                return _beginCommand
                       ?? (_beginCommand= new RelayCommand(
                           async () =>
                           {
                               await Begin();
                           }));
            }
        }
        
        private MaterialData _selectedMaterial;
        public MaterialData SelectedMaterial
        {
            get
            {
                return _selectedMaterial;
            }
            set
            {
                Set(() => SelectedMaterial, ref _selectedMaterial, value);
                RaisePropertyChanged(() => SelectedMaterial);
            }
        }
        public MainViewModel(
           IMaterialDataService materialDataService)
        //IDialogService dialogService,
        //INavigationService navigationService)
        {
            _materialDataService = materialDataService;
            //_dialogService = dialogService;
            //_navigationService = navigationService;
            Materials = new ObservableCollection<MaterialData>();

           
            this.SelectedMaterialsInternal = new ObservableCollection<MaterialData>();
            this.SelectedMaterials = new CollectionViewSource();
            this.SelectedMaterials.Source = this.SelectedMaterialsInternal;
            RefreshCommand.Execute(null);
            



#if DEBUG
            if (IsInDesignMode)
            {
                Begin();
                //SelectedMaterial = Materials[0];
               
            }
#endif
        }

        private async Task Begin()
        {
            Materials.Clear();

            var materials = await _materialDataService.Begin();

            foreach (var material in materials)
            {
                Materials.Add(material);
                
            }                     
        }
        public CollectionViewSource SelectedMaterials { get; set; }

        private ObservableCollection<MaterialData> SelectedMaterialsInternal { get; set; }

        //}   
        //    /// <summary>
        ///// Initializes a new instance of the MainViewModel class.
        ///// </summary>
        //public MainViewModel()
        //{
        //    //if (IsInDesignMode)
        //    ////{
        //    ////    // Code runs in Blend --> create design time data.
        //    ////}
        //    //else
        //    //{
        //       //  = _planningViewModel;
        //    //}
        //}

       
    
}
}