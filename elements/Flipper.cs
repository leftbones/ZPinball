using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Flipper : Element {
    public Flipper(Vector3 position, PolyShape shape) : base(position, shape) {

    }
}