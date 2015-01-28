/*/
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MvvmLight_BaseClasses"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MvvmLight_BaseClasses.Model;
using MvvmLight_BaseClasses.ViewModel;

namespace MvvmLight_BaseClasses.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
   
        
           public static ViewModelLocator Instance
           {
               get
                {
                    return Application.Current.Resources["Locator"] as ViewModelLocator;
                }
           }
        


          
    
        public MainViewModel Main
        {
            get;
            private set;
        }
        
        public ViewModelLocator()
        {
            IMaterialDataService materialDataService;
            materialDataService = new MaterialDataService();
            Main = new MainViewModel(materialDataService); //, dialogService, navigationService);
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
