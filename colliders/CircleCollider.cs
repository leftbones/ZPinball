using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class CircleCollider : Collider {
    public float Radius { get; set; }

    public CircleCollider(Vector3 position, float radius) : base(position) {
        Radius = radius;
    }

    public override void Draw() {
        DrawCircleV(new Vector2(Position.X, Position.Y), Radius, new Color(0, 255, 255, 50));
        DrawCircleLines((int)Position.X, (int)Position.Y, Radius, new Color(0, 255, 255, 255));
    }
}