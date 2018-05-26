using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using News.DomainModel.Aggregations.NoticiaAggregate;

namespace News.WCF
{
    public class PublicacaoService : IPublicacaoService
    {

        public bool PublicarNoticia(Noticia noticia)
        {
            var publicacaoService =
                new DomainService.PublicacaoService(
                    new Data.Repositories.NoticiasRepository()
                );
            return publicacaoService.PublicarNoticia(noticia);
        }
        public IEnumerable<Noticia> ObterNoticiasPublicadas()
        {
            var publicacaoService =
                new DomainService.PublicacaoService(
                    new Data.Repositories.NoticiasRepository()
                );
            return publicacaoService.ObterNoticiasPublicadas();
        }
    }
}
