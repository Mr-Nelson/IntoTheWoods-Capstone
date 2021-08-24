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
    [Route("api/subcomment")]
    [ApiController]
    public class SubCommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SubCommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPut, Authorize]
        public IActionResult Put([FromBody] SubComment value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.SubComments.Add(value);
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
            //    _context.Comments.Add(value);
            //    _context.SaveChanges();
            //    return StatusCode(201, value);
            //}
            //catch
            //{
            //    return StatusCode(400, value);
            //}
            //}
        }
        [HttpGet("{subcommentId}")]
        public IActionResult GetSubCommentById(int subCommentId)
        {
            var subComments = _context.SubComments.Where(c => c.Id == subCommentId).Include(c => c.User).Include(c => c.Comment).
                 Select(c => new { subCommentId = c.Id, userSubComment = c.UserSubComment, userName = c.User.UserName });
            if (subComments == null)
            {
                return NotFound();
            }
            return Ok(subComments);
        }
        [HttpGet]
        public IActionResult GetAllSubComments()
        {
            var subComments = _context.SubComments;
            return Ok(subComments);
        }
    }
}