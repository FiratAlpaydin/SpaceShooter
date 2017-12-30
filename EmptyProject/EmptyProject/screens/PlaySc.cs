using System;
using System.Security.Cryptography.X509Certificates;
using RLNET;

namespace EmptyProject.screens
{
    public class PlaySc :screen
    {
        
        int x = 1;
        private double timer;
        public PlaySc(ScreenManager sM) : base(sM)
        {
            
        }

        public override void Update(object sender, UpdateEventArgs e)
        {
            
        }

        public override void Render(object sender, UpdateEventArgs e)
        {
            sM.console.Clear();
            timer += e.Time;
            if (timer >0.2)
            {
                x++;
                timer = 0;
            }
                sM.console.Print(10, 10, drawBomb(x), RLColor.White);
                        

            sM.console.Draw();
        }

        public override void Play()
        {
            sM.console.Update += Update;
            sM.console.Render += Render;
            
        }

        public string drawBomb(int x)
        {
            char ret = 'a';
            switch (x)
            {
                    case 1:
                        ret = (char)7;
                        break;
                    case 2:
                        ret = (char) 9;
                        break;
                    case 3:
                        ret = (char) 42;
                        break;
                    case 4:
                        ret = (char) 15;
                        break;
                    default:
                        ret = ' ';
                        break;
                        
            }
            return ret.ToString();
        }

        public override void Dispose()
        {
            
        } 
    }
}