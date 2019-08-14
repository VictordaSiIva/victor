using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonApptit.Modelos;
using System.Threading.Tasks;
using BonApptit.Banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BonApptit.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaPedido : ContentPage
	{

        DataBase banco = new DataBase();
        public Mesa mesa { get; set; }
        

        public TelaPedido (Mesa mesa)
		{
           

            InitializeComponent ();
            this.mesa = mesa;
            banco.InserirMesa(this.mesa);
            lblNome.Text = mesa.nome;
            
            

        }

      
     
        
	}
}