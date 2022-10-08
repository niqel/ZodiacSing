using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.Domain.Entities.EntitiesBase;

namespace ZodiacSign.Domain.Entities
{
    public class Home : CatalogBase
    {
        public List<Sign>? Signs { get; set; }
    }
}
