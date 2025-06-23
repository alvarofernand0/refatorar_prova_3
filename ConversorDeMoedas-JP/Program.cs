using System;
using System.Runtime.InteropServices;
using ConversorDeMoedas;

List<Moeda> moedas = new List<Moeda>()
{
    new Moeda() { Nome = "Dólar", Cotacao = 4.50m },
    new Moeda() { Nome = "Euro", Cotacao = 6.20m },
    new Moeda() { Nome = "Iene", Cotacao = 0.052m },
    new Moeda() { Nome = "Libra Esterlina", Cotacao = 6.95m }
};

// Ponto de entrada da aplicação
IniciarAplicacao();

void IniciarAplicacao()
{
    bool sair = false;
    while (sair != true)
    {
        Console.Clear();
        Console.WriteLine("==== Conversor de Moedas ====\n");
        Console.WriteLine("1 - Listar Moedas");
        Console.WriteLine("2 - Adicionar Moeda");
        Console.WriteLine("3 - Converter Moedas");
        Console.WriteLine("4 - SAIR");
        Console.Write("\nDigite uma das opções: ");

        int.TryParse(Console.ReadLine(), out int opcao);

        switch (opcao)
        {
            case 1:
                //Console.Clear();
                ListarMoedas();
                break;
            case 2:
                //Console.Clear();
                AdicionarMoeda();
                break;
            case 3:
                //Console.Clear();
                ConverterMoeda();
                break;
            case 4:
                //Console.Clear();
                Console.WriteLine("Saindo da aplicação...");
                sair = true;
                break;
            default:
                Console.WriteLine("\nNão é uma opção válida!");
                Console.Write("\nDigite qualquer tecla para voltar ao menu: ");
                break;
        }
        Console.ReadKey(true);
    }
}

void ListarMoedas()
{
    Console.WriteLine("==== Menu de Listagem ====\n");
    for (int i = 0; i < moedas.Count; i++)
    {
        if (moedas.Count == 0)
        {
            Console.WriteLine("A lista está vazia...");
        }
        else
        {
            Console.WriteLine("-------------------\n");
            Console.WriteLine($"- Moeda: {moedas[i].Nome}");
            Console.WriteLine($"- Cotação: {moedas[i].Cotacao}");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("-------------------\n");
}

// Método para adicionar uma nova moeda
void AdicionarMoeda()
{
    Console.WriteLine("==== Menu de Adição ====\n");

    Console.Write("Digite o nome da moeda: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a cotação: ");
    decimal.TryParse(Console.ReadLine(), out decimal cotacao);
    
    moedas.Add(new Moeda() {Nome = nome, Cotacao = cotacao});
}

void ConverterMoeda()
{
    // TODO: Implementar a lógica de conversão entre moedas
}

// Desafio extra:
// TODO: Permitir converter qualquer moeda para qualquer outra (incluindo Real).
// TODO: O menu deve ser recursivo, só finalizando quando o usuário escolher "Sair".
// TODO: Implementar versionamento com Git e subir o projeto no GitHub.
