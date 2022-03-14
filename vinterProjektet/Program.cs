using System;
using Raylib_cs;

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


            megeMan.Hp = 900;

            //floor generation

            Ground floor = new Ground();
            floor.rect = new Rectangle(0, 700, 1300, 50);

            Ground floor2 = new Ground();
            floor2.rect = new Rectangle(600, 500, 1300, 50);





            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();



                //Game State
                bool gameContinues = true;

                int currentRoom = 0;

                while (gameContinues == true)
                {
                    if (currentRoom == 0) //intro screen
                    {
                        Raylib.DrawText("test", 50, 50, 20, Color.ORANGE);

                        Raylib.ClearBackground(Color.WHITE);
                        Raylib.EndDrawing();

                        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                        {
                            currentRoom = 1;
                        }
                    }

                    if (currentRoom == 1) // game screen
                    {
                        Raylib.SetTargetFPS(120);
                        Raylib.ClearBackground(Color.WHITE);

                        foreach (GameObject gamer in GameObject.allGameObjects)
                        {
                            gamer.Update();
                            gamer.Draw();
                        }

                        Raylib.ClearBackground(Color.WHITE);
                        Raylib.EndDrawing();
                    }

                    else if (currentRoom == 2) //death screen
                    {
                        // kod för death screen
                    }
                }





            }


        }
    }
}
