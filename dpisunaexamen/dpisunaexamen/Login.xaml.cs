using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dpisunaexamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string password = "uisrael2023";

            if (txtUsuario.Text == usuario && txtPassword.Text == password)
            {
                Navigation.PushAsync(new Registro(usuario));
            }else
            {
                DisplayAlert("Alerta", "Uusuario Incorrecto", "OK");
            }

        }
    }
}