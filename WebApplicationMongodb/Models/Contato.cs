﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using WebApplicationMongodb.Context;

namespace WebApplicationMongodb.Models
{
    public class Contato
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public int? Telefone { get; set; }


        private ContatoContext _contatoContextcs = new ContatoContext();

        public List<Contato> ObeterContatos()
        {
            return _contatoContextcs.ObterContatos();

        }

    }
}
