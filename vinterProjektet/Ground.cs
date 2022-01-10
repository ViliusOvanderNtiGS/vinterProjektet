using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class Ground
    {
        
        public void setGround(){
            Rectangle floorRect = new Rectangle(0,700,1300,50);
            Raylib.DrawRectangleRec(floorRect, Color.BLACK);
        }

    }
}