namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoPorHora { get; set; }
        public string placa { get; set; }
                
        public List<string> veiculos = new List<string>();

        public Estacionamento(string placa)
        {          
            this.placa = placa;            
        }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Implementado!

            string placa;
            placa = Console.ReadLine().ToUpper();
            if (veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("O veiculo já esta estacionado!");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veiculo de placa {placa} foi cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado!
            string placa = "";
            placa = Console.ReadLine().ToUpper();
            veiculos.Remove(placa);
            Console.WriteLine($"Veiculo de placa {placa} foi removido da garagem ");
            

            // Verifica se o veículo existe
            if (!veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // Implementado!
                int horas =0;
                
                decimal valorTotal;
                horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);
                Console.WriteLine($"O valor total é de {valorTotal}");

                // TODO: Remover a placa digitada da lista de veículos
                // Implementado!

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Implementado!
                foreach (var placas in veiculos)
                {
                    Console.WriteLine(placas);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
