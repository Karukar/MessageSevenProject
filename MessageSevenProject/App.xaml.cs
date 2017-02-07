using MessageSevenProject.Service_Clients.Class;
using MessageSevenProject.Service_Clients.Interface;
using MessageSevenProject.View;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MessageSevenProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IKernel Container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Configuration();
            ComposeObject();
            Application.Current.MainWindow.Show();

        }

        public void Configuration()
        {
            Container = new StandardKernel();
            Container.Bind<IMessageSevenService>().To<MessageSevenService>().InSingletonScope();
        }

        private void ComposeObject()
        {
            Application.Current.MainWindow = Container.Get<MainWindow>();
        }
    }
}
