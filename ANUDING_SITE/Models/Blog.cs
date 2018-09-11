using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANUDING_SITE.Models
{
    public class Blog
    {
        private BlogContext blogcontext { get; set; }

        public string idtab_articles { get; set; }
        public string title { get; set; }
        public string navimg { get; set; }
        public string content { get; set; }
        public string tags { get; set; }
        public string dateCreated { get; set; }
    }
}
