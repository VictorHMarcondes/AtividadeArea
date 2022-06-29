using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            //criando variavel e iniciando com 0
            double altura = 0;
            double basee = 0;
            double area = 0;

            if (txtAltura.Text != "" && txtBase.Text != "")
            { 
                altura = double.Parse(txtAltura.Text);
                basee = double.Parse(txtBase.Text);
            }
            //calculando area
            area = basee * altura / 2;

            //mostrar o valor
            lblResultado.Text = area.ToString();



        }
    }
}
