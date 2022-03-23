using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class EnemyBig : Enemy
    {
        public EnemyBig()
        {
            enemyX = 1000;
            enemyY = 100;
            enemySpeed = 0.3f;
        }

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(enemyX, enemyY, 80, 80);
            Raylib.DrawRectangleRec(rect, Color.ORANGE);
        }





    }
}