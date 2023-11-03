using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Physics {
    public Table Table { get; private set; }
    public List<Element> Elements { get; private set; }

    public Physics(Table table) {
        Table = table;
        Elements = new List<Element>();
    }

    public void AddBall() {
        var Ball = new Ball(new Vector3(Table.Origin.X, Table.Position.Y + 75.0f, 0.0f));
        Table.AddBall(Ball);
    }

    public void AddElement(Element element) {
        if (element.Collider is not null && element.PhysicsMaterial is not null) {
            Elements.Add(element);
            Table.AddElement(element);
        } else {
            Table.AddElement(element);
        }
    }
}