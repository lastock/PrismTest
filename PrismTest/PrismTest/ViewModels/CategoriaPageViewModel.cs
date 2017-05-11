using System.Collections.Generic;
using PrismTest.Models;
using System.Collections.ObjectModel;
using Prism.Navigation;
using PrismTest.Servicos;
using Xamarin.Forms;

namespace PrismTest.ViewModels
{
    public class CategoriaPageViewModel : BaseViewModel
    {
        public List<Categoria> Categorias { get; set; }
        //public ObservableCollection<Categoria> Categorias { get; set; }
        public Command ItemTappedCommand { get; set; }

        public CategoriaPageViewModel(INavigationService navigationService)
        {
            Title = "Categorias";
            InicializaNavegacao(navigationService);
            PopulaLista();
            this.ItemTappedCommand = new Command<Categoria>(item =>
            {
                _navigationService.NavigateAsync($"SubCategoriaPage?Categoria={item.IdCategoria}");
            });

        }

        private void PopulaLista()
        {
            var _categorias = new PopulaListaCategorias().Popula();


            foreach (var categoria in _categorias)
            {
                Categorias.Add(categoria);
            }
        }

    }
}
