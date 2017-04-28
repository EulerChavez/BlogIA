using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIA.Models.DB {

    public class BlogCategory {

        public int ID { get; set; }

        public string Category { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }

}