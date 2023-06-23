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
    public partial class Registro : ContentPage
    {

        double costoCurso = 1500;
        double pagoMensual;

        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUusuario.Text = "Usuario Conectado: " + usuario;
            this.usuario = usuario;

        }

        private void datoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void datoMonto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnMensual_Clicked(object sender, EventArgs e)
        {

            double pagoInicial = double.Parse(datoInicial.Text);
            double pagoCuota = this.costoCurso - pagoInicial;
            double pagoInte = pagoCuota * 0.04;
            pagoCuota = pagoCuota / 4 + pagoInicial;
            datoMonto.Text = pagoCuota.ToString();
            this.pagoMensual = pagoCuota;


        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = int.Parse(txtEdad.Text);
            string fecha = dpFecha.Date.ToString();
            string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
            string pais = pkPais.Items[pkPais.SelectedIndex];
            double pagoInicial= double.Parse(datoInicial.Text);
            double pagoMensual = this.pagoMensual;

            Navigation.PushAsync(new Resumen(this.usuario, nombre,
                apellido, edad, fecha, ciudad, pais, pagoInicial, pagoMensual));


        }
    }
}