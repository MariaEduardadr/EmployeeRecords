using MongoDB.Driver;
using WebApplicationMongodb.Models;

namespace WebApplicationMongodb.Context
{
    public class ContatoContext
    {
    
        public List<Contato> ObterContatos()
        {
            var colletionContatos = Conn.AbrirColecaoContatos();
            var filter = Builders<Contato>.Filter.Empty;
            return colletionContatos.Find(filter).ToList();
        }

    }
}
