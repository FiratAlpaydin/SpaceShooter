using System;
using RLNET;

namespace EmptyProject.screens
{
    public class CreditSc : screen
    {
        private int x ;
        private int y;
        private double timer;
        
        public CreditSc(ScreenManager sM) : base(sM)
        {
            x = sM.console.Width / 2;
            y = sM.console.Height;
        }

        public override void Update(object sender, UpdateEventArgs e)
        {
            timer += e.Time;
            if (timer>0.3)
            {
                y--;
                timer = 0;
            }
            RLKeyPress keyPress = sM.console.Keyboard.GetKeyPress();
            if (keyPress != null)
            {
                if (keyPress.Key == RLKey.Escape)
                {
                    sM.removeScreen();
                    
                    Dispose();
                    sM.play();
                }
            }


        }

        public override void Render(object sender, UpdateEventArgs e)
        {
            sM.console.Clear();
            sM.console.Print(x-7, y, "--CONSOLE GUYS--",RLColor.White);
            sM.console.Print(x-6, y+3, "FIRAT ALPAYDIN", RLColor.White);
            sM.console.Print(x-7, y+6, "SECKIN EGE AYDEMIR", RLColor.White);
            sM.console.Print(x-7, y+9, "BATUHAN CANATAR", RLColor.White);
            sM.console.Draw();
                
        }

        public override void Play()
        {
            sM.console.Update += Update;
            sM.console.Render += Render;
        }

        public override void Dispose()
        {
            sM.console.Update -= Update;
            sM.console.Render -= Render;
        }
    }
}