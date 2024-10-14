using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplicationMongodb.Models
{
    public class Pessoa
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereço { get; set; }
        public int? Telefone { get; set; }

    }
}
