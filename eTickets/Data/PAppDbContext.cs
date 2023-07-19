//using eTickets.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.Extensions.Configuration;

//namespace eTickets.Data
//{
//    public class PAppDbContext:IdentityDbContext<ApplicationUser>
//    {
//        //protected readonly IConfiguration Configuration;
//        //public PAppDbContext(IConfiguration configuration)
//        //{
//        //    Configuration = configuration;
//        //}

//        //protected override void OnConfiguring(DbContextOptionsBuilder options)
//        //{
//        //    // connect to postgres with connection string from app settings
//        //    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionString"));
//        //}

//        public PAppDbContext(DbContextOptions<PAppDbContext> options) : base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
//            {
//                am.ActorId,
//                am.MovieId
//            });

//            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
//            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


//            base.OnModelCreating(modelBuilder); using eTickets.Models;
//            using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//            using Microsoft.EntityFrameworkCore;
//            using System;
//            using System.Collections.Generic;
//            using System.Linq;
//            using System.Threading.Tasks;
//            using Microsoft.Extensions.Configuration;

//namespace eTickets.Data
//    {
//        public class AppDbContext : IdentityDbContext<ApplicationUser>
//        {
//            protected readonly IConfiguration Configuration;
//            public AppDbContext(IConfiguration configuration)
//            {
//                Configuration = configuration;
//            }

//            protected override void OnConfiguring(DbContextOptionsBuilder options)
//            {
//                // connect to postgres with connection string from app settings
//                options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
//            }
//            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//            {
//            }

//            protected override void OnModelCreating(ModelBuilder modelBuilder)
//            {
//                modelBuilder.Entity<Actor_Movie>().HasKey(am => new
//                {
//                    am.ActorId,
//                    am.MovieId
//                });

//                modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
//                modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


//                base.OnModelCreating(modelBuilder);
//            }

//            public DbSet<Actor> Actors { get; set; }
//            public DbSet<Movie> Movies { get; set; }
//            //public DbSet<Actor_Movie> Actors_Movies { get; set; }
//            public DbSet<Cinema> Cinemas { get; set; }
//            public DbSet<Producer> Producers { get; set; }


//            //Orders related tables
//            public DbSet<Order> Orders { get; set; }
//            public DbSet<OrderItem> OrderItems { get; set; }
//            public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
//        }
//    }

//}

//public DbSet<Actor> Actors { get; set; }
//        public DbSet<Movie> Movies { get; set; }
//        public DbSet<Actor_Movie> Actors_Movies { get; set; }
//        public DbSet<Cinema> Cinemas { get; set; }
//        public DbSet<Producer> Producers { get; set; }


//        //Orders related tables
//        public DbSet<Order> Orders { get; set; }
//        public DbSet<OrderItem> OrderItems { get; set; }
//        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
//    }
//}
