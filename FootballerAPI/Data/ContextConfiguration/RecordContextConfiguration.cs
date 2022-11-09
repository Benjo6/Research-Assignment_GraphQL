using ChessPlayerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChessPlayerAPI.Data.ContextConfiguration
{
    public class RecordContextConfiguration : IEntityTypeConfiguration<Record>
    {
        private Guid[] _ids;

        public RecordContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder
                .HasData(
                new Record
                {
                    Id = Guid.NewGuid(),
                    Name = "Youngest Grand Master Ever",
                    ChessplayerId = _ids[0]
                },
                new Record
                {
                    Id = Guid.NewGuid(),
                    Name="Youngest International Master Ever",
                    ChessplayerId = _ids[0]
                },
                new Record
                {
                    Id = Guid.NewGuid(),
                    Name="Highest ELO ever achieved ",
                    ChessplayerId = _ids[1]
                },
                new Record
                {
                    Id = Guid.NewGuid(),
                    Name ="Longest unbeaten steak at elite level (125 games)",
                    ChessplayerId = _ids[1]
                },
                new Record
                {
                    Id = Guid.NewGuid(),
                    Name = "Highest performance rating in an elite level tournament (3098 ELO)",
                    ChessplayerId = _ids[2]
                }
             );
        }
    }
}

