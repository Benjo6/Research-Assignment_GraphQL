using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChessPlayerAPI.Models
{
    public class Record
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The record name is required")]
        public string Name { get; set; }

        [ForeignKey("ChessplayerId")]
        public Guid ChessplayerId { get; set; }
        public ChessPlayer ChessPlayer { get; set; }
    }
}
