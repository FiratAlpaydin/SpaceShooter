using OpenTK;
using RLNET;

namespace EmptyProject.Entity
{
    public class Player:Entity
    {
        private string[,] playerBody = new string[5,5];

        public Player(int health) : base(health)
        {
            
            
            playerBody[0, 0] = "";
            playerBody[0, 1] = "";
            playerBody[0, 2] = ((char)219).ToString();
            playerBody[0, 3] = "";
            playerBody[0, 4] = "";
            playerBody[1, 0] = "";
            playerBody[1, 1] = "";
            playerBody[1, 2] = ((char)219).ToString();
            playerBody[1, 3] = "";
            playerBody[1, 4] = "";
            playerBody[2, 0] = ((char)219).ToString();
            playerBody[2, 1] = "";
            playerBody[2, 2] = ((char)219).ToString();
            playerBody[2, 3] = "";
            playerBody[2, 4] = ((char)219).ToString();
            playerBody[3, 0] = ((char)219).ToString();
            playerBody[3, 1] = ((char)219).ToString();
            playerBody[3, 2] = ((char)219).ToString();
            playerBody[3, 3] = ((char)219).ToString();
            playerBody[3, 4] = ((char)219).ToString();
            playerBody[4, 0] = "";
            playerBody[4, 1] = ((char)219).ToString();
            playerBody[4, 2] = "";
            playerBody[4, 3] = ((char)219).ToString();
            playerBody[4, 4] = "";

        }

        public void drawPLayer(Vector2 position,RLRootConsole rc)
        {
            this.position = position;
            int x = (int)position.X-2;
            int y = (int)position.Y-2;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    rc.Print(x + j, y + i, playerBody[i, j], RLColor.White);
                }
            }
            
        }
        
        
        
        
        
        
    }
}