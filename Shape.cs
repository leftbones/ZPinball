using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Shape {
    public Vector2 Position { get; set; }
    public Color Color { get; set; }

    public Shape(Color? color=null) {
        Color = color ?? Color.WHITE;
    }

    public virtual void Update() {

    }

    public virtual void Draw() {
        if (Global.DrawOrigins) {
            DrawLineEx(Position - new Vector2(0, 5), Position + new Vector2(0, 5), 1.0f, Color);
            DrawLineEx(Position - new Vector2(5, 0), Position + new Vector2(5, 0), 1.0f, Color);
        }
    }
}