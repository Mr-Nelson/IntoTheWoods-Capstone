using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace InTheWoods.Models
{
    public class Comment
    {
        public string Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Admin")]
        public string AdminId { get; set; }
        public Admin Admin { get; set; }

        public string UserComment { get; set; }

        public ICollection<SubComment> SubComments { get; set; }

        internal static object FindFirstValue(string Id)
        {
            throw new NotImplementedException();
        }
    }
}