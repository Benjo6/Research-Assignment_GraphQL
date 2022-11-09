using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChessPlayerAPI.Models
{
    public class Title
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The title name is required")]
        public string Name { get; set; }

        [ForeignKey("ChessplayerId")]
        public Guid ChessplayerId { get; set; }
        public ChessPlayer ChessPlayer { get; set; }
    }
}