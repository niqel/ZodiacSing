using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.AppBusiness.DTOs
{
    public class SignDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gem { get; set; }
        public string? Element { get; set; }
        public int FromMonth { get; set; }
        public int FromDay { get; set; }
        public int UntilMonth { get; set; }
        public int UntilDay { get; set; }
        public List<HomeDTO>? Homes { get; set; }
    }
}
