using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.Domain.Entities.EntitiesBase;

namespace ZodiacSign.Domain.Entities
{
    public class Sign : CatalogBase
    {
        public int FromMonth { get; set; }
        public int FromDay { get; set; }
        public int UntilMonth { get; set; }
        public int UntilDay { get; set; }
        public int ElementId { get; set; }
        public Element? Element { get; set; }
        public int GemId { get; set; }
        public Gem? Gem { get; set; }
        public List<Home>? Homes { get; set; }
        public DateTime DateTime { get; set; }
    }
}
