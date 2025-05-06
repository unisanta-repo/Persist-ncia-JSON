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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nome = txtb_nome.Text;
            string email = txtb_email.Text;
            if (int.TryParse(txtb_idade.Text, out int idade))
            {
                cc.CadastrarCliente(nome, email, idade);
                AtualizarLista(); // Atualiza a lista após salvar o cliente
            }
            else
            {
                MessageBox.Show("Por favor, insira uma idade válida.");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para atualizar!");
                return;
            }

            var listaClientes = cc.CarregarDados();
            var clienteSelecionado = listaClientes[listBox1.SelectedIndex];

            clienteSelecionado.Name = txtb_nome.Text == String.Empty ? clienteSelecionado.Name : txtb_nome.Text;
            clienteSelecionado.Email = txtb_email.Text == String.Empty ? clienteSelecionado.Email : txtb_email.Text;
            clienteSelecionado.Idade = int.TryParse(txtb_idade.Text, out int idade) ? idade : clienteSelecionado.Idade ;

            listBox1.Items.Clear();
            cc.SalvarDados();
            AtualizarLista();
            LimparCampos();
            MessageBox.Show("Cliente atualizado com sucesso.");
            AtualizarLista();

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtb_email.Clear();
            txtb_idade.Clear();
            txtb_nome.Clear();
        }
    }
}
