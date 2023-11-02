using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class CircleShape : Shape {
    public float Radius { get; private set; }

    public CircleShape(float radius) : base() {
        Radius = radius;
    }

    public override void Draw() {
        DrawCircleLines((int)Position.X, (int)Position.Y, Radius, Color.WHITE);
    }
}