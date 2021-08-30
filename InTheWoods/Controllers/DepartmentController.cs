using InTheWoods.Data;
using InTheWoods.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InTheWoods.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Department value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Departments.Add(value);
                _context.SaveChanges();
                return StatusCode(201, value);
            }
            catch
            {
                return StatusCode(400, value);
            }
            //}
            //catch
            //{
            //var adminId = Admin.FindFirstValue("id");
            //value.AdminId = adminId;
            //try
            //{
            //    _context.Events.Add(value);
            //    _context.SaveChanges();
            //    return StatusCode(201, value);
            //}
            //catch
            //{
            //    return StatusCode(400, value);
            //}
            //}
        }

        [HttpPut, Authorize]
        public IActionResult Put([FromBody] Department value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Departments.Add(value);
                _context.SaveChanges();
                return StatusCode(201, value);
            }
            catch
            {
                return StatusCode(400, value);
            }
            //}
            //catch
            //{
            //var adminId = Admin.FindFirstValue("id");
            //value.AdminId = adminId;
            //try
            //{
            //    _context.Events.Add(value);
            //    _context.SaveChanges();
            //    return StatusCode(201, value);
            //}
            //catch
            //{
            //    return StatusCode(400, value);
            //}
            //}
        }

        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var departments = _context.Departments;
            if (departments == null)
            {
                return NotFound();
            }
            return Ok(departments);
        }

        [HttpGet("{departmentId}")]
        public IActionResult GetDepartmentById(int DepartmentId)
        {
            var departments = _context.Departments.Where(e => e.DepartmentId == DepartmentId);
            if (departments == null)
            {
                return NotFound();
            }
            return Ok(departments);
        }
    }
}
