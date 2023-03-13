using System.ComponentModel.DataAnnotations;

namespace TodoList.Data.Models;

public class Todo
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Importance { get; set; } = null!;
}