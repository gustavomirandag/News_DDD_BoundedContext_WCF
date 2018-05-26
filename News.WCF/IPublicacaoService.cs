using News.DomainModel.Aggregations.NoticiaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace News.WCF
{
    [ServiceContract]
    public interface IPublicacaoService
    {
        [OperationContract]
        bool PublicarNoticia(Noticia noticia);
        [OperationContract]
        IEnumerable<Noticia> ObterNoticiasPublicadas();
    }
}
