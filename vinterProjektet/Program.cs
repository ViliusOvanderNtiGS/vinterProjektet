using System;
using Raylib_cs;
using System.Numerics;

namespace vinterProjektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Mege men");
            //Raylib.SetTargetFPS(500); Detta ville tydligen inte fixa att spelet blir snabbt efter en stund 
            Player megeMan = new Player();
            Enemy goober = new Enemy();
            EnemyBig bloober = new EnemyBig();
            EnemyFloor floober = new EnemyFloor();

            // kan sätta hå till vad man vill den kommer ändå vara max 100
            megeMan.Hp = 900;

            //floor generation

            Ground floor = new Ground();
            floor.rect = new Rectangle(0, 700, 1300, 25);

            Ground floor2 = new Ground();
            floor2.rect = new Rectangle(600, 500, 1300, 25);

            Raylib.SetTargetFPS(120);

            int currentRoom = 0;


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (Raylib.IsKeyDown(KeyboardKey.KEY_ESCAPE))
                {
                    Raylib.CloseWindow();
                }


                //Game State



                if (currentRoom == 0) //intro screen
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Raylib.DrawText("test", 50, 50, 20, Color.ORANGE);
                    Texture2D intro = Raylib.LoadTexture("instruktioner.png");
                    Raylib.DrawTextureEx(intro, new Vector2(0, 100), 0, 0.5f, Color.WHITE);


                    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                    {
                        currentRoom = 1;
                    }
                }

                if (currentRoom == 1) // game screen
                {
                    Raylib.ClearBackground(Color.WHITE);

                    foreach (GameObject gamer in GameObject.allGameObjects)
                    {
                        gamer.Update();
                        gamer.Draw();
                    }

                    if (megeMan.Hp <= 0)
                    {
                        currentRoom = 2;
                    }

                    if (megeMan.playerY >= 1000)
                    {
                        currentRoom = 3;
                    }

                }

                if (currentRoom == 2) //death screen
                {
                    Raylib.ClearBackground(Color.WHITE);

                    Texture2D death = Raylib.LoadTexture("Aironas.png");
                    Raylib.DrawTextureEx(death, new Vector2(0, 100), 0, 1f, Color.WHITE);

                    //Reset
                    Reset(currentRoom, megeMan, goober, bloober);
                    // press enter to try again
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                    {
                        currentRoom = 1;
                    }
                }

                if (currentRoom == 3) //The cube has fallen
                {
                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawText("the cube has fallen..", 300, 300, 50, Color.DARKPURPLE);
                    Raylib.DrawText("tryck enter", 300, 400, 50, Color.DARKGREEN);
                    //Texture2D death = Raylib.LoadTexture("Aironas.png");
                    //Raylib.DrawTextureEx(death, new Vector2(0, 100), 0, 1f, Color.WHITE);

                    //Reset
                    Reset(currentRoom, megeMan, goober, bloober);
                    // press enter to try again
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                    {
                        currentRoom = 1;
                    }
                }



                Raylib.EndDrawing();


            }


        }
        static void Reset(int currentRoom, Player megeMan, Enemy goober, EnemyBig bloober)
        {
            //Reset
            megeMan.Hp = 100;
            megeMan.playerX = 100;
            megeMan.playerY = 100;
            goober.enemyX = 900;
            goober.enemyY = 100;
            bloober.enemyX = 1000;
            bloober.enemyY = 100;


        }

    }
}
