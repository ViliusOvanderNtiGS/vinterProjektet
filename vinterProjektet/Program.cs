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
            Ground floor = new Ground();



            while (!Raylib.WindowShouldClose())
             {
                Raylib.BeginDrawing();

      
                Raylib.ClearBackground(Color.WHITE);
                
            
                floor.setGround();
                megeMan.spawnPlayer();

                    foreach (GameObject gamer in GameObject.allGameobjects)
                    {
                        gamer.Update();
                    }

      
            Raylib.EndDrawing();
        }
            
            
        }
    }
}
