using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PetVacina
{
    public partial class Page1 : PhoneApplicationPage
    {
        SettingsManager SettingsManager;
        int TimesAppOpened;
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

                SettingsManager = new SettingsManager();
                TimesAppOpened = SettingsManager.GetValue("TimesAppOpened", 1);
               
            
            SettingsManager.SetValue("TimesAppOpened", TimesAppOpened + 1);

            if (TimesAppOpened == 5)
            {
                var result = MessageBox.Show("O PET VACINA se importa com a sua opnião? Que tal avaliar ele na loja?", "Availação",
                                                    MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    MarketplaceReviewTask review = new MarketplaceReviewTask();
                    review.Show();
                    SettingsManager.SetValue("TimesAppOpened", TimesAppOpened + 1);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}