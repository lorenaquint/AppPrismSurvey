using System;
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

			MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnInitialized()
		{
			throw new System.NotImplementedException();
		}
		protected  override void RegisterTypes()
		{
			throw new System.NotImplementedException();
		}

       
    }
}
