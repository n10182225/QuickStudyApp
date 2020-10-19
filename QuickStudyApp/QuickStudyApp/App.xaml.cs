using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Services;
using QuickStudyApp.Views;

namespace QuickStudyApp
{
    public partial class App : Application
    {
        internal static readonly string FolderPath;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
