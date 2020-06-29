using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_CVSDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0, altura = 0, imc=0;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

       
                imc = peso / (altura * altura);
                txtImc.Text = imc.ToString("f");
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SAD_SelectedIndexChanged(object sender, EventArgs e)
        {
                Console.Write("");
                Console.Write("Abaixo de 17    Muito abaixo do peso");
                Console.Write("Entre 17 e 18,49    Abaixo do peso");
                Console.Write("Entre 18,5 e 24,99  Peso normal");
                Console.Write("Entre 25 e 29,99    Acima do peso ");
                Console.Write("Entre 30 e 34,99    Obesidade I ");
                Console.Write("Entre 35 e 39,99    Obesidade II (severa)");
                Console.Write("Acima de 40 Obesidade III(mórbida)");
        }
    }
}
