using AdvertApi.Models;

namespace Advert.Web.Models
{
    public class ConfirmAdvertRequest
    {
        public string Id { get; set; }
        public AdvertStatus Status { get; set; }
        public string FilePath { get; set; }
    }
}