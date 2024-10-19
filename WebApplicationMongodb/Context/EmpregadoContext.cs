using MongoDB.Driver;
using WebApplicationMongodb.Models;

namespace WebApplicationMongodb.Context
{
    public class EmpregadoContext
    {
    
        public List<Empregado> ObterEmpregados()
        {
            var colletionEmpregados = Conn.AbrirColecaoEmpregados();
            var filter = Builders<Empregado>.Filter.Empty;
            return colletionEmpregados.Find(filter).ToList();
        }

        public List<Empregado> ObterEmpregados(string texto)
        {
            var colletionEmpregados = Conn.AbrirColecaoEmpregados();
            var filter = Builders<Empregado>.Filter.Regex("Nome", new MongoDB.Bson.BsonRegularExpression(".*" + texto + ".*"));
            return colletionEmpregados.Find(filter).ToList();
        }

        public bool Inserir(Empregado empregado)
        {
            try
            {
                var colletionEmpregados = Conn.AbrirColecaoEmpregados();
                colletionEmpregados.InsertOne(empregado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Empregado ObterEmpregado(string id)
        {
            var colletionEmpregados = Conn.AbrirColecaoEmpregados();
            var filter = Builders<Empregado>.Filter.Eq(x => x.Id, id);
            return colletionEmpregados.Find(filter).FirstOrDefault();
        }

        public bool Atualizar(Empregado empregado)
        {
            try
            {
                var colletionEmpregados = Conn.AbrirColecaoEmpregados();
                var filter = Builders<Empregado>.Filter.Eq(x => x.Id, empregado.Id);
                colletionEmpregados.ReplaceOne(filter, empregado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Excluir(Empregado contato)
        {
            try
            {
                var colletionEmpregados = Conn.AbrirColecaoEmpregados();
                colletionEmpregados.DeleteOne(p => p.Id == contato.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
