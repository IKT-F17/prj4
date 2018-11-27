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
                new User() { UserID = 1, Username = "xx1337Killerxx", Password = "12345", Scores = new List<Score>() { new Score() { ScoreID = 1, Maps = new List<Map>() { new Map() { MapName = "FangeKaelderen", MapScore = 0 } } } } } //, new Map() {MapName = "DAB", MapScore = 500}
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
