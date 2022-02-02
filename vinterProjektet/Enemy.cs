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

            enemyX -= enemySpeed;

            //gravity

            velocityY += gravity;


            //overlaping with ground
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

                }
            }

            enemyY += velocityY;



        }
    }
}