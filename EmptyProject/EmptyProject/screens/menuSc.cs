using RLNET;

namespace EmptyProject.screens
{
    public class menuSc : screen
    {
        public menuSc(ScreenManager sM) : base(sM)
        {
        }

        public override void Update(object sender, UpdateEventArgs e)
        {
            a
        }

        public override void Render(object sender, UpdateEventArgs e)
        {
            sM.console.Clear();
            sM.console.Print(1, 1, "Hello World",RLColor.White);
            sM.console.Draw();
            
        }

        public override void Play()
        {
            sM.console.Update += Update;
            sM.console.Render += Render;
            sM.console.Run();
        }
    }
}