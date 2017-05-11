using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismTest.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        protected INavigationService _navigationService;
        public DelegateCommand NavigateToMainPageCommand { get; private set; }
        public DelegateCommand NavigateToCategoriaPageCommand { get; private set; }

        public void InicializaNavegacao(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateToMainPageCommand = new DelegateCommand(NavigateToMainPage);
            NavigateToCategoriaPageCommand = new DelegateCommand(NavigateToCategoriaPage);

        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        protected void NavigateToMainPage()
        {
            _navigationService.NavigateAsync("MainPage");
        }
        protected void NavigateToCategoriaPage()
        {
            _navigationService.NavigateAsync("CategoriaPage");
        }


    }
}
