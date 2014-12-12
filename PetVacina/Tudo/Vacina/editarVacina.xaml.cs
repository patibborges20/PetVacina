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
    public partial class editarVacina : PhoneApplicationPage
    {
        public Vacinacao VacinaEdit { get; set; }
        public editarVacina()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            txbNomeVacina.Text = VacinaEdit.NomeVacina;
            
        }


        private void salvarEditado_Click(object sender, RoutedEventArgs e)
        {
            VacinaEdit.NomeVacina = txbNomeVacina.Text;
            VacinaEdit.Data = txbDataVacinacao.Text;


            VacinacaoDB.Editar(VacinaEdit);
            MessageBox.Show(VacinaEdit.NomeVacina+" salvo com sucesso para a data "+ txbDataVacinacao.Text);

            NavigationService.GoBack();

        }

        private void datapicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            txbDataVacinacao.Text = VacinaEdit.Data;
            txbDataVacinacao.Text=((DateTime)datapicker.Value).ToShortDateString();
        }
    }
}