using MongoDB.Driver;
using WebApplicationMongodb.Models;
namespace WebApplicationMongodb.Context
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "Agenda";
        public static readonly string ColletionPessoa = "pessoa";

        public static IMongoCollection<Pessoa> AbrirColecaopessoa()
        {
            var cli = new MongoClient(Server);
            var db = cli.GetDatabase(Db);
            return db.GetCollection<Pessoa>(ColletionPessoa);
        }
    }
}
