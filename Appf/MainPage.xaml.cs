using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Appf
{

    public partial class MainPage : ContentPage
    {
        public String Email { get; set; }
        public String Senha { get; set; }
        public Command EntrarCommand { get; set; }


        public MainPage()
        {
            BindingContext = this; //qual classe representa seu contexto para binding

            //inicialização de propriedades
            Email = "evandro.oliveira.com.br";
            EntrarCommand = new Command(Entrar);

            InitializeComponent();
        }

        async void Entrar()
        {
           //await Task.Delay(5000).Wait();

            var texto = Email + "\r\n" + Senha;

            if (Email == "evandro.oliveira.com.br" && Senha == "teste")
            {
                Application.Current.MainPage = new NavigationPage(new Pagina3());
            } else
            {
                await DisplayAlert("Você digitou", Email + ":" + Senha, "OK");
            }




        }
    }
}
