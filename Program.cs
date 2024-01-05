﻿using ProjetoEstacionamento.Models;

// Atributos
decimal precoInicial;
decimal precoPorHora;
string placa;

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estc = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Insira a placa do veículo que deseja adicionar: ");
            placa = Console.ReadLine()!;

            estc.AdicionarVeiculo(placa);
            break;

        case "2":
            Console.WriteLine("Insira a placa do veículo que deseja remover: ");
            placa = Console.ReadLine()!;

            estc.RemoverVeiculo(placa);
            break;

        case "3":
            estc.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Insira uma tecla para continuar: ");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");