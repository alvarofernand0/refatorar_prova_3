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
    Console.WriteLine("==== Conversor de Moedas ====");
    Console.WriteLine();

    // TODO: Implementar o menu de opções recursivo e com switch case
}

// Método para listar moedas cadastradas
void ListarMoedas()
{
    // TODO: Implementar a listagem das moedas
}

// Método para adicionar uma nova moeda
void AdicionarMoeda()
{
    // TODO: Implementar a adição de nova moeda
}

// Método para converter entre moedas
void ConverterMoeda()
{
    // TODO: Implementar a lógica de conversão entre moedas
}

// Desafio extra:
// TODO: Permitir converter qualquer moeda para qualquer outra (incluindo Real).
// TODO: O menu deve ser recursivo, só finalizando quando o usuário escolher "Sair".
// TODO: Implementar versionamento com Git e subir o projeto no GitHub.
