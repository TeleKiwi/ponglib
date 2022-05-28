using System;
using Raylib_cs;

namespace src 
{
    class Player
    {
        public int x;
        public int y;
        public int futureY;
        public int yVel;

        public int w;
        public int h;

        public int speed = 5;

        

        public int pCode;

        public Player(int xPos, int yPos, int width, int height, int player) {
            x = xPos;
            y = yPos;
            w = width;
            h = height;
            pCode = player;
        }

        public void Move() {
            checkInp(pCode);
            futureY = Convert.ToInt16(yVel * Math.Ceiling(Game.delta));
            if(y < 0) { 
                y = 0;
                return; 
            }
            if(y > Game.wHeight - 105) { 
                y = Game.wHeight - 105;
                return; 
            }
            y += futureY;
        }

        private void checkInp(int pC) {
            if(pC == 0) {
                if(Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
                    yVel = 0 - speed;
                } else if(Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
                    yVel = speed;
                } else {
                    yVel = 0;
                } 
            } else {
                if(Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    yVel = 0 - speed;
                } else if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    yVel = speed;
                } else {
                    yVel = 0;
                } 
            }
        }
    }
}

// 30 px padding