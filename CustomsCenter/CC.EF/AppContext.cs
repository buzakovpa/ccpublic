using System.Data.Entity;
using System.Diagnostics;
using System.Linq.Expressions;
using CC.EF.Configurations;
using CC.MODELS;

namespace CC.EF
{

    public class AppContext : DbContext
    {

        public IDbSet<UiElement> UiElements { get; set; }
        public IDbSet<UiImage> UiImages { get; set; }

        public AppContext()
            : base(@"Data Source=(localdb)\Projects;Initial Catalog=local_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UiElementEntityConfiguration());
            modelBuilder.Configurations.Add(new UiImageEntityConfiguration( ));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();
            Debug.Print("SaveChanges: " + result);

            return result;
        }
    }
}