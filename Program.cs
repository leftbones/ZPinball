using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

// TODO
// - Add "Engine" class to handle table, physics, creation of elements, etc.

class Program {
    static void Main(string[] args) {
        InitWindow((int)Global.WindowSize.X, (int)Global.WindowSize.Y, "ZPinball");
        SetTargetFPS(60);

        var Table = new Table(new Vector2(Global.WindowSize.X / 2, Global.WindowSize.Y / 2), 360, 640, 6);
        var Physics = new Physics(Table);

        Physics.AddElement(new Wall(
            new Vector3(Table.Position.X, Table.Position.Y, 0),
            new PolyShape(new List<Vector2>() {
                new(0, 0),
                new(Table.Size.X, 0),
                new(Table.Size.X, Table.Size.Y),
                new(Table.Size.X - 150, Table.Size.Y),
                new(Table.Size.X - 150, Table.Size.Y - 25),
                new(Table.Size.X - 25, Table.Size.Y - 50),
                new(Table.Size.X - 25, 25),
                new(25, 25),
                new(25, Table.Size.Y - 50),
                new(150, Table.Size.Y - 25),
                new(150, Table.Size.Y),
                new(0, Table.Size.Y)
            }, Color.WHITE)
        ));

        Physics.AddElement(new Flipper(new Vector3(Table.Origin.X - 75, Table.Position.Y + Table.Size.Y - 75, 0), false));
        Physics.AddElement(new Flipper(new Vector3(Table.Origin.X + 75, Table.Position.Y + Table.Size.Y - 75, 0), true));

        Physics.AddBall();

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
