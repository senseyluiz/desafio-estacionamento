using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal valorInicial { get; set; } = 0;
        public decimal valorPorHora  { get; set; } = 0;
        public List<string> veiculos { get; set; } = new List<string>();

        public Estacionamento(decimal valorInicial, decimal valorPorHora)
        {
            this.valorInicial = valorInicial;
            this.valorPorHora = valorPorHora;
        }
        public void CadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do Veículo: ");
            string placa = Console.ReadLine()!.ToUpper();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo de placa {placa} cadastrado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do Veículo: ");
            string placa = Console.ReadLine()!.ToUpper();
            if(veiculos.Contains(placa)){
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
                int horasEstacionado = int.Parse(Console.ReadLine()!);
                decimal total = valorInicial + (horasEstacionado * valorPorHora);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total a pagar é de: R$ {total}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Verifique se a placa foi digitada corretamente.");
            }
            
        }  

        public void ListarVeiculos()
        {
            if(veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach( string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }else{
                Console.WriteLine("Não possui veículos cadastrados.");
            }
            
        }

    }
}