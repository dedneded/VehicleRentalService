using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace form
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        public DbSet<CategoryOfVehicle> CategoryOfVehicles { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<TimetableBranch> TimetableBranches { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<DiscountBranches> DiscountBranches { get; set; }
        public DbSet<DiscountCategoriesVehicle> DiscountCategoriesVehicle { get; set; }
        public DbSet<DiscountServices> DiscountServices { get; set; }
        public DbSet<DriverCategories> DriverCategories { get; set; }
         public DbSet<TimetableEmployee> TimetableEmployees { get; set; }
         public DbSet<Role> Roles { get; set; }
         public DbSet<ServiceInOrder> ServicesInOrder { get; set; }
        public DbSet<OrderServiceInOrders> OrderServiceInOrders { get; set; }
        public DbSet<ServiceVehicles> ServiceVehicles { get; set; }
        public DbSet<ServiceEmployees> ServiceEmployees { get; set; }

        public DbSet<OrderDiscounts> OrderDiscounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscountBranches>().HasKey(u => new { u.DiscountId, u.BranchId });
            modelBuilder.Entity<DiscountCategoriesVehicle>().HasKey(u => new { u.DiscountId, u.IdCategory });
            modelBuilder.Entity<DiscountServices>().HasKey(u => new { u.DiscountId, u.ServiceId });
            modelBuilder.Entity<DriverCategories>().HasKey(u => new { u.DriverId, u.Category });
            modelBuilder.Entity<OrderServiceInOrders>().HasKey(u => new { u.ServiceInOrderId, u.OrderId });
            modelBuilder.Entity<ServiceVehicles>().HasKey(u => new { u.ServiceId, u.VehicleId, u.OrderId });
            modelBuilder.Entity<ServiceEmployees>().HasKey(u => new { u.ServiceId, u.EmployeeId, u.OrderId });
            modelBuilder.Entity<OrderDiscounts>().HasKey(u => new { u.OrderId, u.DiscountId });
        }
       

    }
}
