using System;
using System.Collections;
using RLNET;

namespace EmptyProject
{
    public class ScreenManager
    {
        public RLRootConsole console;
        private Stack screenStack;
        
        public ScreenManager(RLRootConsole console)
        {
            
            screenStack = new Stack();    
            this.console = console;
        }

        public void addConsole(screens.screen screen)
        {
            screenStack.Push(screen);
            
        }

        public void removeScreen()
        {
            screenStack.Pop();
        }

        public void setScreen(screens.screen screen)
        {
            screenStack.Pop();
            screenStack.Push(screen);
        }

        public void play()
        {
            
            screens.screen screen = (screens.screen)screenStack.Peek();
            screen.Play();
        }
        
        
        
        
    }
}