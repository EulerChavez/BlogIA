namespace BlogIA.Migrations.BlogDB {

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogIA.Models.DB.BlogDB> {

        public Configuration() {

            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/BlogDB";

        }

        protected override void Seed(BlogIA.Models.DB.BlogDB context) {


        }

    }

}
