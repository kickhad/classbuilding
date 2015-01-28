using System.Windows;
using MvvmLight_BaseClasses.ViewModel;
using MvvmLight_BaseClasses.Model;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using System;

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
            
 //4           Closing += (s, e) => ViewModelLocator.Cleanup();
            
        }
        private async void RefreshClick(object sender, EventArgs e)
        {
            var vm = (MainViewModel)DataContext;
            
            vm.RefreshCommand.Execute(null);
        }
    }
}