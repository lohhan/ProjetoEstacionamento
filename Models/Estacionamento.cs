using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {   
        // Atributos
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        // Construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora) 
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para Adicionar um Novo Veículo
        public void AdicionarVeículo(string placa) 
        {
            veiculos.Add(placa);
        }

        // Método para Remover um Veículo
        public void RemoverVeiculo(string placa) 
        {
            if(veiculos.Contains(placa.ToUpper()))
            {
                System.Console.WriteLine("Quantas horas o carro esteve estacionado?: ");
                string horas = Console.ReadLine();
                if(int.TryParse(horas, out int hora))
                {
                    System.Console.WriteLine("O valor a ser pago é de: " + precoInicial * (precoPorHora * hora));
                    veiculos.Remove(placa.ToUpper());
                }
            }
        }

        public void ListarVeiculos()
        {
            foreach (string lista in veiculos)
            {
                System.Console.WriteLine($"Veículo: {lista}");
            }
        }
    }
}