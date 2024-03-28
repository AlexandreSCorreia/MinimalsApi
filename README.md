# Projeto Minimal API

## Visão Geral

Este projeto, chamado "Minimal API", é uma aplicação .NET Core 8 desenvolvida como parte do curso "Trabalhando com ASP.NET Minimals APIs" na Digital Innovation One (DIO). Ele demonstra a criação de uma API leve e eficiente, inspirada na simplicidade das APIs Flask, utilizando o Entity Framework Core para operações de banco de dados, SQL Server como o banco de dados, e incluindo mecanismos de autenticação e autorização. O projeto também apresenta operações CRUD para veículos e administradores do sistema, utilizando Swagger para documentação da API, e JWT para tokens de autenticação. Além disso, inclui um projeto de teste usando MSTest para testes abrangentes de entidades de domínio, serviços e requisições de API, empregando mocks para testes.

## Recursos

- **API Mínima**: Uma estrutura de API leve, inspirada na simplicidade do Flask, desenvolvida como parte do curso "Trabalhando com ASP.NET Minimals APIs" na DIO.
- **Entity Framework Core**: Para operações de banco de dados, incluindo migrações.
- **SQL Server**: Como o backend do banco de dados.
- **Autenticação e Autorização**: Autenticação baseada em JWT e autorização baseada em funções.
- **Operações CRUD**: Para veículos e administradores do sistema.
- **Swagger**: Para documentação da API.
- **Testes**: Testes abrangentes com MSTest, incluindo entidades de domínio, serviços e requisições de API.

## Começando

### Pré-requisitos

- .NET Core 8 SDK
- SQL Server

### Instalação

1. Clone o repositório.
2. Navegue até o diretório do projeto.
3. Execute `dotnet restore` para restaurar as dependências do projeto.
4. Configure sua string de conexão SQL Server no arquivo `appsettings.json`.
5. Execute `dotnet ef database update` para aplicar migrações e criar o esquema do banco de dados.
6. Execute `dotnet run` para iniciar a API.

### Testes

Para executar os testes, navegue até o diretório do projeto de teste e execute `dotnet test`.

## Documentação

A documentação da API está disponível através do Swagger UI, acessível em `http://localhost:5069/swagger`.


## Agradecimentos

- .NET Core 8
- Entity Framework Core
- SQL Server
- Swagger
- JWT
- MSTest
- Digital Innovation One (DIO)