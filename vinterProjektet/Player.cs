using Raylib_cs;
using System.Numerics;
using System;

namespace vinterProjektet
{
    public class Player
    {
        public float playerX = 100;
        public float playerY = 100;
        private float playerSpeed = 0.3f;
       // public Vector2 movement= new Vector2();

        public void test(){

            Rectangle playerRect = new Rectangle(playerX,playerY,50,50);
            Raylib.DrawRectangleRec(playerRect, Color.PINK);

        }

        public void Update() {

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


            // playerX = playerSpeed;           

            
        }
    }


}