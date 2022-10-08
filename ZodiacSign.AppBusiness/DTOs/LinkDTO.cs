using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.AppBusiness.DTOs
{
    public class LinkDTO
    {
        private string href;
        private string rel;
        private string method;

        public string Href { get { return this.href;  }}
        public string Rel { get { return this.href; }}
        public string Method { get { return this.href; }}

        public LinkDTO(string href, string rel, string method)
        {
            this.href = href;
            this.rel = rel;
            this.method = method;
        }
    }
}
