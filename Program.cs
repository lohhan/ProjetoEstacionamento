using ProjetoEstacionamento.Models;

Estacionamento e = new Estacionamento(5, 2);

e.AdicionarVeículo("ABC-1234");
e.AdicionarVeículo("XYZ-9876");
e.AdicionarVeículo("WRZ-1543");
e.AdicionarVeículo("DTT-2020");

e.ListarVeiculos();

e.RemoverVeiculo("wrz-1543");

e.ListarVeiculos();
