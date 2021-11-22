using Raylib_cs;
using System;

namespace vinterProjektet
{
    public class Player
    {
        public int x = 100;
        public int y = 100;
       
        
        public void Update() {
            Rectangle playerRect = new Rectangle(x,y,50,50);
            Raylib.DrawRectangleRec(playerRect, Color.PINK);
        }
    }


}