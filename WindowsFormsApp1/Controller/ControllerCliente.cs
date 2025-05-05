using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    internal class ControllerCliente
    {
        private string filePath = "clientes.json";
        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> CarregarDados()
        {

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();
            }

            return clientes;
        }

        private void SalvarDados()
        {
            string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }


        public void CadastrarCliente(string nome, string email, int idade)
        {
            int novoId = clientes.Count > 0 ? clientes[clientes.Count - 1].Id + 1 : 0;
            Cliente novoCliente = new Cliente
            {
                Id = novoId,
                Name = nome,
                Email = email,
                Idade = idade
            };

            clientes.Add(novoCliente);

            SalvarDados();
        }
    }
}
