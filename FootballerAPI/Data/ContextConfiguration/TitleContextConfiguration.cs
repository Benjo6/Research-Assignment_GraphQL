using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ChessPlayerAPI.Models;

namespace ChessPlayerAPI.Data.ContextConfiguration
{
    public class TitleContextConfiguration : IEntityTypeConfiguration<Title>
    {
        private Guid[] _ids;

        public TitleContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
                .HasData(
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "World Rapid Champion 2012",
                    ChessplayerId = _ids[0]
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name="World Blitz Champion 2016",
                    ChessplayerId = _ids[0]
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "World Chess Champion",
                    ChessplayerId = _ids[1]
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "World Rapid Chess Champion",
                    ChessplayerId = _ids[1]
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "US Chess Champion 2022",
                    ChessplayerId = _ids[2]
                });
        }
    }
}
