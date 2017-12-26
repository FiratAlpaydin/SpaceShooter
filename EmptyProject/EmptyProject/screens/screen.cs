using System;
using RLNET;
namespace EmptyProject.screens
{
    public abstract class screen
    {
        protected ScreenManager sM;

        protected screen(ScreenManager sM)
        {
            this.sM = sM;
        }

        public abstract void Update(object sender,UpdateEventArgs e);
        public abstract void Render(object sender,UpdateEventArgs e);
        public abstract void Play();

    }
    
}