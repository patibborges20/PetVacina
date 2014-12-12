using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PetVacina.Resources;
using PetVacina.Tudo;
using Microsoft.Phone.Tasks;

namespace PetVacina
{
    public partial class MainPage : PhoneApplicationPage
    {
        Pets Pets;
        public Pets PetEdit { get; set; }
        
        public MainPage()
        {
            InitializeComponent();
            AtualizarLista();
            DataContext = App.ViewModel;
        }

     
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            
              AtualizarLista();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
              NavigationService.Navigate(new Uri("/Tudo/Pets/PetsCadastro.xaml", UriKind.Relative));                   
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            if (Pets != null)
            {
                if (MessageBox.Show("Deseja excluir o pet "+Pets.NomePet+" ?", "Hey", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    PetsDB.Delete(Pets);
                    AtualizarLista();
                }          
            }
            else
            {
                MessageBox.Show("Selecione um Pet para Deletar");
            }
        }

        private void AtualizarLista()
        {
            List<Pets> lista = PetsDB.Get();
            listaPets.ItemsSource = lista;
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            editar page = e.Content as editar;

            if (page != null)
            {
                page.PetEdit= Pets;
            }      
        }

        private void OnSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            Pets = (sender as ListBox).SelectedItem as Pets;        
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Pets != null)
            {
                NavigationService.Navigate(new Uri("/Tudo/Pets/editar.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Selecione um Pet para Editar");
            }
       }

        private void Vacina_Click(object sender, EventArgs e)
        {
            if (Pets != null)
            {
                NavigationService.Navigate(new Uri("/Tudo/Vacina/Vacinas.xaml?idpet="+Pets.Id, UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Selecione um Pet para Editar");
            }                 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tudo/PanoramaPage1.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask review = new MarketplaceReviewTask();
            review.Show();
        }
    }
}