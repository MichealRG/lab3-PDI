using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PhotoData
    {
        public UrlsData Urls { get; set; }
    }
    public class UrlsData
    {
        public string Raw { get; set; }
        public string Full { get; set; }
        public string Regular{ get; set; }
        public string Small { get; set; }
        public string Thumb{ get; set; }
    }
}
