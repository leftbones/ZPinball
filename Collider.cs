using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Collider {
    public Vector3 Position { get; set; }
    public bool Active { get; set; }

    public Collider(Vector3 position) {
        Position = position;
        Active = true;
    }

    public virtual void Draw() {
        
    }
}