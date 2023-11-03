using System.Numerics;

namespace ZPinball;

class Element {
    public Vector3 Position { get; set; }
    public float X { get { return Position.X; } set { Position = new Vector3(value, Y, Z); } }
    public float Y { get { return Position.Y; } set { Position = new Vector3(X, value, Z); } }
    public float Z { get { return Position.Z; } set { Position = new Vector3(X, Y, value); } }

    public Shape? Shape { get; set; }
    public Collider? Collider { get; set; }
    public PhysicsMaterial? PhysicsMaterial { get; set; }

    public Vector2 Velocity { get; set; }
    public Vector2 Acceleration { get; set; }

    public Element(Vector3 position, Shape? shape=null, Collider? collider=null, PhysicsMaterial? physics_material=null) {
        Position = position;
        Shape ??= shape;
        Collider ??= collider;
        PhysicsMaterial ??= physics_material;
    }

    public virtual void Update(float delta) {
        if (Shape is not null) {
            Shape.Position = new Vector2(Position.X, Position.Y);
            Shape.Update();
        }
    }

    public virtual void PhysicsUpdate(float delta) {

    }

    public virtual void Draw() {
        Shape?.Draw();
    }
}