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

    [Table("Users")]
    public class User : InheritDb
    {
        public User()
        {
            this.User_Roles = new List<UserRole>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public bool Active { get; set; }
        public virtual ICollection<UserRole> User_Roles { get; set; }
    }
}
