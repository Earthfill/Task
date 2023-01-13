using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ToDo.MVC.Models
{
    public class TodoDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new TodoDbContext(serviceProvider.GetRequiredService<DbContextOptions<TodoDbContext>>());

            // Look for Todos.
            if (context.Todos.Any())
            {
                // Seeded data
                return;
            }

            context.Todos.AddRange(
                new Todo
                {
                    Id = 1,
                    TaskName = "Work on book chapter",
                    IsComplete = false
                },
                new Todo
                {
                    Id = 2,
                    TaskName = "Create video content",
                    IsComplete = false
                }
            );

            context.SaveChanges();
        }
    }
}