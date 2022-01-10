using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace vinterProjektet
{
    public class GameObject
    {
        private float gravity = 0.5f;

        public Rectangle rect;

        public Vector2 velocity;



        public static List<GameObject> allGameobjects = new List<GameObject>();

        public GameObject()
        {

            allGameobjects.Add(this);
        }

        public virtual void Update()
        {


            //collisin 
            Raylib.DrawText(allGameobjects.Count.ToString(), 100, 50, 20, Color.ORANGE);


            /*
            //gravity
            rect.x += velocity.X;
            rect.y += velocity.Y;
            */


        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(rect, Color.BLUE);
        }


        // bool areOverlapping = Raylib.CheckCollisionRecs(Player.playerRect, Ground.enemyRect); // true
    }
}