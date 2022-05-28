using System;
using Raylib_cs;

namespace src 
{
    class Player
    {
        public int x;
        public int y;

        public int yVel;

        public int pCode;

        public Player(int xPos, int yPos, int player) {
            x = xPos;
            y = yPos;
            pCode = player;
        }

        public void Move() {
            checkInp(pCode);
            int futureY = Convert.ToInt16(yVel * Game.delta);
            // if(futureY < 0) { return; }
            // if(futureY > Game.wHeight) { return; }
            y += futureY;
        }

        private void checkInp(int pC) {
            if(pC == 0) {
                if(Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
                    yVel = 5;
                } else if(Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
                    yVel = -5;
                } else {
                    yVel = 0;
                } 
            } else {
                if(Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    yVel = 5;
                } else if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    yVel = -5;
                } else {
                    yVel = 0;
                } 
            }
        }
    }
}

// 30 px padding