using EgyptianRecipes.Entities;
using EgyptianRecipes.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Data
{
    public class EgyptianRecipesContext : DbContext
    {
        public EgyptianRecipesContext()
            : base("EgyptianRecipesContextDatabaseConnectionName")
        {
            Database.SetInitializer<EgyptianRecipesContext>(new CreateDatabaseIfNotExists<EgyptianRecipesContext>());
        }

        public EgyptianRecipesContext(string connectionStringName)
            : base(connectionStringName)
        {
            Database.SetInitializer<EgyptianRecipesContext>(new CreateDatabaseIfNotExists<EgyptianRecipesContext>());
        }
        
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<User> Users { get; set; }

        // Automatically add the times the entity got created/modified
        public override int SaveChanges()
        {
            string tempInfo = String.Empty;
            try
            {
                try
                {
                    var entries = ChangeTracker.Entries().ToList();
                    for (int i = 0; i < entries.Count; i++)
                    {
                        if (entries[i].State == EntityState.Unchanged || entries[i].State == EntityState.Detached || entries[i].State == EntityState.Deleted) continue;

                        var hasInterfaceInheritDb = entries[i].Entity as InheritDb;
                        if (hasInterfaceInheritDb == null) continue;

                        if (entries[i].State == EntityState.Added)
                        {
                            var created = entries[i].Property("Created");
                            if (created != null)
                            {
                                created.CurrentValue = DateTime.UtcNow;
                            }
                        }
                        if (entries[i].State == EntityState.Modified)
                        {
                            var modified = entries[i].Property("LastModified");
                            if (modified != null)
                            {
                                modified.CurrentValue = DateTime.UtcNow;
                            }
                        }
                    }
                }
                catch (System.Exception dbEx)
                {
                }
                return base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                string additionalInfo = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        additionalInfo += "Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage + "";
                    }
                }
                return 0;
            }

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        
    }
}
