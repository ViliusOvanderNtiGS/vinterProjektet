using System;
using Raylib_cs;

namespace vinterProjektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Mege men");
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


                Raylib.ClearBackground(Color.WHITE);

                foreach (GameObject gamer in GameObject.allGameObjects)
                {
                    gamer.Update();
                    gamer.Draw();
                }


                Raylib.EndDrawing();
            }


        }
    }
}
