using AspNetMvcCms.Entities;
using AspNetMvcCms.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcCms.DAL
{
    public class CmsContext : DbContext
    {
        public DbSet<PageData> PageDatas { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<MenuLink> MenuLinks { get; set; }
        public DbSet<BlockDetail> BlockDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PageData>().HasMany(x => x.Blocks).WithMany();
            modelBuilder.Entity<PageData>().HasMany(x => x.MenuLinks).WithMany();
            modelBuilder.Entity<Block>().HasOptional(x => x.BlockDetail).WithRequired();

            modelBuilder.Entity<BlockDetail>().Property(x => x.BlockDetailID).HasColumnName("BlockID").IsOptional();
        }
    }
}
