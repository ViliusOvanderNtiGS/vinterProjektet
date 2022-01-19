using Raylib_cs;
using System.Numerics;
using System;

namespace vinterProjektet
{
    public class Player : GameObject
    {
        private float playerX = 100;
        private float playerY = 100;
        private float playerSpeed = 1.3f;

        // public int Hp { get; set; }

        //hp

        private int hp = 100;

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = Math.Clamp(value, 0, 100);
            }
        }


        // public Vector2 movement= new Vector2();

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(playerX, playerY, 50, 50);
            Raylib.DrawRectangleRec(rect, Color.PINK);
        }

        //Update
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

            //galen info
            Raylib.DrawText(velocityY.ToString(), 120, 50, 20, Color.BLUE);

            Raylib.DrawText(Hp.ToString(), 50, 50, 20, Color.RED);

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