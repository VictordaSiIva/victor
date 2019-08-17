using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonApptit.Modelos;
using BonApptit.Banco;
using System.Text.RegularExpressions;

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
            if (mesa.nome == null || mesa.nome.Trim().Equals(""))

            {
                DisplayAlert("Mensagem de Erro", "O campo não pode ser vazio!", "Ok");
                nomeUsuario.Focus();
            }
            else if (!Regex.IsMatch(mesa.nome, @"^[ a-zA-Z á]*$"))
            {

                DisplayAlert("Mensagem de Erro", "O campo não pode conter números ou caracteres especiais!", "Ok");
                nomeUsuario.Focus();

            }

            else if (mesa.nome.Length >= 10)
            {
                DisplayAlert("Mensagem de Erro", "É permitido até 10 caracteres!", "Ok");
                nomeUsuario.Focus();

            }

            else
            {
                App.Current.MainPage = new NavigationPage(new Views.TelaPedido(mesa));

            }

            



        }
    }
}