using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestPerpustakaan_VS2019.Models;
using TestPerpustakaan_VS2019.Library.Entities;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TestPerpustakaan_VS2019.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        {

        }

        // ------------------- SEC MANAGEMENT -------------------
        public DbSet<MenuEntity.Menu> Menus { get; set; }
        public DbSet<RoleEntity.Role> Roles { get; set; }
        public DbSet<UserEntity.User> Users { get; set; }
        public DbSet<UserRolesEntity.UserRoles> UserRoles { get; set; }

        // ------------------- NON - SEC MANAGEMENT -------------------
        public DbSet<LocationEntity.Location> Locations { get; set; }
        public DbSet<BukuEntity.Buku> Bukus { get; set; }
        public DbSet<PeminjamanEntity.Peminjaman> Peminjamans { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MenuEntity.Menu>().ToTable("Menu");
            modelBuilder.Entity<RoleEntity.Role>().ToTable("Role");
            modelBuilder.Entity<UserEntity.User>().ToTable("Users");
            modelBuilder.Entity<UserRolesEntity.UserRoles>().ToTable("UserRoles");

            modelBuilder.Entity<LocationEntity.Location>().ToTable("Location");
            modelBuilder.Entity<BukuEntity.Buku>().ToTable("Buku");
            modelBuilder.Entity<PeminjamanEntity.Peminjaman>().ToTable("Peminjaman");
        }

    }
}
