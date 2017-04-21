using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIA.Models.DB {

    public class BlogPost {

        public int Id { get; set; }

        public string Title { get; set; }

        public string UserName { get; set; }

        public DateTime Date { get; set; }

        public string Review { get; set; }

        public string Content { get; set; }

    }

}