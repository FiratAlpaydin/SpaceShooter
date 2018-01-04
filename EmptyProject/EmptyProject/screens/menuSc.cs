using System;
using System.Diagnostics.PerformanceData;
using System.Runtime.ConstrainedExecution;
using RLNET;

namespace EmptyProject.screens
{
    public class menuSc : screen
    {
        private const string PLAY = "PLAY";
        private const string CREDIT = "CREDITS";
        private const string QUIT = "QUIT";
        private const string sPLAY = ">PLAY<";
        private const string sCREDIT = ">CREDITS<";
        private const string sQUIT = ">QUIT<";
        //private readonly string[] BUTTONS = {PLAY, OPTIONS, QUIT};
        //private readonly string[] sBUTTONS = {sPLAY, sOPTIONS, sQUIT};

        private int lineCount = 1;
        
        //int consoleWidth = 35;
        //int consoleHeight = 50;

        //private RLConsole console;
        
        public menuSc(ScreenManager sM) : base(sM)
        {
            //console = new RLConsole(consoleWidth,consoleHeight);
            //console.SetBackColor(0,0,consoleWidth,consoleHeight,RLColor.Blue);
        }

        public override void Update(object sender, UpdateEventArgs e)
        {
            RLKeyPress keyPress = sM.console.Keyboard.GetKeyPress();
            if (keyPress != null)
            {
                if (keyPress.Key == RLKey.Up)
                {
                    lineCount--;
                }else if (keyPress.Key == RLKey.Down)
                {
                    lineCount++;
                }else if (keyPress.Key == RLKey.Enter)
                {
                    if (lineCount == 1)
                    {
                        PlaySc playSc = new PlaySc(sM);
                        sM.addConsole(playSc);
                        sM.play();
                        Dispose();
                    }else if (lineCount == 2)
                    {
                        CreditSc creditSc = new CreditSc(sM);
                        sM.addConsole(creditSc);
                        sM.play();
                        Dispose();
                        
                    
                        
                    }else if (lineCount == 3)
                    {
                        sM.console.Close();
                    }                    
                }
            }

            if (lineCount > 3)
            {
                lineCount = 1;
            }else if (lineCount < 1)
            {
                lineCount = 3;
            }
            
        }

        public override void Render(object sender, UpdateEventArgs e)
        {
            
            sM.console.Clear();
            //RLConsole.Blit(console,0,0,35,50,sM.console,(sM.console.Width/2)-(consoleWidth/2),(sM.console.Height/2)-(consoleHeight/2));
            /*for (int i = 1; i < BUTTONS.Length+1; i++)
            {
                if (lineCount == i)
                {
                    sM.console.Print((sM.console.Width / 2) - (sBUTTONS[i].Length / 2), sM.console.Height / 2 - i*5, sBUTTONS[i],RLColor.White);
                    sM.console.Draw();
                }
                else
                {
                    sM.console.Print((sM.console.Width/2)-(BUTTONS[i].Length/2), sM.console.Height / 2-i*5, BUTTONS[i],RLColor.White);
                    sM.console.Draw();
                }
            }*/ // HOCAYA BUNU SOR.
            
            if (lineCount == 1)
            {
                sM.console.Print((sM.console.Width / 2) - (sPLAY.Length / 2), sM.console.Height / 2 - 15, sPLAY,RLColor.White);
            }
            else
            {
                sM.console.Print((sM.console.Width/2)-(PLAY.Length/2), sM.console.Height / 2-15, PLAY,RLColor.White);
            }
            
            if (lineCount == 2)
            {
                sM.console.Print((sM.console.Width / 2) - (sCREDIT.Length / 2), sM.console.Height / 2 - 10, sCREDIT,RLColor.White);
            }
            else
            {
                sM.console.Print((sM.console.Width/2)-(CREDIT.Length/2), sM.console.Height / 2-10, CREDIT,RLColor.White);
            }
            
            if (lineCount == 3)
            {
                sM.console.Print((sM.console.Width / 2) - (sQUIT.Length / 2), sM.console.Height / 2 - 5, sQUIT,RLColor.White);
            }
            else
            {
                sM.console.Print((sM.console.Width/2)-(QUIT.Length/2), sM.console.Height / 2-5, QUIT,RLColor.White);
            }
            
            
            sM.console.Draw();
            
        }

        public override void Play()
        {
            sM.console.Update += Update;
            sM.console.Render += Render;
            sM.console.Run();
        }

        public override void Dispose()
        {
            sM.console.Update -= Update;
            sM.console.Render -= Render;
        }
    }
}