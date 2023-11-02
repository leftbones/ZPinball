using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class PolyCollider : Collider {
    public List<Vector3> Points { get; private set; }

    public PolyCollider(Vector3 position, List<Vector3> points) : base(position) { 
        Points = points;
    }

    public override void Draw() {
        DrawLineEx(new Vector2(0, Position.Y - 5), new Vector2(0, Position.Y + 5), 1.0f, Color.SKYBLUE);
        DrawLineEx(new Vector2(Position.X - 5, 0), new Vector2(Position.X + 5, 0), 1.0f, Color.SKYBLUE);

        var P = new Vector2(Points[0].X, Points[0].Y);
        foreach (var Point in Points) {
            DrawLineEx(P, new Vector2(Point.X, Point.Y), 1.0f, Color.SKYBLUE);
            P = new Vector2(Point.X, Point.Y);
        }

        DrawLineEx(P, new Vector2(Points[0].X, Points[0].Y), 1.0f, Color.SKYBLUE);
    }
}