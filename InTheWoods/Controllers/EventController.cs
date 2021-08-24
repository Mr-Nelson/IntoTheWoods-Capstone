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
    [Route("api/event")]
    [ApiController]
    class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = _context.Events;
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
        }

        [HttpGet("{eventId}")]
        public IActionResult GetEventById(int EventId)
        {
            var events = _context.Events.Where(e => e.EventId == EventId);
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
        }

        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Event value)
        {
            //try
            //{
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.Events.Add(value);
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
    }
}
