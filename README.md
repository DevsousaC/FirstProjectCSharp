# README

Este é o meu primeiro projeto desenvolvido em C# e também uma especie de documentação dessa trajetória. Cada Commit contem minhas anotações do que está funcionando e o que quero fazer em seguida.

O sistema é uma aplicação de console que simula um painel de gerenciamento com operações de lógica de negócio.

## O que é esse projeto

O sistema conta com um menu interativo que permite realizar algumas operações utilizando
como contexto "Coisas que posso fazer entre duas pessoas", como por exemplo a media de salario entre duas pessoas.

A escolha do tema foi aleatoria já que a única finalidade desse repositório é documentar como eu aprendo a programar
com Orientação a Objetos utilizando C#.

Leve em consideração que esse projeto é um SandBox. Algumas escolhas podem não fazer sentido mas talvez tenham sido feitas apenas para testar algo

## Coisas que abordei até agora

Durante o desenvolvimento, apliquei os seguintes conceitos técnicos:

**Orientação a Objetos:** Separação de responsabilidades entre a classe Menu (interface) e Service (lógica).

*Métodos Estáticos:* Uso de static para serviços utilitários.

**Estruturas de Controle:** while para o loop principal e switch case para o roteamento de funções.

**Interpolação de Strings:** Formatação limpa de mensagens e valores monetários.

**Manipulação de Coleções:** Uso de List<string> para gerenciar as opções do menu.

## 📁 Estrutura do Código

├── Program.cs       # Ponto de entrada (Main) e controle do loop

├── Menu.cs          # Gerenciamento da interface e entrada do usuário

└── Service.cs       # Métodos de cálculo e regras de negócio


## 🚀 Como Executar

- Certifique-se de ter o SDK do .NET 6.0 (ou superior) instalado.

1. Clone este repositório.

2. No terminal, acesse a pasta do projeto e execute:
```
> dotnet run 
```
