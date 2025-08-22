using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraform
{
    public partial class Calculadora : Form
    {
        // Variáveis globais:
        bool operadorClicado = true;
       
      
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
        
            // Implementar depois...
            try
            {
               DataTable dt = new DataTable();
                var resultado = dt.Compute(txbtela.Text, null);
                txbtela.Text = resultado.ToString();
                if (txbtela.Text == "∞")
                {
                    txbtela.Text = "Deu ruim";
                }


            }
            catch (Exception) 
            {
                txbtela.Text = "Erro";
            }
         
        }

        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento:
            Button botaoClicado = (Button)sender;
            // Adicionar o Text do botão clicado no Textbox:
            txbtela.Text += botaoClicado.Text;
            // Mudar o operadorClicado para false
            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda não foi clicado:
            if (operadorClicado == false)
            {
                // Obter o botão que está chamando esse evento:
                Button botaoClicado = (Button)sender;
                // Adicionar o Text do botão clicado no Textbox:
                txbtela.Text += botaoClicado.Text;

                // Mudar o operadorClicado para true:
                operadorClicado = true;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:
            txbtela.Text = "";
            // Voltar o operador clicado para true:
            operadorClicado = true ;
        }
    }
}
