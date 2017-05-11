using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using PrismTest.Models;
using PrismTest.Servicos;

namespace PrismTest.ViewModels
{
    public class SubCategoriaPageViewModel : BaseViewModel, INavigationAware
    {
        public List<SubCategoria> SubCategorias { get; set; }
        //public ObservableCollection<SubCategoria> SubCategorias { get; set; }
        public Command ItemTappedCommand { get; set; }

        public SubCategoriaPageViewModel(INavigationService navigationService)
        {
            Title = "Subcategorias";
            InicializaNavegacao(navigationService);
            this.ItemTappedCommand = new Command<SubCategoria>(async item =>
            {
                await App.Current.MainPage.DisplayAlert("SubCategoria", item.NomeSubCategoria.ToString(), "Ok");
            });


        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            int idCategoria;
            if (parameters.ContainsKey("Categoria"))
            {
                idCategoria = (int)parameters["Categoria"];
                var _subCategorias = new PopulaListaSubCategorias().Popula().Where(x => x.IdCategoria == idCategoria);

                foreach (var sc in _subCategorias)
                {
                    SubCategorias.Add(sc);
                }
            }
        }
    }
}
