using RLNET;

namespace EmptyProject.Entity.Weapon
{
    public class Bullet
    {
        private RLRootConsole console;
        private Player player;
        public int prev1X;
        public int prev1Y;
        public int prev2X;
        public int prev2Y;
        public Bullet(RLRootConsole console,Player player)
        {
            this.console = console;
            this.player = player;
            console.Print((int)player.position.X-2,(int)player.position.Y-1,"|",RLColor.White);
            prev1X = (int) player.position.X - 2;
            prev1Y = (int) player.position.Y - 2;
            console.Print((int) player.position.X + 2, (int) player.position.Y - 1, "|", RLColor.White);
            prev2X = (int) player.position.X + 2;
            prev2Y = (int) player.position.Y + 1;

        }
        
        public void drawBullet()
        {

            console.Print(prev1X, prev1Y--, "|", RLColor.White);
            console.Print(prev2X, prev1Y--, "|", RLColor.White);
            
        }

        public void drawCur()
        {
            console.Print(prev1X, prev1Y, "|",RLColor.White);
            console.Print(prev2X, prev1Y, "|",RLColor.White);
        }
        
        
    }
}