using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class Weapon
    {

        public int damage;
        private float hitboxPos = 50;

        public void DealDamage(Player player)
        {



            if (player.playerFacing == "right")
            {
                Rectangle rectSword = new Rectangle(player.playerX + hitboxPos, player.playerY + (float)15, 60, 15);
                Raylib.DrawRectangleRec(rectSword, Color.GRAY);
            }
            if (player.playerFacing == "left")
            {
                Rectangle rectSword = new Rectangle(player.playerX - hitboxPos, player.playerY + (float)15, 60, 15);
                Raylib.DrawRectangleRec(rectSword, Color.GRAY);
            }
            else
            {
                Rectangle rectSword = new Rectangle(player.playerX + hitboxPos, player.playerY + (float)15, 60, 15);
                Raylib.DrawRectangleRec(rectSword, Color.GRAY);
            }











        }
    }
}

// kan använda detta för notes
// 
// Jag kan förbättra genom att göra så att man kolliderar med en grön kub efter floor enemy 
// Något som kan vara koolt är att den kanske kan random generera banor med typ

//ta bort true false writeline
