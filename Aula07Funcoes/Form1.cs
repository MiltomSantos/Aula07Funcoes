using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07Funcoes
{
    public partial class Form1 : Form
    {
        //variaveis globais
        public Form1()
        {
            InitializeComponent();
        }

        //minhas funções
        void mostramensagem()
        {
            MessageBox.Show("Olá, seja bem vindo");
            MessageBox.Show("Faça login para continuar");
        }

        void mostraNome()
        {
            string nome = txtNome.Text;
            if (nome == "")
            {
                return;
            }
            MessageBox.Show($"Olá {nome}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mostramensagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            mostraNome();
        }

        double converterDinheiro(Label dimdim)
        {
           // double dinheiro = double.Parse(label1.Text);
            double dinheiro = double.Parse(dimdim.Text.Replace("R$ ", ""));
            return dinheiro;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);
            double dinheiro = converterDinheiro(label1);
            double soma = valor + dinheiro;
            label1.Text = $"R$ {soma}";
        }
    }
}
