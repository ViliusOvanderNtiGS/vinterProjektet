using Raylib_cs;
using System.Numerics;
using System;

namespace vinterProjektet
{
    public class Player : GameObject
    {
        public float playerX = 100;
        public float playerY = 100;
        private float playerSpeed = 1f;


        // public Vector2 movement= new Vector2();


        public override void Draw()
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

            //gravity

            velocityY += gravity;


            // overlaping with ground

            bool isGrounded = false;
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
                        isGrounded = true;
                    }
                    else
                    {
                        // gravity = 0.5f;
                    }
                }
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP) && isGrounded)
            {
                // playerY -= playerSpeed * 2;
                velocityY = -6;
            }




            playerY += velocityY;





            // playerX = playerSpeed;           


        }
    }


}