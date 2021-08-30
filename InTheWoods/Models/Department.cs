using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InTheWoods.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public string Company{ get; set; }
        public string Address{ get; set; }
        public string Hours { get; set; }
        public string ManagerName { get; set; }
        public string PhoneNumber { get; set; }

    }
}