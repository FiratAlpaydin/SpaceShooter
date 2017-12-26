using System;
using RLNET;

namespace EmptyProject
{
    public class Engine
    {
        private RLRootConsole rootConsole;
        private int playerX;
        private int playerY;

        public Engine(RLRootConsole console)
        {
            rootConsole = console;
            rootConsole.Render += Render;
            rootConsole.Update += Update;
        }
 
        public void Render(object sender, UpdateEventArgs e)
        {
            rootConsole.Clear();
        }

 
        public void Update(object sender, UpdateEventArgs e)
        {
            RLKeyPress keyPress = rootConsole.Keyboard.GetKeyPress();
            if (keyPress != null)
            {
                switch (keyPress.Key)
                {
                    case RLKey.Up: playerY--; break;
                    case RLKey.Down: playerY++; break;
                    case RLKey.Left: playerX--; break;
                    case RLKey.Right: playerX++; break;
                }
            }
        }


    }
}