using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApplicationMongodb.Context;

namespace WebApplicationMongodb.Models
{
    public class Empregado
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Cargo { get; set; }
        public double? Salário { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }
        public int? Telefone { get; set; }


        private EmpregadoContext _empregadoContext = new EmpregadoContext();

        public List<Empregado> ObterEmpregados()
        {
            return _empregadoContext.ObterEmpregados();

        }

        public List<Empregado> ObterEmpregados(string texto)
        {
            return _empregadoContext.ObterEmpregados(texto);

        }

        public bool Inserir(Empregado contato)
        {
            return _empregadoContext.Inserir(contato);
        }

        public Empregado ObterEmpregado(string id) 
        {
            return _empregadoContext.ObterEmpregado(id);
        }
        public bool Atualizar(Empregado contato)
        {
            return _empregadoContext.Atualizar(contato);
        }

        public Empregado Visualizar(string id)
        {
            return _empregadoContext.ObterEmpregado(id);
        }
        
        public bool Excluir(Empregado contato)
        {
            return _empregadoContext.Excluir(contato);
        }
     
    }
}
