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

        public bool Inserir(Contato contato)
        {
            try
            {
                var colletionContatos = Conn.AbrirColecaoContatos();
                colletionContatos.InsertOne(contato);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Contato ObterContato(string id)
        {
            var colletionContatos = Conn.AbrirColecaoContatos();
            var filter = Builders<Contato>.Filter.Eq(x => x.Id, id);
            return colletionContatos.Find(filter).FirstOrDefault();
        }

        public bool Atualizar(Contato contato)
        {
            try
            {
                var colletionContatos = Conn.AbrirColecaoContatos();
                var filter = Builders<Contato>.Filter.Eq(x => x.Id, contato.Id);
                colletionContatos.ReplaceOne(filter, contato);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Excluir(Contato contato)
        {
            try
            {
                var colletionContatos = Conn.AbrirColecaoContatos();
                colletionContatos.DeleteOne(p => p.Id == contato.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
