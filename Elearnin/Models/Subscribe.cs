using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Elearnin.Models
{
    [PrimaryKey(nameof(UserId), nameof(CourseId))]
    public class Subscribe
    {
        //[Key, Column(Order = 0)]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        //[Key, Column(Order = 1)]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
