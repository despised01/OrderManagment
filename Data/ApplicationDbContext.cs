using Microsoft.EntityFrameworkCore;
using OrderManagment.Models;

namespace OrderManagment.Data
{
    // Контекст базы данных
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<OrderEquipment> OrderEquipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderEquipment>()
                .HasKey(oe => new { oe.OrderId, oe.EquipmentId });

            modelBuilder.Entity<OrderEquipment>()
                .HasOne(oe => oe.Order)
                .WithMany(o => o.Equipments)
                .HasForeignKey(oe => oe.OrderId);

            modelBuilder.Entity<OrderEquipment>()
                .HasOne(oe => oe.Equipment)
                .WithMany(e => e.Orders)
                .HasForeignKey(oe => oe.OrderId);
        }
    }
}
