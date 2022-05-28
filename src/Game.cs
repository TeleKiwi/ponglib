using System;
using Raylib_cs;

namespace src 
{
    class Game
    {
        public static float delta;
        public static int fps;
        public static int wLen;
        public static int wHeight;

        public int fpsCap;

        Player p1 = new Player(30, 0, 25, 105, 0);
        Player p2 = new Player(550, 0, 25, 105, 1);

        // constructor
        public Game(int winX, int winY, string title) {
            wLen = winX;
            wHeight = winY;
            Raylib.InitWindow(winX, winY, title);
        }

        // destructor
        public void end() {
            Raylib.CloseWindow();
        }

        public bool isRunning() {
            return !Raylib.WindowShouldClose();
        }

        public float getDelta() {
            return Raylib.GetFrameTime();
        }

        public void getFPS() {
            fps = Raylib.GetFPS();
        }

        public void setFPS(int fps) {
            fpsCap = fps;
            Raylib.SetTargetFPS(fps);
        }


        public void Tick() {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            getFPS();
            Raylib.DrawText($"FUTY: {p1.futureY}", 0, 0, 20, Color.WHITE);
            
            // Raylib.DrawText($"P1 VEL: {p1.yVel}", 0, 16, 20, Color.WHITE);
            // Raylib.DrawText($"P2 VEL: {p2.yVel}", 0, 35, 20, Color.WHITE);

            // Raylib.DrawText($"P1 Y: {p1.y}", 0, 51, 20, Color.WHITE);
            // Raylib.DrawText($"P2 Y: {p2.y}", 0, 67, 20, Color.WHITE);

            // Raylib.DrawText($"DELTA: {delta}", 0, 83, 20, Color.WHITE);
  
            p1.Move();
            p2.Move();

            Draw();

            Raylib.EndDrawing();

            delta = getDelta();
        }

        private void Draw() {
            Raylib.DrawRectangle(p1.x, p1.y, 25, 105, Color.WHITE); // draw p1
            Raylib.DrawRectangle(p2.x, p2.y, 25, 105, Color.WHITE); // draw p2
        }
    }
}