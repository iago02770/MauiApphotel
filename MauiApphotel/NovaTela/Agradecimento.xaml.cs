using Microsoft.Maui.Controls;

namespace MauiApphotel.Views
{
    public partial class Agradecimento : ContentPage
    {
        public Agradecimento()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para retornar à página anterior
            Navigation.PopAsync();
        }
    }
}
