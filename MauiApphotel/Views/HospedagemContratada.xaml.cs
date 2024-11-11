using Microsoft.Maui.Controls;

namespace MauiApphotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // L�gica para retornar � p�gina anterior
            Navigation.PopAsync();
        }

        private async void OnNavigateToAgradecimentoClicked(object sender, EventArgs e)
        {
            // L�gica para navegar para a p�gina de agradecimento
            await Navigation.PushAsync(new Agradecimento());
        }
    }
}

