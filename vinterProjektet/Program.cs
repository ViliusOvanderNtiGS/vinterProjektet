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

            while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

      
            Raylib.ClearBackground(Color.WHITE);
      
            //golvet
            Rectangle floorRect = new Rectangle(0,700,1300,50);
            Raylib.DrawRectangleRec(floorRect, Color.BLACK);

            megeMan.test();
            megeMan.Update();


      
            Raylib.EndDrawing();
        }
            
            
        }
    }
}
