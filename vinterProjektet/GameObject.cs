using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace vinterProjektet
{
    public class GameObject
    {
        protected float gravity = 0.05f;

        protected float velocityY = 0;

        public Rectangle rect;

        // public Vector2 velocity;



        //Detta gör så att jag enkelt kan rita ut allt utan att behöva skriva någpt extra
        //Allt som ärvs av GameObject hammnar i listan automatiskt och sen ritas ut

        public static List<GameObject> allGameObjects = new List<GameObject>();

        public GameObject()
        {
            allGameObjects.Add(this);
        }


        //Detta är det som uppdaterar allt automatiskt åt mig
        public virtual void Update()
        {
            //antal game objects
            Raylib.DrawText(allGameObjects.Count.ToString(), 100, 50, 20, Color.ORANGE);

        }

        public virtual void Draw()
        {
            Raylib.DrawRectangleRec(rect, Color.BLACK);
        }


        // bool areOverlapping = Raylib.CheckCollisionRecs(Player.playerRect, Ground.enemyRect); // true
    }
}