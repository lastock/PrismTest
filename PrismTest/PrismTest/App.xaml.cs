using Prism.Unity;
using PrismTest.Views;
using Xamarin.Forms;

namespace PrismTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=PrismTest%20with%20Custom%20ListView");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<CategoriaPage>();
            Container.RegisterTypeForNavigation<SubCategoriaPage>();
        }
    }
}
