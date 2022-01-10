using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class Ground : GameObject
    {

        public void setGround()
        {
            rect = new Rectangle(0, 700, 1300, 50);
            Raylib.DrawRectangleRec(rect, Color.BLACK);
        }

    }
}