using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    internal class Estac
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 5;
        private decimal valorTotal = 0;
        private decimal estadia = 0;
        private List<string> veiculos = new List<string>();

        public Estac(decimal precoInicial, decimal precoHora, decimal valorTotal) { 
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.valorTotal = 0;
        }

        public void AdicionarVeiuclo()
        {
            Console.WriteLine("Digite a placa para adicionar o veículo: ");
            string? vehs = Console.ReadLine();

            veiculos.Add(vehs);
            Console.WriteLine("Veículo de placa " + vehs + " adicionado com sucesso.");
        }

        public void ListarPorPlaca()
        {
            Console.WriteLine("Consulte um veículo pela placa: ");
            string? vehsC = Console.ReadLine();

            bool ok = false;

            foreach(string placa in veiculos)
            {
                if(placa.Equals(vehsC, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Placa {placa}, encontrada no sistema");
                    ok = true;
                    break;
                }
            }

            if(!ok) {
                Console.WriteLine($"Placa {vehsC} não cadastrada no sistema");
            }
        }

        public void ListarTodos()
        {
            if(veiculos.Count > 0)
            {
                Console.WriteLine("Lista de Veículos Cadastrados: \n");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"Placa: {placa}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo no sistema.");
            }
        }

        public void RemoverVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Encontrado: {placa}.");
                veiculos.Remove(placa);
                Console.WriteLine($"Veículo de placa {placa} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Nenhum veículo de placa {placa} cadastrado no sistema.");
            }
        }


        public void totalPg()
        {
            Console.WriteLine("Consulte um veículo pela placa: ");
            string? vehsC = Console.ReadLine();

            bool ok = false;

            foreach (string placa in veiculos)
            {
                if (placa.Equals(vehsC, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Placa {placa}, encontrada no sistema");
                    ok = true;
                    break;
                }
            }

            if (!ok)
            {
                Console.WriteLine($"Placa {vehsC} não cadastrada no sistema");
            }
            else
            {
                Console.WriteLine("Tempo estacionado: ");
                string estd = Console.ReadLine();

                if(decimal.TryParse(estd, out decimal estadia))
                {
                    precoHora = 5;
                    Console.WriteLine($"Tempo de Estadia no estacionamento: {estadia} horas");
                    valorTotal = (precoHora * estadia);
                    Console.WriteLine($"Veículo de placa {vehsC}, precisa pagar R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Tempo inválido.");
                }

            }
        }

    }
}
