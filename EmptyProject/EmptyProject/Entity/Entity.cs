using OpenTK;
using OpenTK.Input;

namespace EmptyProject.Entity
{
    public class Entity
    {
        private int health;
        private Vector2 position;

        public Entity(int health,Vector2 position)
        {
            this.health = health;
            this.position = position;
            
        }

        public int getHealth()
        {
            return health;
        }

        public Vector2 getPosition()
        {
            return position;
        }
        
        
    }
}