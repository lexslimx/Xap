using Prism;
using Prism.Ioc;
using Xap.ViewModels;
using Xap.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xap.Data.Database;
using System.IO;
using System;

namespace Xap
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        ISimsDatabase database = new SimsDatabase();

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            if (database == null)
            {
                database = new SimsDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SimsDb.db3"));
            }

            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ScanPage, ScanPageViewModel>();
            containerRegistry.RegisterForNavigation<CheckInPage, CheckInPageViewModel>();
            containerRegistry.RegisterForNavigation<HistoryPage, HistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegistrationPage, RegistrationPageViewModel>();

            containerRegistry.RegisterInstance<ISimsDatabase>(database);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
