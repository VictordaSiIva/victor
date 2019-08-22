﻿using System;
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
        Pedido pedido = new Pedido();

        DataBase banco = new DataBase();
        public Mesa mesa;

        public TelaPedido(Mesa mesa)
        {

          
            InitializeComponent();
            
            this.mesa = mesa;
            banco.InserirMesa(this.mesa);
            lblNome.FontFamily = "BarbershopinThailand.ttf";
            lblNome.Text = "Realize seu pedido, " + mesa.nome + "!";
            
            lanches.ItemsSource = ListaLanches();
            pedido.lanches = SelecionarLanche();

          

        }

        private void Adicionar(object sender, EventArgs args)
        {
            int i = 0;

            foreach (var lanche in ListaLanches())
            {
                lanche.quantidade = i;

                i++;
            }

            

        }


        private List<Lanches> ListaLanches()
        {


            return new List<Lanches> {

                new Lanches{ nome = "Tradicional", preco = 23.00, descricao ="Exclusivo e delicioso! Receita própria, coberto com queijo mussarela derretido, cubinhos de bacon, alface, cebola e tomate.", quantidade = 0, precoTotal = 0 },
                new Lanches{ nome = "Barreado", preco = 26.00, descricao ="O primeiro do mundo! Coberto com queijo mussarela derretido, cubinhos de bacon, cebola e fatias de banana, Balinhas de banana vão de brinde.", quantidade = 0, precoTotal = 0},
                new Lanches{ nome = "Blumenau", preco = 25.00, descricao="Sabor indescritivel. Coberto com queijo mussarela derretido, cubinhos de bacon, agrião, cebola e tomate. ", quantidade = 0, precoTotal = 0  },
                new Lanches{ nome = "Pernil", preco = 25.00, descricao="Coberto com queijo provolone derretido, alface e o incrivel barbecue de goiabada.", quantidade = 0, precoTotal = 0},
                new Lanches{nome = "Vegetariano", preco = 24.00, descricao ="Feito de proteina de soja, quinoa e ervas frescas, coberto com queijo mussarela derretido, sour cream com cenoura, cebola, tomate e alface.", quantidade = 0, precoTotal= 0}
            };
        }



        private List<Lanches> SelecionarLanche ()

        {
            return ListaLanches().Where(L=>L.quantidade>0).ToList();
        }

       

        




    }
    
}