using Must.Model.Entities.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.DataAccess.Concrete.EntityFramework
{
    public class MFDbContext : DbContext
    {
        public MFDbContext()
            : base("Server=.;Database=MFProject;Integrated Security=True;")
        {

        }
        public DbSet<Products> Product { get; set; }
        public DbSet<Categories> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasRequired(x => x.Category)
                .WithMany(x => x.Product).HasForeignKey(x => x.CategoryID).WillCascadeOnDelete(true); // kategoriye bağlı ürünlerin otomatik silinmesi için

        }
    }
    
}
