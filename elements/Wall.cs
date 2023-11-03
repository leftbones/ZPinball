using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ZPinball;

class Wall : Element {
    public Wall(Vector3 position, Shape shape) : base(position, shape) {

    }
}