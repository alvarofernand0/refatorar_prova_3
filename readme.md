# Conversor de Moedas - duração do desafio: 4 horas

## 🎯 Objetivo

Utilizando uma aplicação do tipo console no .NET, criar um sistema que converte o **Real (R$)** para as moedas:

- **Dólar ( $ )**
- **Euro ( € )**
- **Iene ( ¥ )**
- **Libra Esterlina ( £ )**
- **Nova Moeda** (criada pelo usuário)

## 🏷️ Legenda das Moedas

- **Real (R$)**: moeda brasileira
- **Dólar ( $ )**: moeda norte-americana
- **Euro ( € )**: moeda europeia
- **Iene ( ¥ )**: moeda japonesa
- **Libra Esterlina ( £ )**: moeda do Reino Unido
- **Nova Moeda**: moeda criada pelo usuário, com símbolo e valor definidos manualmente

---

## ✅ Requisitos da Aplicação

- Criar um console com um **menu de opções recursivo**, que só será encerrado quando o usuário escolher a opção **"Sair"**.

### 📋 Opções do Sistema

- **Listar Moedas**
- **Adicionar Moeda**
- **Converter Moeda**
- **Sair**

### 🔄 Conversão de Moeda

- Na opção **"Converter Moeda"**, após informar o valor a ser convertido, o sistema deve exibir um menu com as opções de moeda destino:

  - Dólar ( $ )
  - Euro ( € )
  - Iene ( ¥ )
  - Libra Esterlina ( £ )
  - Nova Moeda (deverá cadastrar uma nova moeda)

- Utilizar os seguintes valores fictícios para conversão:

| Moeda            | Valor em Real (R$) |
|------------------|---------------------|
| Dólar ( $ )      | R$ 4,50             |
| Euro ( € )       | R$ 6,20             |
| Iene ( ¥ )       | R$ 0,052            |
| Libra ( £ )      | R$ 6,95             |
| Nova Moeda (X)   | R$ (valor definido) |

---

## 🚀 Desafios 

### C#

1. Implementar a conversão **das moedas internacionais para Real (R$)**.
2. Garantir que o menu de opções continue sendo **recursivo**, encerrando apenas quando o usuário escolher a opção **"Sair"**.
3. Criar um método para **cadastrar novas moedas**, permitindo que o usuário defina o nome, símbolo e taxa de conversão em relação ao Real (R$).

### GIT

- No arquivo `index.cshtml`, copie o conteúdo de exemplo e adicione suas informações.
- O arquivo final deve ter as informações de **todos os estagiários**, junto com o exemplo.

---

## 💡 Observações

- Crie uma **branch específica** para o desafio, utilizando o **seu nome** como nome da branch (ex.: `odlavir`).
- Crie uma **cópia** do arquivo `Program.cs` e salve com o **seu nome** (exemplo: `Odlavir.cs`). A avaliação será feita com base nesse arquivo.
- O arquivo `Program.cs` deve permanecer **inalterado**, servindo apenas como **modelo** para a cópia.
- O arquivo com seu nome (`SeuNome.cs`) deve ser salvo no **mesmo diretório** onde está o `Program.cs`.
- A aplicação deve ser **intuitiva**, apresentando mensagens claras para cada etapa do processo.
- Valide as **entradas dos usuários** para evitar erros, como dados inválidos ou digitação incorreta.
- Ao finalizar, realize o **merge da sua branch** com a branch `main`.

---

## 
