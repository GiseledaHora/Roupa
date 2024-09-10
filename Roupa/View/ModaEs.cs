using Roupa.Controller;
using Roupa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roupa.View
{
    public partial class Moda : Form
    {
        public Moda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compra.Tamanho = cbx_tamanho.Text;
            compra.Modelo = cbx_modelo.Text;    
            compra.Cor = cbx_cor.Text;   
            compra.Numero = cbx_numero.Text;
        
       CotrollerCompra cotrollerCompra = new CotrollerCompra();
            cotrollerCompra.EnviarBanco();
        
        Moda moda = new Moda();
            moda.Show();
            this.Hide();
        
        
        }
    }
}
