namespace BlogIA.Models.DB {

    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogDB : DbContext {

        public BlogDB() : base("name=BlogDB") { }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

    }

}