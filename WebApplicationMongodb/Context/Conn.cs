using MongoDB.Driver;
using WebApplicationMongodb.Models;
namespace WebApplicationMongodb.Context
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "cadastro";
        public static readonly string ColletionEmpregado = "funcionário";

        public static IMongoCollection<Empregado> AbrirColecaoEmpregados()
        {
            var cli = new MongoClient(Server);
            var db = cli.GetDatabase(Db);
            return db.GetCollection<Empregado>(ColletionEmpregado);
        }
    }
}
