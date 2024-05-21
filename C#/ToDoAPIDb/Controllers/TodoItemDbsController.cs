using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPIDb.Models;

namespace ToDoAPIDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemDbsController : ControllerBase
    {
        private readonly TodoItemContext _context;

        public TodoItemDbsController(TodoItemContext context)
        {
            _context = context;
        }

        // GET: api/TodoItemDbs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItemDb>>> GettodoItems()
        {
            return await _context.todoItems.ToListAsync();
        }

        // GET: api/TodoItemDbs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItemDb>> GetTodoItemDb(int id)
        {
            var todoItemDb = await _context.todoItems.FindAsync(id);

            if (todoItemDb == null)
            {
                return NotFound();
            }

            return todoItemDb;
        }

        // PUT: api/TodoItemDbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItemDb(int id, TodoItemDb todoItemDb)
        {
            if (id != todoItemDb.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItemDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemDbExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItemDbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItemDb>> PostTodoItemDb(TodoItemDb todoItemDb)
        {
            _context.todoItems.Add(todoItemDb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItemDb", new { id = todoItemDb.Id }, todoItemDb);
        }

        // DELETE: api/TodoItemDbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItemDb(int id)
        {
            var todoItemDb = await _context.todoItems.FindAsync(id);
            if (todoItemDb == null)
            {
                return NotFound();
            }

            _context.todoItems.Remove(todoItemDb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemDbExists(int id)
        {
            return _context.todoItems.Any(e => e.Id == id);
        }
    }
}
