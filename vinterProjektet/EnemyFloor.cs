using System;
using Raylib_cs;

namespace vinterProjektet
{
    public class EnemyFloor : Enemy
    {
        public EnemyFloor()
        {
            enemyX = 700;
            enemyY = 680;
            enemySpeed = 0.0f;
            damage = 66;
        }

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(enemyX, enemyY, 300, 40);
            Raylib.DrawRectangleRec(rect, Color.RED);
        }
    }
}