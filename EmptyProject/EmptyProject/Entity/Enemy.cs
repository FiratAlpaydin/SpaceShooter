using OpenTK;
using RLNET;

namespace EmptyProject.Entity
{
    public class Enemy : Entity
    {
        private enum types
        {
            small,
            medium,
            large
        }

        private types type;
        public Enemy(int health,int type,Vector2 position) : base(health)
        {
            this.position = position;
            this.type = (types)type;
        }

        public void enemyDraw(RLRootConsole console)
        {
            if (type == types.small)
            {
                console.Print((int) position.X, (int) position.Y, "V", RLColor.White);
            }else if (type == types.medium)
            {
                console.Print((int) position.X, (int) position.Y, "O", RLColor.White);
            }else if (type == types.large)
            {
                console.Print((int) position.X, (int) position.Y, "H", RLColor.White);
            }
        }
        
    }
}