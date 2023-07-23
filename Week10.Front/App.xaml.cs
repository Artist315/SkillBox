using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Week10.Front.View;
using Week10.Front.ViewModel;

namespace Week10.Front
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // delete the startupuri tag from your app.xaml
            base.OnStartup(e);
            //this MainViewModel from your ViewModel project
            MainWindow = new MainWindowView(new MainWindowVM());
        }
    }
}
