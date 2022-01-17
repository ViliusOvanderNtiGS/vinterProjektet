using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class Ground : GameObject
    {

        public void setGround()
        {


            Raylib.DrawRectangleRec(rect, Color.BLACK);

            // rect = new Rectangle(600, 500, 1300, 50);
            // Raylib.DrawRectangleRec(rect, Color.ORANGE);

        }

    }
}