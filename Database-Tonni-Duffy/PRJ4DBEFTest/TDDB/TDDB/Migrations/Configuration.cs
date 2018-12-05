using System.Collections.Generic;

namespace TDDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using TDDB.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TDDB.Models.TDDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TDDB.Models.TDDBContext context)
        {


            context.Users.AddOrUpdate(x => x.UserID,
               
                new User(1,"xx1337Killer","12345",0) { Scores = new List<Score>() { new Score(1) { Maps = new List<Map>() { new Map("FangeKaelderen",0) { } } } } }, //, new Map() {MapName = "DAB", MapScore = 500}
                new User(2,"KillerDK","1234",0) { Scores = new List<Score>() { new Score(2) { Maps = new List<Map>() { new Map("TeknikLaden",0) {} } } } }
                
                );


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
