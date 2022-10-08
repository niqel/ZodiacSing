
using ZodiacSign.Domain.Entities.EntitiesBase;

namespace ZodiacSign.Domain.Entities
{
    public class Element : CatalogBase
    {
        public List<Sign>? Signs { get; set; }
    }
}
