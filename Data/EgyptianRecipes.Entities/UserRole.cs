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
    [Table("UsersRoles")]
    public class UserRole : InheritDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UsersRolesID { get; set; }
        public long UserID { get; set; }
        public long RoleId { get; set; }
        public virtual Role Roles { get; set; }
        public virtual User Users { get; set; }
    }
}