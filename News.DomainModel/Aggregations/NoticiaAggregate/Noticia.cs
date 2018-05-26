using System;
using System.Collections.Generic;
using System.Text;

namespace News.DomainModel.Aggregations.NoticiaAggregate
{
    public class Noticia
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Foto Foto { get; set; }
        public DateTime? Publicacao { get; set; }
        public DateTime Expiracao { get; set; }
    }
}
