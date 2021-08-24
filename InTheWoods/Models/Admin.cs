using Microsoft.AspNetCore.Identity;
using InTheWoods.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InTheWoods.Models
{
    public class Admin : IdentityUser

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IdentityRole { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<SubComment> SubComments { get; set; }
    }
}