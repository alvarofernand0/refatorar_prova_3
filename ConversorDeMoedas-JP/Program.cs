using System;
using ConversorDeMoedas;

List<Moeda> moedas = new List<Moeda>()
{
    new Moeda() {Nome = "Dolar($)", Cotacao = 4.50m},
    new Moeda() {Nome = "Euro(€)", Cotacao = 5.50m},
    new Moeda() {Nome = "Iene(¥)", Cotacao = 0.567m},
    new Moeda() {Nome = "Real Brasileiro(R$)", Cotacao = 1.00m},
    new Moeda() {Nome = "Peseta(Pts)", Cotacao = 2.35m}
};

IniciarAplicacao();

void IniciarAplicacao()
{
    bool sair = false;
    while (sair != true)
    {
        Console.Clear();
        Console.WriteLine("=== MENU DE MOEDAS ===\n");
        Console.WriteLine("1 - Listar Moedas");
        Console.WriteLine("2 - Adicionar Moedas");
        Console.WriteLine("3 - Converter Moedas");
        Console.WriteLine("4 - SAIR\n");
        Console.WriteLine("Digite uma das opções...");

        int.TryParse(Console.ReadLine(), out int opcao);
        switch (opcao)
        {
            case 1:
                ListarMoedas();
                break;
            case 2:
                AdicionarMoedas();
                break;
            case 3:
                ConverterMoedas();
                break;
            case 4:
                sair = true;
                Console.Clear();
                Console.WriteLine("Saindo da Aplicação...");
                break;
            default:
                Console.WriteLine("Opção inválida!\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu...");
                break;
        }
        Console.ReadKey();
    }
}

void ListarMoedas()
{
    Console.Clear();
    Console.WriteLine("=== MENU DE LISTAGEM ===\n");

    for (int i = 0; i < moedas.Count; i++)
    {
        Console.WriteLine("------------------\n");

        Console.WriteLine($"{i + 1}- {moedas[i].Nome} {moedas[i].Cotacao}\n");
    }
    Console.WriteLine("------------------\n");
    Console.WriteLine("Digite qualquer tecla para retornar ao menu...");
}

void AdicionarMoedas()
{
    bool moedaOk = false;
    while (moedaOk != true)
    {
        Console.Clear();
        Console.WriteLine("=== MENU DE ADIÇÃO DE MOEDAS ===\n");

        Console.Write("Digite o nome da nova Moeda: ");
        string novoNome = Console.ReadLine();

        Console.WriteLine("Digite uma Cotação para a Moeda");
        if (!decimal.TryParse(Console.ReadLine(), out decimal novaCotacao) && novaCotacao == 0)
        {
            Console.WriteLine("Valor inválido!");
            Console.ReadKey();
        }
        else
        {
            moedas.Add(new Moeda() { Nome = novoNome, Cotacao = novaCotacao });
            Console.Clear();
            moedaOk = true;
            Console.WriteLine("Moeda adicionada com sucesso!\n Digite qualquer tecla para retornar ao Menu...");
            break;
        }
    }
}

void ConverterMoedas()
{
    bool moedaOk = false;
    while (moedaOk != true)
    {
        Console.Clear();
        
        for (int i = 0; i < moedas.Count; i++)
        {
            Console.WriteLine($"{i}- {moedas[i].Nome} {moedas[i].Cotacao}\n");
        }

        Console.Write("Digite o Nº da opção da moeda Inicial: ");
        if (int.TryParse(Console.ReadLine(), out int inicial) && inicial < moedas.Count && inicial >= 0)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Opção inválida!\nDigite qualquer tecla para tentar novamente...");
        }

        Console.Write("Digite o Nº da opção da moeda Final: ");
        if (int.TryParse(Console.ReadLine(), out int final) && final < moedas.Count && final >= 0)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Opção inválida!\nDigite qualquer tecla para tentar novamente...");
        }

        Console.Write("Digite o valor que deseja converter: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) &&  valor == 0)
        {
            Console.WriteLine("Valor inválido!");
        }
        else
        {
            decimal valorConvertido = (valor * moedas[inicial].Cotacao) / moedas[final].Cotacao;
            Console.WriteLine($"O valor convertido é {valorConvertido:f3} {moedas[final].Nome}");
            moedaOk = true;
            break;
        }
    }
}