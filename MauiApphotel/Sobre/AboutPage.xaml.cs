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
            // L�gica para retornar � p�gina anterior
            Navigation.PopAsync();
        }
    }
}

