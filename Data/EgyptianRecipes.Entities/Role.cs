using EgyptianRecipes.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Entities
{
    [Table("Roles")]
    public class Role : InheritDb
    {
        public Role()
        {
            this.UserRoles = new List<UserRole>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RolesID { get; set; }
        public string Roles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
