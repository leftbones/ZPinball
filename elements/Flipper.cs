using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Flipper : Element {
    public float Angle { get; private set; }
    public float RestAngle { get; private set; }
    public float ActiveAngle { get; private set; }

    public bool Flipped { get; private set; }

    // private int Dir = 1;

    public Flipper(Vector3 position, bool flipped=false) : base(position) {
        Shape = new PolyShape(new List<Vector2>() {
            new(-2, -10),
            new(-10, -7),
            new(-12, 0),
            new(-10, 7),
            new(-2, 10),
            new(50, 5),
            new(54, 4),
            new(55, 0),
            new(54, -4),
            new(50, -5)
        }) { Position = new Vector2(position.X, position.Y) };

        Flipped = flipped;

        RestAngle = 15.0f;
        ActiveAngle = -45.0f;

        Angle = Flipped ? 180 - RestAngle : RestAngle;

        var PolyShape = Shape as PolyShape;
        var NewPoints = new List<Vector2>();

        foreach (var Point in PolyShape!.Points) {
            var TP = Vector2.Transform(Point, Matrix3x2.CreateRotation(Angle * DEG2RAD, Vector2.Zero));
            NewPoints.Add(TP);
        }

        PolyShape.Points = NewPoints;
    }

    public override void Update(float delta) {

    }
}