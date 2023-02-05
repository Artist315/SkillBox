using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Week9.Task1.View;
using Week9.Task1.ViewModel;

namespace Week9.Task1
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
