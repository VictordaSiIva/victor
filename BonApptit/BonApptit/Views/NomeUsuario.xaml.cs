using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonApptit.Modelos;
using BonApptit.Banco;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BonApptit.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NomeUsuario : ContentPage
	{



        public NomeUsuario ()
		{
             


            InitializeComponent ();
         

		}


       
        Mesa mesa = new Mesa();


        public void GoPaginaPedido(object sender, EventArgs args)
        {
           

           mesa.nome  = nomeUsuario.Text;
            App.Current.MainPage = new NavigationPage(new Views.TelaPedido(mesa));

        

        }
    }
}