using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Table {
    public Vector2 Position { get; private set; }
    public Vector2 Size { get; private set; }
    public float Angle { get; private set; }

    public List<Element> Elements { get; private set; }
    public List<Ball> Balls { get; private set; }

    public Vector2 Origin { get { return new Vector2(Position.X + Size.X / 2, Position.Y + Size.Y / 2); } }
    public Rectangle Extents { get { return new Rectangle(Position.X, Position.Y, Size.X, Size.Y); } }

    public Table(Vector2 center, float width, float height, float angle) {
        Position = new Vector2(center.X - width / 2, center.Y - height / 2);
        Size = new Vector2(width, height);
        Angle = angle;

        Elements = new List<Element>();
        Balls = new List<Ball>();
    }

    // Add a ball to the table
    public void AddBall(Ball ball) {
        Balls.Add(ball);
    }

    // Add an element to the table
    public void AddElement(Element element) {
        Elements.Add(element);
    }

    // Main update method
    public void Update(float delta) {
        // Balls
        foreach (var Ball in Balls) {
            Ball.Update(delta);
        }

        // Elements
        foreach (var Element in Elements) {
            Element.Update(delta);
        }
    }

    // Main draw method
    public void Draw() {
        // Playfield
        if (Global.Render3D) {
            var D = (float)(Size.X * Math.Tan(Angle * Math.PI / 180));

            var TL = new Vector2(Position.X + D, Position.Y);
            var TR = new Vector2(Position.X + Size.X - D, Position.Y);
            var BL = new Vector2(Position.X, Position.Y + Size.Y);
            var BR = new Vector2(Position.X + Size.X, Position.Y + Size.Y);

            DrawLineEx(TL, TR, 1.0f, Color.DARKGRAY);
            DrawLineEx(TL, BL, 1.0f, Color.DARKGRAY);
            DrawLineEx(TR, BR, 1.0f, Color.DARKGRAY);
            DrawLineEx(BL, BR, 1.0f, Color.DARKGRAY);
        } else {
            DrawRectangleLinesEx(Extents, 1.0f, Color.WHITE);
        }

        // Elements
        foreach (var Element in Elements) {
            Element.Draw();
        }

        // Balls
        foreach (var Ball in Balls) {
            Ball.Draw();
        }
    }
}