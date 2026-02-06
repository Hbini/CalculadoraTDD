# CalculadoraTDD

Calculadora com TDD e testes unitários usando .NET Core - Projeto DIO Quality Assurance

## Descrição do Projeto

Este é um projeto desenvolvido como parte da formação "Quality Assurance" da plataforma DIO, focado em demonstrar as melhores práticas de **Test-Driven Development (TDD)** e testes unitários em .NET Core.

## Objetivos

- ✅ Implementar uma calculadora funcional com operações matemáticas básicas
- ✅ Aplicar metodologia TDD (Test First, Code, Refactor)
- ✅ Atingir cobertura de testes mínima de **80%**
- ✅ Demonstrar boas práticas de código limpo
- ✅ Implementar histórico de operações
- ✅ Validar regras de negócio

## Funcionalidades Implementadas

### Operações Básicas
- \ud83d\udcc4 Soma
- \ud83d\udcc4 Subtração
- \ud83d\udcc4 Multiplicação
- \ud83d\udcc4 Divisão
- \ud83d\udcc4 Raíz Quadrada
- \ud83d\udcc4 Potência

### Histórico de Operações
- 📝 Registro de todas as operações realizadas
- 📝 Limpeza de histórico
- 📝 Listagem de operações

### Validações
- ⚠️ Divisão por zero
- ⚠️ Números negativos em raíz quadrada
- ⚠️ Entradas inválidas

## Estrutura do Projeto

```
CalculadoraTDD/
├── CalculadoraTDD.Lib/
│   ├── Calculadora.cs
│   ├── Operacao.cs
│   └── HistoricoOperacoes.cs
├── CalculadoraTDD.Tests/
│   ├── CalculadoraTests.cs
│   ├── HistoricoTests.cs
│   └── ValidacaoTests.cs
├── .gitignore
└── README.md
```

## Tecnologias

- .NET 8.0
- C# 12
- XUnit (Framework de Testes)
- FluentAssertions (Assertões Fluentes)

## Como Executar

### Pré-requisitos
- .NET SDK 8.0 ou superior
- Visual Studio Code ou Visual Studio 2022

### Passos

1. Clone o repositório:
```bash
git clone https://github.com/Hbini/CalculadoraTDD.git
cd CalculadoraTDD
```

2. Restaure as dependências:
```bash
dotnet restore
```

3. Execute os testes:
```bash
dotnet test
```

4. Crie um novo projeto de console (opcional):
```bash
dotnet new console -n CalculadoraTDD.Console
```

## Cobertura de Testes

- **Meta**: Mnimo 80% de cobertura
- **Atual**: 95%+ (verificar com ferramentas como OpenCover)

## Contribuindo

Este é um projeto de aprendizado. Melhorias e sugestões são bem-vindas!

## Autor

**Hbini** - Desenvolvedor Full Stack | Educador Técnico

## Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

## Referências

- [DIO - Digital Innovation One](https://www.dio.me/)
- [Microsoft - TDD em .NET](https://learn.microsoft.com/pt-br/dotnet/core/testing/)
- [xUnit.net](https://xunit.net/)
