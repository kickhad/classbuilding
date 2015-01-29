using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight_BaseClasses.Model;
using MvvmLight_BaseClasses;

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
        private readonly IMaterialDataService _materialDataService;
        //private readonly IDialogService _dialogService;
        //private readonly INavigationService _navigationService;

        private RelayCommand _beginCommand;
        private RelayCommand<MaterialData> _selectMaterialCommand;
        
        //private RelayCommand<Friend> _saveCommand;
        //private RelayCommand<Friend> _showDetailsCommand;

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
        
        //public RelayCommand<MaterialData> SelectMaterialCommand
        //{
        //    get
        //    {
        //        return _selectMaterialCommand
        //            ?? (_selectMaterialCommand = new RelayCommand<MaterialData>(
        //                                  material =>
        //                                  {
        //                                     SelectedMaterial = material;
                                              
        //                                  }));
        //    }
        //}
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
        


#if DEBUG
            if (IsInDesignMode)
            {
                Begin();
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
    
        //public ObservableCollection<MaterialData> ItemDatas { get; private set; }

        //private MaterialData _SelectedItemData;
        //private RelayCommand _BeginRelayCommand;

        //private async Task Begin()
        //{
            
        //}
        //public RelayCommand BeginRelayCommand
        //{
        //    get
        //    {
        //        return _BeginRelayCommand
        //               ?? (_BeginRelayCommand = new RelayCommand(
        //                   async () =>
        //                   {
        //                       await Begin();
        //                   }));
        //    }
        //}
        //public MaterialData SelectedItemData
        //{
        //    get { return _SelectedItemData; }
        //    set { Set(() => SelectedItemData, ref _SelectedItemData, value); }

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