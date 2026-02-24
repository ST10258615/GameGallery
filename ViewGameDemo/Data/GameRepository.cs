using ViewGameDemo.Models;

namespace ViewGameDemo.Data
{
    public static class GameRepository
    {
        public static List<Game> Games = new List<Game>
        {
            new Game {
            Id = 1,
            Name = "Tic Tac Toe",
            Description = "Classic 2-player grid strategy game.",
            ImageUrl = "/images/tictactoeIcon.png",
            Category = "Strategy",
            Difficulty = "Easy",
            Rules = "Two players take turns placing X and O on a 3x3 grid. The first player to get three in a row horizontally, vertically, or diagonally wins. If all squares are filled with no winner, the game ends in a draw."
            },
        new Game {
            Id = 2,
            Name = "Snake",
            Description = "Grow the snake without hitting the walls.",
            ImageUrl = "/images/snakeIcon.png",
            Category = "Arcade",
            Difficulty = "Medium",
            Rules = "Use the arrow keys to move the snake around the screen. Eat the food to grow longer. Avoid hitting walls or the snake's own body, or the game ends."
            },
        new Game {
            Id = 3,
            Name = "Memory Match",
            Description = "Flip cards and test your memory.",
            ImageUrl = "/images/memoryMatch.png",
            Category = "Puzzle",
            Difficulty = "Medium",
            Rules = "Flip two cards at a time to reveal their symbols. If they match, they stay face up. If not, they flip back over. Match all pairs to win."
            },
        new Game {
            Id = 4,
            Name = "2048",
            Description = "Combine numbers to reach 2048.",
            ImageUrl = "/images/2048Icon.png",
            Category = "Puzzle",
            Difficulty = "Medium",
            Rules = "Use arrow keys to slide numbered tiles. When two tiles with the same number touch, they merge into one. Combine tiles until you reach 2048."
            },
        new Game {
            Id = 5,
            Name = "Reaction Time",
            Description = "Click as fast as you can when the screen turns green.",
            ImageUrl = "/images/reaction.png",
            Category = "Casual",
            Difficulty = "Easy",
            Rules = "Wait for the screen to turn green, then click as quickly as possible. Try to improve your reaction time over multiple attempts."
            },
        new Game {
            Id = 6,
            Name = "Rock Paper Scissors",
            Description = "Play against the computer in this classic showdown.",
            ImageUrl = "/images/rps.png",
            Category = "Casual",
            Difficulty = "Easy",
            Rules = "Choose rock, paper, or scissors. Rock beats scissors, scissors beats paper, paper beats rock. Ties occur when both choices are the same."
            },
        new Game {
            Id = 7,
            Name = "Sliding Puzzle",
            Description = "Arrange the tiles in the correct order.",
            ImageUrl = "/images/sliding.png",
            Category = "Puzzle",
            Difficulty = "Hard",
            Rules = "Slide tiles into the empty space to arrange them in numerical or image order. Complete the puzzle in as few moves as possible."
            },
        new Game {
            Id = 8,
            Name = "Space Dodger",
            Description = "Dodge incoming asteroids as long as possible.",
            ImageUrl = "/images/space.png",
            Category = "Arcade",
            Difficulty = "Hard",
            Rules = "Use arrow keys to move your spaceship and avoid incoming asteroids. Survive as long as possible to achieve a high score."
            } 
        };
    }
}
