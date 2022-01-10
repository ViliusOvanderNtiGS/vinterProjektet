using Raylib_cs;
using System.Numerics;
using System;

namespace vinterProjektet
{
    public class Player : GameObject
    {
        public float playerX = 100;
        public float playerY = 100;
        private float playerSpeed = 0.5f;
        private float gravity = 0.5f;

        // public Vector2 movement= new Vector2();

        public void spawnPlayer()
        {
            rect = new Rectangle(playerX, playerY, 50, 50);
            Raylib.DrawRectangleRec(rect, Color.PINK);
        }

        public override void Update()
        {
            base.Update();
            /*
                        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT_SHIFT))
                        {
                            playerSpeed = 1f;
                        }
            */

            //movement
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                playerX += playerSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                playerX -= playerSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                playerY += playerSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                playerY -= playerSpeed;
            }

            //gravity

            playerY += gravity;

            // overlaping with ground


            foreach (GameObject obj in allGameobjects)
            {
                if (obj is Ground)
                {
                    bool areOverlapping = Raylib.CheckCollisionRecs(rect, obj.rect); // true
                    Console.WriteLine(areOverlapping);

                    if (areOverlapping == true)
                    {
                        gravity = 0;
                    }
                }
            }





            // playerX = playerSpeed;           


        }
    }


}