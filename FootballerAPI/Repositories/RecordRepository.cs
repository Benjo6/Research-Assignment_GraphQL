using ChessPlayerAPI.Data;
using ChessPlayerAPI.Interfaces;

namespace SuperheroAPI.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public RecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
