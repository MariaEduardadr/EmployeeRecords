## 🔗🇺🇸

## Prerequisites
- .NET Core SDK 6.0 or higher
- MongoDB installed and running

## Installation

1. Clone the repository:
```
git clone https://github.com/your-username/your-repository.git
cd your-repository
```
2. Restore dependencies:
```
dotnet restore
```
3. Configuration with MongoDB Create an appsettings.json file at the root of the project with the following JSON configuration:
```
{
  "ConnectionStrings": {
    "MongoDb": "mongodb://localhost:27017"
  },
  "DatabaseName": "your_database_name"
}
```
4. Execution
````
dotnet run
````
