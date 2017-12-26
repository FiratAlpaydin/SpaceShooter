using RLNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EmptyProject.screens;

namespace EmptyProject
{
    
    
    class RootProject
    {
        private static int playerX = 25;
        private static int playerY = 25;
        private static RLRootConsole rootConsole;
        private static int color;
        private static ScreenManager sM;

        public static void Main()
        {
            RLSettings settings = new RLSettings();
            settings.BitmapFile = "ascii_8x8.png";
            settings.CharWidth = 8;
            settings.CharHeight = 8;
            settings.Width = 60;
            settings.Height = 40;
            settings.Scale = 1f;
            settings.Title = "RLNET Sample";
            settings.WindowBorder = RLWindowBorder.Resizable;
            settings.ResizeType = RLResizeType.ResizeCells;
            settings.StartWindowState = RLWindowState.Normal;

            rootConsole = new RLRootConsole(settings);
            sM = new ScreenManager(rootConsole);
            menuSc menu = new menuSc(sM);
            sM.addConsole(menu);
            sM.play();

        }
    

    }
}