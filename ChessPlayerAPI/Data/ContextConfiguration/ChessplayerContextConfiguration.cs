using ChessPlayerAPI.Interfaces;
using ChessPlayerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ChessPlayerAPI.Models;

namespace ChessPlayerAPI.Data.ContextConfiguration
{
    public class ChessplayerContextConfiguration : IEntityTypeConfiguration<ChessPlayer>
    {
        private Guid[] _ids;

        public ChessplayerContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ChessPlayer> builder)
        {
            builder
                .HasData(
                new ChessPlayer
                {
                    Id = _ids[0],
                    Name = "Karjakin",
                    Nationality="Russia",
                    ELO=2747
                },
                new ChessPlayer
                {
                    Id = _ids[1],
                    Name = "Carlson",
                    Nationality="Norway",
                    ELO=2859
               
                },
                new ChessPlayer
                {
                    Id = _ids[2],
                    Name = "Caruana",
                    Nationality="USA",
                    ELO=2766
                });
        }
    }
}