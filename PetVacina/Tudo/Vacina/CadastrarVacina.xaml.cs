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
    public partial class CadastrarVacina : PhoneApplicationPage
    {
       public int idpet;

        public CadastrarVacina()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            String parametroRecebido;
            if (NavigationContext.QueryString.TryGetValue("idpet", out parametroRecebido))
            {
                idpet = Convert.ToInt32(parametroRecebido);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vacinacao vacina = new Vacinacao
            {   
                NomeVacina = txbNomeVacina.Text,
                Data= txbData.Text,
                IdPets=idpet
            };
            VacinacaoDB.Save(vacina);
            MessageBox.Show("Vacina Cadastrada para o dia "+txbData.Text);
            NavigationService.GoBack();
        }

        private void dptdata_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            
        }

        private void datapicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            txbData.Text = ((DateTime)datapicker.Value).ToShortDateString();
        }

    }
}