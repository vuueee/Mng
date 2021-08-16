using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mng.Models;

namespace Mng.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
             //Database.EnsureDeleted();
             //Database.EnsureCreated();
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
