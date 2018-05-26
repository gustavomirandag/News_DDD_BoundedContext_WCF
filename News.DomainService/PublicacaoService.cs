using News.Data.Repositories;
using News.DomainModel.Aggregations.NoticiaAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.DomainService
{
    public class PublicacaoService
    {
        private NoticiasRepository _noticiasRepository;
        public PublicacaoService(NoticiasRepository noticiasRepository)
        {
            _noticiasRepository = noticiasRepository;
        }
        public bool PublicarNoticia(Noticia noticia)
        {
            return _noticiasRepository.Add(noticia)!=null;
        }

        public IEnumerable<Noticia> ObterNoticiasPublicadas()
        {
            return _noticiasRepository.GetAll();
        }
    }
}
