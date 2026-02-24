using System.ComponentModel.DataAnnotations;
namespace ViewGameDemo.Models
{

    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }
    }
}
