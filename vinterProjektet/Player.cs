using Raylib_cs;
using System.Numerics;
using System;

namespace vinterProjektet
{
    public class Player : GameObject
    {
        public float playerX = 100;
        public float playerY = 100;
        private float playerSpeed = 1.3f;
        int newHp;

        Weapon sword = new Weapon();


        int timer = 0;

        // Hp sakerna
        private int hp = 100;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                // hp = newHp;
                hp = Math.Clamp(value, 0, 100);
            }
        }

        //Draw
        public override void Draw()
        {
            rect = new Rectangle(playerX, playerY, 50, 50);
            Raylib.DrawRectangleRec(rect, Color.PINK);
        }

        public string playerFacing = "";

        //Update
        public override void Update()
        {
            base.Update();


            //movement
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                playerX += playerSpeed;
                playerFacing = "right";
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                playerX -= playerSpeed;
                playerFacing = "left";
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                playerY += playerSpeed;
            }

            //gravity

            velocityY += gravity;

            //galen info
            Raylib.DrawText(velocityY.ToString(), 120, 50, 20, Color.BLUE);

            Raylib.DrawText(Hp.ToString(), 50, 50, 20, Color.RED);

            // overlaping with ground
            // detta gör så att man inte åker in genom marken
            bool isGrounded = false;
            foreach (GameObject obj in allGameObjects)
            {
                if (obj is Ground)
                {
                    bool areOverlapping = Raylib.CheckCollisionRecs(rect, obj.rect); // true

                    if (areOverlapping == true)
                    {
                        // gravity = 0;
                        velocityY = 0;
                        isGrounded = true;
                    }
                }
            }

            //Weapon saker
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT_SHIFT))
            {
                sword.DealDamage(this);
            }

            // enemy saker
            if (timer > 0)
            {
                timer--;
            }
            // detta tar bort hp när man collidar och det tar inte allt hp skit snabbt
            bool hitByEnemy = false;

            foreach (GameObject enemy in allGameObjects)
            {
                if (enemy is Enemy)
                {
                    hitByEnemy = Raylib.CheckCollisionRecs(rect, enemy.rect); // true


                    if (hitByEnemy == true && timer == 0)
                    {
                        newHp = hp - ((Enemy)enemy).damage;
                        hp = newHp;

                        hitByEnemy = true;
                        timer = 80;

                    }
                }
            }
            bool hitByEnemyFloor = false;
            foreach (GameObject enemyFloor in allGameObjects)
            {
                if (enemyFloor is EnemyFloor)
                {
                    hitByEnemyFloor = Raylib.CheckCollisionRecs(rect, enemyFloor.rect); // true

                    if (hitByEnemyFloor == true && timer == 0)
                    {
                        newHp = hp - ((EnemyFloor)enemyFloor).damage; ;
                        hp = newHp;

                        hitByEnemyFloor = true;
                        timer = 80;

                    }
                }
            }


            // hopp
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP) && isGrounded)
            {
                velocityY = -6;
            }

            playerY += velocityY;


        }
    }


}