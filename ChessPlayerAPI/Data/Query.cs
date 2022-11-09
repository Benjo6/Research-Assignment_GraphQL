using ChessPlayerAPI.Models;

namespace ChessPlayerAPI.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ChessPlayer> GetChessPlayers([Service] ApplicationDbContext context) =>
            context.ChessPlayers;
    }
}
