using System;
using Raylib_cs;

namespace src 
{
    class Game
    {
        public float delta;

        public int fpsCap;

        // constructor
        public Game(int winX, int winY, string title) {
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
            return delta;
        }

        public void setFPS(int fps) {
            fpsCap = fps;
            Raylib.SetTargetFPS(fps);
        }

        public void Tick() {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            Raylib.DrawFPS(0, 0);

            Raylib.DrawText("Hello, world!", 0, 14, 20, Color.WHITE);
            
            Raylib.EndDrawing();

            delta = Raylib.GetFrameTime();
        }
    }
}