using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class PolyShape : Shape {
    public List<Vector2> Points { get; set; }

    public PolyShape(List<Vector2> points, Color? color=null) : base(color) {
        Points = points;
    }

    public override void Draw() {
        var P = Points[0];
        foreach (var Point in Points) {
            DrawLineEx(Position + P, Position + Point, 1.0f, Color);
            P = Point;
        }

        DrawLineEx(Position + P, Position + Points[0], 1.0f, Color);

        base.Draw();
    }
}