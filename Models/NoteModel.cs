using System.ComponentModel.DataAnnotations;

namespace TakeNote.Models;

public class Note
{
  public int Id { get; set; }

  [Required]
  public required string Title { get; set; }

  public string? Description { get; set; }
}
