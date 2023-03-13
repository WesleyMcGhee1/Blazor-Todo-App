using Microsoft.EntityFrameworkCore;
using TodoList.Data.Models;

namespace TodoList.Data;

public class TodoDataContext : DbContext
{
    public TodoDataContext(DbContextOptions<TodoDataContext> options) :
        base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.UseSerialColumns();
    }

    public DbSet<Todo> Todos { get; set; }
}