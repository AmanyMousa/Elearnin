using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearnin.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public virtual User Instructor { get; set; }

        public int Duration { get; set; } //  hours

        [ForeignKey("category")]
        public int categoryId { get; set; }

        public virtual Category category { get; set; }

        public virtual List<Subscribe>? students { get; set; }


    }
}
