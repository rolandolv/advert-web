using System.Collections.Generic;
using System.Threading.Tasks;
using Advert.Web.Models;

namespace Advert.Web.ServiceClients
{
    public interface ISearchApiClient
    {
        Task<List<AdvertType>> Search(string keyword);
    }
}