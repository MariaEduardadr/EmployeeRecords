# WebApplicationMongodb

>  WebApplicationMongodb é um Sistema de Cadastro de funcionários uma aplicação que permite gerenciar as informações dos funcionários de uma organização. Ele pode incluir funcionalidades como adicionar, editar, visualizar e excluir registros de funcionários.

Aplicação <strong>CRUD(Create, Read, Update, Delete</strong> para gerenciamento de registros de cadastro em um banco de dados MongoDB.

## Exemplos de Uso
- Acesso a página de cadastro de funcinários.
- Adicionar, editar, excluir registros de funcionários.
- Consultar a lista de funcionários cadastrados.

## 🛠 Tecnologias Utilizadas
- C Sharp
- MongoDB
- ASP.NET MVC
- Git e Github

## Configurações 
> Configurações para execução! Para mais instruções sobre como configurar e usar este projeto, [clique aqui](./instruções/README.md).

## Pré-requisitos
- .NET Core SDK 6.0 ou superior
- MongoDB instalado e em execução
## Instalação
1. Clone o repositório:
```
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```
2. Restaure as dependências:
```
dotnet restore
```
3. Configuração com o MongoDB
Crie um arquivo appsettings.json na raiz do projeto com as seguintes configurações com json:
```
{
  "ConnectionStrings": {
    "MongoDb": "mongodb://localhost:27017"
  },
  "DatabaseName": "sua_base_de_dados"
}
```
4. Execução
````
dotnet run
````






