using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using EmptyProject.Entity;
using EmptyProject.Entity.Weapon;
using OpenTK;
using OpenTK.Graphics.ES20;
using RLNET;

namespace EmptyProject.screens
{
    public class PlaySc :screen
    {
        
        int x = 1;
        public int score = 0;
        private Player player;
        private double timer;
        private double timer1;
        private double timer2;
        private double timer3;
        private List<Entity.Entity> entities = new List<Entity.Entity>();
        private List<Enemy> enemies = new List<Enemy>();
        private List<Bullet> bullets = new List<Bullet>();
        private Vector2 playerPosition;
        public PlaySc(ScreenManager sM) : base(sM)
        {
            player = new Player(5);
            playerPosition = new Vector2(sM.console.Width-40,sM.console.Height-20);
            player.drawPLayer(playerPosition,sM.console);
            entities.Add(player);
            
            
        }

        public override void Update(object sender, UpdateEventArgs e)
        {
            
            RLKeyPress keyPress = sM.console.Keyboard.GetKeyPress();
            
            if (keyPress != null)
            {
                switch (keyPress.Key)
                {
                    case RLKey.Up:
                        playerPosition.Y--;
                        break;
                    case RLKey.Down:
                        playerPosition.Y++; 
                        break;
                    case RLKey.Left:
                        playerPosition.X--; 
                        break;
                    case RLKey.Right:
                        playerPosition.X++; 
                        break;
                }
            }
            
            //MAP BORDER===================
            if (playerPosition.X < 3)
            {
                playerPosition.X = 3;
            }else if (playerPosition.X > 56)
            {
                playerPosition.X = 56;
            }

            if (playerPosition.Y > sM.console.Height-3)
            {
                playerPosition.Y = sM.console.Height - 3;
            }else if (playerPosition.Y < 3)
            {
                playerPosition.Y = 3;
            }
            //==============================

            foreach (Enemy enemy in enemies)
            {
                foreach (Bullet bullet in bullets)
                {
                    Vector2 bulletv2_1 = new Vector2(bullet.prev1X,bullet.prev1Y-2);
                    Vector2 bulletv2_2 = new Vector2(bullet.prev2X,bullet.prev1Y-2);
                    int x = (int) enemy.position.X;
                    int y = (int) enemy.position.Y;
                    Vector2 enemyVector2 = new Vector2(x,y);
                    if (enemyVector2 == bulletv2_1 || enemyVector2 == bulletv2_2 )
                    {
                        enemy.live = false;
                        bullet.live = false;
                        score++;
                    }
                }
            }
        }

        public override void Render(object sender, UpdateEventArgs e)
        {
            sM.console.Clear();
            //Vector2 pV2 = new Vector2(sM.console.Width/2,sM.console.Height/2);
            //player.drawPLayer(pV2,sM.console);
            
            
            //=======================TIMERS
            timer += e.Time;
            timer1 += e.Time;
            timer2 += e.Time;
            timer3 += e.Time;
            if (timer >0.6)
            {
                Bullet newBullet = new Bullet(sM.console,player);
                bullets.Add(newBullet);
                x++;
                timer = 0;
            }

            if (timer1>1)
            {
                Random rand = new Random();
                Vector2 enemyPosition = new Vector2(rand.Next(0,57),0);
                Enemy enemy = new Enemy(1,0,enemyPosition);
                enemies.Add(enemy);
                timer1 = 0;
            }
            
            if (timer2>0.05)  
            {
                foreach (Bullet ammo in bullets)
                {
                    ammo.drawBullet();
                }
                timer2 = 0;
            }

            if (timer3>0.4)
            {
                foreach (Enemy enemy in enemies)
                {
                    enemy.position.Y++;
                }
                timer3 = 0;
            }
            //=======================================
            
            foreach (Bullet ammoBullet in bullets)
            {
                ammoBullet.drawCur();
            }
            sM.console.Print(10, 10, drawBomb(x), RLColor.White);
            
            
            // ENTITY DRAWS
            player.drawPLayer(playerPosition,sM.console );
            foreach (Enemy enemy in enemies)
            {
                enemy.enemyDraw(sM.console);
            }
            
            //==============
            
            for (int i = 0; i < sM.console.Height; i++)
            {
                sM.console.Print(59, i, ((char) 179).ToString(), RLColor.White);
            }


            sM.console.Print(62, 20, "HEALTH", RLColor.White);
            sM.console.Print(64, 25, player.health.ToString(), RLColor.White);
            sM.console.Print(62, 30,"SCORE",RLColor.White);
            sM.console.Print(63, 35, score.ToString(), RLColor.White);
            sM.console.Draw();
            
            
        }

        public override void Play()
        {
            sM.console.Update += Update;
            sM.console.Render += Render;
            
        }

        public void MoveEntities()
        {
            
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