using Microsoft.EntityFrameworkCore;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Notes> Notes { get; set; }
    }
}
