using MongoDB.Driver;
using WebApplicationMongodb.Models;
namespace WebApplicationMongodb.Context
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "cadastro";
        public static readonly string ColletionContato = "funcionário";

        public static IMongoCollection<Contato> AbrirColecaoContatos()
        {
            var cli = new MongoClient(Server);
            var db = cli.GetDatabase(Db);
            return db.GetCollection<Contato>(ColletionContato);
        }
    }
}
