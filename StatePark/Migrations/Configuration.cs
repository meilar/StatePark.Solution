using EntityFramework.Seeder;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using StatePark.Models;

namespace StatePark.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StateParkContext>
    {
      public Configuration()
      {
        AutomaticMigrationsEnabled = false;
      }

      protected override void Seed(StateParkContext context)
      {
        context.Parks.SeedFromResource("StateParks.Data.Parks.csv", p => p.ParkId);
        context.SaveChanges();
        context.Regions.SeedFromResource("StateParks.Data.Regions.csv", r => r.RegionId);
        context.SaveChanges();
        context.ParkRegions.SeedFromResource("StateParks.Data.Parks.csv", s => s.ParkRegionId);
        context.SaveChanges();
      }
    }
}