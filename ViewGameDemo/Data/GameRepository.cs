using ViewGameDemo.Models;

namespace ViewGameDemo.Data
{
    public static class GameRepository
    {
        public static List<Game> Games = new List<Game>
        {
            new Game { Id = 1, Name = "Tic Tac Toe", Description = "Classic 2-player grid strategy game.", ImageUrl = "/images/tictactoeIcon.png", Category = "Strategy", Difficulty = "Easy" },
            new Game { Id = 2, Name = "Snake", Description = "Grow the snake without hitting the walls.", ImageUrl = "/images/snakeIcon.png", Category = "Arcade", Difficulty = "Medium" },
            new Game { Id = 3, Name = "Memory Match", Description = "Flip cards and test your memory.", ImageUrl = "/images/memoryMatch.png", Category = "Puzzle", Difficulty = "Medium" },
            new Game { Id = 4, Name = "2048", Description = "Combine numbers to reach 2048.", ImageUrl = "/images/2048Icon.png", Category = "Puzzle", Difficulty = "Medium" },
            new Game { Id = 5, Name = "Reaction Time", Description = "Click as fast as you can when the screen turns green.", ImageUrl = "/images/reaction.png", Category = "Casual", Difficulty = "Easy" },
            new Game { Id = 6, Name = "Rock Paper Scissors", Description = "Play against the computer in this classic showdown.", ImageUrl = "/images/rps.png", Category = "Casual", Difficulty = "Easy" },
            new Game { Id = 7, Name = "Sliding Puzzle", Description = "Arrange the tiles in the correct order.", ImageUrl = "/images/sliding.png", Category = "Puzzle", Difficulty = "Hard" },
            new Game { Id = 8, Name = "Space Dodger", Description = "Dodge incoming asteroids as long as possible.", ImageUrl = "/images/space.png", Category = "Arcade", Difficulty = "Hard" }
        };
    }
}
