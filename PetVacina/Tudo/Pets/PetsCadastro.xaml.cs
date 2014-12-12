using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PetVacina.Tudo
{
    public partial class PetsCadastro : PhoneApplicationPage
    {
        public PetsCadastro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pets Pets = new Pets
            {
                NomePet = txbNomePet.Text,
                Bicho= txbBicho.Text,
                Dono=txbDono.Text
            };
            PetsDB.Save(Pets);
            MessageBox.Show("Pet Cadastrado!");
            NavigationService.GoBack();
        }

      

      
    }
}