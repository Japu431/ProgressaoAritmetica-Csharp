using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressaoAritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void termo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calcularPA_Click(object sender, EventArgs e)
        {
            int Termo1 = Convert.ToInt32(termo1.Text);
            int Razao = Convert.ToInt32(razao.Text);
        

            for(int Posicao = Convert.ToInt32(posicao.Text); Posicao <= Termo1; Posicao += Razao)
            {
                paRes.Text += $"{Posicao}";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            termo1.Text = "";
            razao.Text = "";
            posicao.Text = "";
            paRes.Text = "";
        }
    }
}
