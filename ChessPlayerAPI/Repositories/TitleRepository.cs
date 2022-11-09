using ChessPlayerAPI.Data;
using ChessPlayerAPI.Interfaces;

namespace ChessPlayerAPI.Repositories
{
    public class TitleRepository : ITitleRepository
    {
        private readonly ApplicationDbContext _context;

        public TitleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
