using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InTheWoods.Models
{
    public class SubComment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get ; set; }
        public Comment Comment { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Admin")]
        public string AdminId { get; set; }
        public Admin Admin { get; set; }

        public string UserSubComment { get; set; }

    }
}
