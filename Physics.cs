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

    public bool AddElement(Element element) {
        if (element.Collider is not null && element.PhysicsMaterial is not null) {
            Elements.Add(element);
            return true;
        }
        return false;
    }
}