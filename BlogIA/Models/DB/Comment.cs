using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIA.Models.DB {

    public class Comment {

        public int ID { get; set; }

        public int PostID { get; set; }

        public string UserName { get; set; }

        public DateTime CommentTime { get; set; }

        public string Content { get; set; }

        // Navigation Properties

        public virtual Post Post { get; set; }

    }

}