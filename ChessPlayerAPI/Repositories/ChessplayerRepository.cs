using ChessPlayerAPI.Data;
using ChessPlayerAPI.Interfaces;

namespace ChessPlayerAPI.Repositories
{
    public class ChessplayerRepository : IChessplayerRepository
    {
        private readonly ApplicationDbContext _context;

        public ChessplayerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
