# WebApplicationMongodb

> Sistema de Cadastro de funcionários 

## 🔗🇧🇷

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

