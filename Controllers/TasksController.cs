using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NETConfWebAPI.Data;
using System.Linq;

namespace NETConfWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] Task task)
        {
            using (var context = new TasksContext())
            {
                context.Tasks.Add(task);
                context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            using (var context = new TasksContext())
            {
                return context.Tasks.ToList();
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Task task)
        {
            using (var context = new TasksContext())
            {
                Task taskToChange = context.Tasks.Find(id);
                taskToChange.State = task.State;
                context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new TasksContext())
            {
                Task taskToDelete = context.Tasks.Find(id);
                context.Remove(taskToDelete);
                context.SaveChanges();
            }
        }
    }
}