using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class Ground : GameObject
    {
        //den här klassen är lite onödig kanske tycker jag
        //det är bara en sak
        public void setGround()
        {

            Raylib.DrawRectangleRec(rect, Color.BLACK);

        }

    }
}