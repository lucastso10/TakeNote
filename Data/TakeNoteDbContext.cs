using Microsoft.EntityFrameworkCore;
using TakeNote.Models;

namespace TakeNote.Data
{
    public class TakeNoteDbContext : DbContext
    {
        public TakeNoteDbContext (DbContextOptions<TakeNoteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
    }
}
