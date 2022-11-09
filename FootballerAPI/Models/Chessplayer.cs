using System.ComponentModel.DataAnnotations;

namespace ChessPlayerAPI.Models
{
    public class ChessPlayer
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the chess player")]
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int ELO { get; set; }

        [UseSorting]
        public ICollection<Title> Titles { get; set; }
        [UseSorting]
        public ICollection<Record> Records { get; set; }
    }
}