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
    public partial class Resumen : ContentPage
    {

        double costoCurso = 1500;
        public Resumen(string usuario, string nombre, string apellido, int edad, string fecha, string ciudad, string pais, double pagoInicial, double pagoMensual)

        {
            InitializeComponent();
            lblUusuario.Text = usuario;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad.ToString();
            txtFecha.Text = fecha;
            txtCiudad.Text = ciudad;
            txtPais.Text = pais;
            txtPagoInicial.Text = pagoInicial.ToString();
            txtPagoMensual.Text = pagoMensual.ToString();

            double pagoTotal = pagoInicial + pagoMensual * 4;

            txtPagoTotal.Text = pagoTotal.ToString();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}