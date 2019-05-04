using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appf
{
    public partial class Pagina3 : ContentPage
    {
        public Command SeguirCommand { get; set; }

        public Pagina3()
        {
            Title = "Página 3";
            InitializeComponent();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Pagina4());
        }
    }
}
