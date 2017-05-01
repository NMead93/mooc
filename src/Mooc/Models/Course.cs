using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mooc.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<AppUser> Users { get; set; }
    }
}
