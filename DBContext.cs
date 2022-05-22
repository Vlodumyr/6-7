using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dish>().HasKey(d => new { d.DishId, d.Name });
            modelBuilder.Entity<SeasonDish>().HasKey(d => new { d.DishId, d.Name });
            modelBuilder.Entity<TypeDish>().HasKey(d => new { d.DishId, d.Name });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"DataSource=app.db");

        public DBContext(bool newDB) : base()
        {
            SQLitePCL.Batteries.Init();
            //SQLitePCL.raw.SetProvider("");
            if (newDB)
            {
                this.Database.EnsureDeleted();
                this.Database.EnsureCreated();
            }
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<SeasonDish> SeasonDishes { get; set; }
        public DbSet<TypeDish> TypeDishes { get; set; }
    }
}
