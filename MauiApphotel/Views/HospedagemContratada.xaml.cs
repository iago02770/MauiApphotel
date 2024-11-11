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
            // Lógica para retornar à página anterior
            Navigation.PopAsync();
        }

        private async void OnNavigateToAgradecimentoClicked(object sender, EventArgs e)
        {
            // Lógica para navegar para a página de agradecimento
            await Navigation.PushAsync(new Agradecimento());
        }
    }
}

