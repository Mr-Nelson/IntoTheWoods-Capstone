using InTheWoods.Data;
using InTheWoods.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace InTheWoods.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        //    [HttpGet("adminId"), Authorize]
        //    public IActionResult GetCurrentAdmin()
        //    {
        //        var adminId = Admin.FindFirstValue("id");
        //        var admin = _context.Admins.Find(adminId);
        //        if (admin == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(admin);
        //    }
        //}
    }
}
