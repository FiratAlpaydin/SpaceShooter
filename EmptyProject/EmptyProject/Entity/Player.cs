using OpenTK;

namespace EmptyProject.Entity
{
    public class Player:Entity
    {
        private string[,] playerBody = new string[5,5];

        public Player(int health, Vector2 position,string[,] playerBody) : base(health, position)
        {
            this.playerBody = playerBody;
        }
        
        
    }
}