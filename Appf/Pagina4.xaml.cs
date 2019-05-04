using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appf
{
    public partial class Pagina4 : ContentPage
    {
        public Pagina4()
        {
            Title = "Página 4";
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}
