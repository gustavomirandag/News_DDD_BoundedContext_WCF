using News.DomainModel.Aggregations.NoticiaAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Repositories
{
    public class NoticiasRepository
    {
        //Pseudo Base Dados (Volátil)
        private static List<Noticia> _noticias = new List<Noticia>();

        public Noticia Add(Noticia noticia)
        {
            _noticias.Add(noticia);
            return Get(noticia.Id);
        }

        public void Update(Noticia noticia)
        {
            Delete(noticia.Id);
            Add(noticia);
        }
        public Noticia Get(Guid id)
        {
            return _noticias.Find(n => n.Id == id);
        }
        public IEnumerable<Noticia> GetAll()
        {
            return _noticias;
        }
        public void Delete(Guid id)
        {
            Noticia noticiaOriginal = Get(id);
            _noticias.Remove(noticiaOriginal);
        }
    }
}
