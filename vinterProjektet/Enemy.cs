using System;
using Raylib_cs;
using System.Numerics;

namespace vinterProjektet
{
    public class Enemy : GameObject
    {
        private float enemyY = 100;
        private float enemyX = 900;
        private float enemySpeed = 0.4f;

        //hp
        // private int hp = 100;

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(enemyX, enemyY, 50, 50);
            Raylib.DrawRectangleRec(rect, Color.RED);
        }

        //Update
        public override void Update()
        {
            base.Update();

            /*
            //movement
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                enemyX += enemySpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                enemyX -= enemySpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                enemyY += enemySpeed;
            }
            */
            enemyX -= enemySpeed;

            //gravity

            velocityY += gravity;


            // overlaping with ground
            //bool isGrounded = false;
            foreach (GameObject obj in allGameObjects)
            {
                if (obj is Ground)
                {
                    bool areOverlapping = Raylib.CheckCollisionRecs(rect, obj.rect); // true
                    Console.WriteLine(areOverlapping);

                    if (areOverlapping == true)
                    {
                        // gravity = 0;
                        velocityY = 0;
                        // isGrounded = true;
                    }
                    else
                    {
                        // gravity = 0.5f;
                    }
                }
            }
            /*
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP) && isGrounded)
            {
                // enemyY -= enemySpeed * 2;
                velocityY = -6;
            }
            */

            enemyY += velocityY;



        }
    }
}