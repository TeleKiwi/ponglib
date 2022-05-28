using System;
using Raylib_cs;

namespace src
{
    static class GameLoop
    {
        static void Main() {
            Game g = new Game(600, 600, "Ponglib");
            g.setFPS(60);
            
            while(g.isRunning()) {
                g.Tick();
            }

            g.end();        
        }
    }
}