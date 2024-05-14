using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double n4 = 0;

            int totalAp = 0;
            int totalRp = 0;


            if (double.TryParse(txtN1.Text, out n1) && double.TryParse(txtN2.Text, out n2) && double.TryParse(txtN3.Text, out n3) && double.TryParse(txtN4.Text, out n4))
            {
                double media = 0;

                media = (n1 + n2 + n3 + n4) / 4;

                if(media >= 6)
                {
                    listAprovados.Items.Add($"{txtNome.Text} - Media: {media}");
                    totalAp = listAprovados.Items.Count;
                    totalAprovados.Text = totalAp.ToString();
                }
                else
                {
                    listReprovados.Items.Add($"{txtNome.Text} - Media: {media}");
                    totalRp = listReprovados.Items.Count;
                    totalReprovados.Text = totalRp.ToString();
                }
            }
            else
            {
                txtNome.Clear();
                txtN1.Clear();
                txtN2.Clear();
                txtN3.Clear();
                txtN4.Clear();
                MessageBox.Show("Valores inválidos ! Tente novamente !!!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listAprovados.Items.Clear();
            listReprovados.Items.Clear();
            totalAprovados.Text = 0.ToString();
            totalReprovados.Text = 0.ToString();
            txtNome.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
        }
    }
}
