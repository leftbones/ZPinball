using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Program {
    static void Main(string[] args) {
        InitWindow((int)Global.WindowSize.X, (int)Global.WindowSize.Y, "ZPinball");
        SetTargetFPS(60);

        var Table = new Table(new Vector2(Global.WindowSize.X / 2, Global.WindowSize.Y / 2), 360, 640, 6);
        var Physics = new Physics(Table);

        while (!WindowShouldClose()) {
            //
            // Update
            var DT = GetFrameTime();
            Table.Update(DT);

            //
            // Draw
            BeginDrawing();
            ClearBackground(Global.BackgroundColor);

            Table.Draw();

            EndDrawing();
        }
    }
}
