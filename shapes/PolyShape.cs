using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class PolyShape : Shape {
    public List<Vector2> Points { get; private set; }

    public PolyShape(List<Vector2> points) : base() {
        Points = points;
    }

    public override void Draw() {
        DrawLineEx(Position - new Vector2(0, 5), Position + new Vector2(0, 5), 1.0f, Color.WHITE);
        DrawLineEx(Position - new Vector2(5, 0), Position + new Vector2(5, 0), 1.0f, Color.WHITE);

        var P = Points[0];
        foreach (var Point in Points) {
            DrawLineEx(P, Point, 1.0f, Color.WHITE);
            P = Point;
        }

        DrawLineEx(P, Points[0], 1.0f, Color.WHITE);
    }
}