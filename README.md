# Sistema Bancário Console

Sistema de gerenciamento de conta bancária desenvolvido em C# para console, permitindo operações básicas de depósito, saque e consulta de informações báscias da conta.

## Características

- Interface de linha de comando interativa
- Validação rigorosa de dados de entrada
- Formatação monetária padronizada
- Sistema de mensagens tipificadas
- Arquitetura modular com separação de responsabilidades

## Funcionalidades

- Criação de conta com nome, PIN(apenas números) e saldo inicial
- Consulta de informações da conta
- Operações de saque com validação de saldo
- Operações de depósito
- Validação de PIN de 4 dígitos
- Formatação numérica para valores monetários

## Estrutura do Projeto

### Namespaces Principais

**ContaBanco.Info**
- `DadosBancarios`: Classe principal que gerencia dados e operações da conta

**ContaBanco.Input**
- `EntradaDoUsuario`: Gerencia toda entrada de dados do usuário com validação

**Validations**
- `ValidacoesDeDados`: Centraliza todas as validações do sistema

**Miscelania**
- `MenuPrincipal`: Interface do menu principal
- `ConsoleUI`: Sistema de exibição de mensagens tipificadas
- `FormatadorNumerico`: Formatação de valores monetários
- `Mensagem`: Classe para estruturar mensagens do sistema
- `TipoMensagem`: Enum para tipos de mensagem

**UniversalResources**
- `RecursosUniversais`: Utilitários gerais para entrada de dados

## Validações Implementadas

- Nome: Aceita apenas letras, acentos, espaços e hífens, mínimo 2 caracteres
- PIN: Exatamente 4 dígitos numéricos
- Valores monetários: Números positivos com suporte a decimais
- Saque: Não pode exceder saldo disponível

## Requisitos

- .NET Framework ou .NET Core
- Sistema operacional com suporte a console

## Execução

O programa executa em loop contínuo apresentando menu com opções numeradas. A navegação é realizada através de entrada numérica seguida de Enter.

## Como Usar

### Execução Inicial

1. Execute o programa
2. Digite seu nome (apenas letras, acentos e espaços)
3. Insira PIN de 4 dígitos
4. Defina saldo inicial (valor positivo)

### Navegação do Menu

```
---------------MENU PRINCIPAL---------------
1 - Exibir informações da conta
2 - Sacar
3 - Depositar
4 - Sair
```

## Exemplos de Uso

### Criação de Conta
```
Digite o seu nome: Ronaldo
Digite o PIN de 4 dígitos: 5096
Qual será o saldo inicial? R$1000.50
```

### Operação de Saque
```
Quanto você quer Sacar? R$150.25
Seu saque foi de R$150.25.
Seu novo saldo é de R$850.25
```

### Operação de Depósito
```
Quanto você vai depositar? R$200.00
Seu depósito foi de R$200.00.
Seu novo saldo é de R$1050.25.
```

### Consulta de Informações
```
Informações da conta:
Nome: João Silva PIN: 5096, Saldo: R$1050.25
```

## Tratamento de Erros

O sistema valida todas as entradas e exibe mensagens específicas para:
- Nome inválido (números ou caracteres especiais)
- PIN diferente de 4 dígitos e que possua letra(s) (Apenas números permitidos)
- Valores negativos ou não numéricos
- Saque superior ao saldo disponível

## Arquitetura

Sistema desenvolvido com padrão de separação de responsabilidade única (SRP), onde cada namespace possui função específica, facilitando manutenção e extensibilidade do código.
