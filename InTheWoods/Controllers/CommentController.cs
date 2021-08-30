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
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Comment value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Comments.Add(value);
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
        [HttpGet("{commentId}")]
        public IActionResult GetCommentById(int commentId)
        {
            var comments = _context.Comments.Where(c => c.Id == commentId).Include(c => c.User).
                 Select(c => new { commentId = c.Id, userId = c.UserId, userComment = c.UserComment, userName = c.User.UserName});
            if (comments == null)
            {
                return NotFound();
            }
            return Ok(comments);
        }
        [HttpGet]
        public IActionResult GetAllComments()
        {
            var comments = _context.Comments;
            return Ok(comments);
        }
    }
}