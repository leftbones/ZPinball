using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Ball : Element {
    public Ball(Vector3 position) : base(position, new CircleShape(9.0f)) {
        Velocity = new Vector2(0, 0);

        PhysicsMaterial = new PhysicsMaterial(0.5, 0.5);
        Collider = new CircleCollider(Position, 9.0f);
    }

    // Set the ball's position
    public void Teleport(float x, float y, float? z=null) {
        var Zed = z ?? Z;
        Position = new Vector3(x, y, Zed);
    }

    // Move based on velocity
    public void Move() {
        Position = new Vector3(X + Velocity.X, Y + Velocity.Y, Z);
        Acceleration = Vector2.Zero;
    }

    // Bounce off of another element
    public void Bounce() {
        Velocity = new Vector2(-Velocity.X, -Velocity.Y * (float)PhysicsMaterial!.Bounce);
        Move();
    }

    public override void Update(float delta) {
        base.Update(delta);
    }

    public override void PhysicsUpdate(float delta) {
        Velocity = new Vector2(Velocity.X + Acceleration.X * delta, Velocity.Y + Acceleration.Y * delta);
        Move();
    }
}