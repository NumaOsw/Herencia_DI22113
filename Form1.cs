using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            // voy a darle comportamiento a mi boton 
            // voy a utilizar mi clase hija sumar
            Suma sumar = new Suma(); //Intancia, o hice un nuevo objeto suma, llamr al metodo de clase suma operar
            textBox3.Text = sumar.operacion(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
