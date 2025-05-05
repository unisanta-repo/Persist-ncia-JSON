using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private ControllerCliente cc = new ControllerCliente();

        public Form1()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            List<Cliente> clientes = cc.CarregarDados();
            listBox1.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                listBox1.Items.Add(cliente);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
