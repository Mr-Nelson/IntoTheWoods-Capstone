using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InTheWoods.Models
{
    public class Event
    {
        [Key]
        public string EventId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public string EventDate { get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }

    }
}