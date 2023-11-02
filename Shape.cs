using System.Numerics;

namespace ZPinball;

class Shape {
    public Element? Parent { get; set; }
    public Vector2 Position { get; set; }

    public Shape() {

    }

    public virtual void Update() {
        if (Parent is not null) {
            Position = new Vector2(Parent.Position.X, Parent.Position.Y);
        }
    }

    public virtual void Draw() {

    }
}