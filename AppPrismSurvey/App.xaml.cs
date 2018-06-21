using System;
using AppPrismSurvey.View;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppPrismSurvey
{
	public partial class App:PrismApplication
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new SurveysView());
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<SurveysView>();
            containerRegistry.RegisterForNavigation<SurveyDetailsView>();
        }

        protected override async void OnInitialized()
        {


            //await NavigationService.NavigateAsync("NavigationPage/MainPage"); 
            await NavigationService.NavigateAsync($"{nameof(RootNavigationView)} / {nameof(SurveysView)}");
        }


    }
}
