using OpenTK;
using OpenTK.Input;

namespace EmptyProject.Entity
{
    public class Entity
    {
        public int health;

        public Vector2 position;

        public Entity(int health)
        {
            this.health = health;
            
        }

    }
}