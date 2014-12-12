using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PetVacina.Tudo;

namespace PetVacina.Tudo
{

    public partial class Vacinas : PhoneApplicationPage
    {
        Vacinacao Vacina;
        public Vacinacao VacinaEdit { get; set; }
        public Pets Pet { get; set; }
        public int idpet;
        public Vacinas()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            String parametroRecebido;
           if (NavigationContext.QueryString.TryGetValue("idpet", out parametroRecebido))
             {
                 idpet=Convert.ToInt32(parametroRecebido);
                 AtualizarLista(idpet);
             }
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tudo/Vacina/CadastrarVacina.xaml?idpet="+idpet, UriKind.Relative));//criar pag
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            if (Vacina!= null)
            {
                if (MessageBox.Show("Deseja excluir a vacina "+Vacina.NomeVacina+"? ", "Hey..", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    VacinacaoDB.Delete(Vacina);
                    AtualizarLista(idpet);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma vacina para Deletar");
            }
        }


        public void AtualizarLista( int idPet)
        {

            if (ListaVacina == null)
           {
               var result = MessageBox.Show("Nenhuma Vacina cadastrada, Deseja cadastrar? ", "Hey..", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                   NavigationService.Navigate(new Uri("/Tudo/Vacina/CadastrarVacina.xaml?idpet="+idpet, UriKind.Relative));
                }
            }
            else
            {
                List<Vacinacao> lista = VacinacaoDB.Get(idPet);
                ListaVacina.ItemsSource = lista;
            }
            
        }

        private void OnSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            Vacina = (sender as ListBox).SelectedItem as Vacinacao;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Vacina != null)
            {
                NavigationService.Navigate(new Uri("/Tudo/Vacina/editarVacina.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Selecione uma vacina para Editar");
            }
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            editarVacina page = e.Content as editarVacina;
            
            if (page != null)
            {
                page.VacinaEdit = Vacina;
            }
        }


    }
}
