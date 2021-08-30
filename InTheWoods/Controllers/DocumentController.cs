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
    [Route("api/document")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DocumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Document value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Documents.Add(value);
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
        public IActionResult Put([FromBody] Document value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Documents.Add(value);
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
        public IActionResult GetAllDocuments()
        {
            var documents = _context.Documents;
            if (documents == null)
            {
                return NotFound();
            }
            return Ok(documents);
        }

        [HttpGet("{documentId}")]
        public IActionResult GetDocumentById(int DocumentId)
        {
            var documents = _context.Documents.Where(e => e.DocumentId == DocumentId);
            if (documents == null)
            {
                return NotFound();
            }
            return Ok(documents);
        }
    }
}
