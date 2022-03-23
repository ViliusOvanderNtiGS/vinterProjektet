using System;
using Raylib_cs;
using System.Numerics;

namespace vinterProjektet
{
    public class Enemy : GameObject
    {


        protected float startX, startY;

        public float enemyX = 900;
        public float enemyY = 100;
        protected float enemySpeed = 0.4f;

        public void SetStartPosition(float x, float y)
        {
            enemyX = startX = x;
            enemyY = startY = y;
        }

        public override void Reset()
        {
            enemyX = startX;
            enemyY = startY;
        }

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
            // samma som i player
            // den gör så skiten inte rammlar
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