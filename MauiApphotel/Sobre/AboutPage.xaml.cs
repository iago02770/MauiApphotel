using Microsoft.Maui.Controls;

namespace MauiApphotel.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Lógica para retornar à página anterior
            Navigation.PopAsync();
        }
    }
}

