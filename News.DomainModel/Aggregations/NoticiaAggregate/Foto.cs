using System;
using System.Collections.Generic;
using System.Text;

namespace News.DomainModel.Aggregations.NoticiaAggregate
{
    public class Foto
    {
        public Guid Id { get; set; }
        public string Fotografo { get; set; }
        public DateTime Criacao { get; set; }
        public string Descricao { get; set; }
        public Uri Imagem { get; set; }
    }
}
