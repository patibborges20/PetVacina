using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace PetVacina.Tudo
{
    public partial class editar : PhoneApplicationPage
    {
        public Pets PetEdit{ get; set; }


        public editar()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

                txbNomePetEdit.Text = PetEdit.NomePet;
                txbBichoEdit.Text = PetEdit.Bicho;
                txbDonoEdit.Text = PetEdit.Dono;    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PetEdit.NomePet= txbNomePetEdit.Text;
            PetEdit.Dono = txbDonoEdit.Text;
            PetEdit.Bicho = txbBichoEdit.Text;
            

            PetsDB.Editar(PetEdit);
            MessageBox.Show(PetEdit.NomePet + " salvo com sucesso!");

            NavigationService.GoBack();
        }
    }
}

