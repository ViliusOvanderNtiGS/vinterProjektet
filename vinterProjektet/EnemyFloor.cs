using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class EnemyFloor : Enemy
    {
        public EnemyFloor()
        {
            enemyX = 1000;
            enemyY = 100;
            enemySpeed = 0.0f;
        }

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(enemyX, enemyY, 40, 200);
            Raylib.DrawRectangleRec(rect, Color.RED);
        }
    }
}