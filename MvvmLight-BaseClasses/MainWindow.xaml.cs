using System.Windows;
using System.Windows.Controls.Primitives;
using MvvmLight_BaseClasses.ViewModel;
using MvvmLight_BaseClasses.Model;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using System;
using System.Windows.Controls;

namespace MvvmLight_BaseClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var vm = (MainViewModel)DataContext;
            vm.BeginCommand.Execute(null);
            
            
 //4           Closing += (s, e) => ViewModelLocator.Cleanup();
            
        }
#pragma warning disable 1998
        private async void RefreshClick(object sender, EventArgs e)
        {
            var vm = (MainViewModel)DataContext;            
            vm.BeginCommand.Execute(null);
           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

      

       
        //private void SelectMaterialCommand(object sender, EventArgs s)
        //{
        //    var vm = (MainViewModel)DataContext;
        //    vm.SelectMaterialCommand.Execute(null);
            

          
        //}
#pragma warning disable 1998
    }
}