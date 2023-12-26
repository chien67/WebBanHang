using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebBangHang_main.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Adv> Advs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DkEmail> DkEmails { get; set; }
        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<OrderCart> OrderCarts { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.ProductId)
                .IsFixedLength();

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
