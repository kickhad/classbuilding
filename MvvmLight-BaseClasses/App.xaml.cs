using System.Windows;
using GalaSoft.MvvmLight.Threading;
using MvvmLight_BaseClasses.Model;

namespace MvvmLight_BaseClasses
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //THIS MAY WORK WITH FRAME AS HOST FOR NAV Public static PhoneApplicationFrame RootFrame
        //{
        //    get;
        //    private set;
        //}
       
        static App()
        {
            DispatcherHelper.Initialize();
        }

    }
}
