using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rcujanoSM5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Insertar : ContentPage
	{
		public Insertar ()
		{
			InitializeComponent ();
		}

        private void btnInsertar_Clicked(object sender, EventArgs e)

        {
            try
            {
                WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized .NameValueCollection ();    
            parametros.Add("codigo", txtCodigo.Text);
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);
            cliente.UploadValues("http://192.168.1.247/ws_uisrael/post.php", "POST", parametros);
            Navigation.PushAsync(new MainPage());

                var mensaje = "Elemento ingresado con exito";
                DependencyService.Get<Mensaje>().longAlert(mensaje);

            }
            catch(Exception ex) 
            {
                DisplayAlert("ALERTA", ex.Message, "Cerrar");
            }

 }


        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}