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
    [Table("Branchs")]
    public class Branch : InheritDb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BranchID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public Int64 OpeningHour { get; set; }

        [Required]
        public Int64 ClosingHour { get; set; }

        [Required]
        public string ManagerName { get; set; }

        [NotMapped]
        public TimeSpan ClosingHourValue
        {
            get { return TimeSpan.FromTicks(ClosingHour); }
            set { ClosingHour = value.Ticks; }
        }

        [NotMapped]
        public TimeSpan OpeningHourValue
        {
            get { return TimeSpan.FromTicks(OpeningHour); }
            set { OpeningHour = value.Ticks; }
        }
    }
}
