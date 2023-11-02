namespace ZPinball;

class PhysicsMaterial {
    public double Mass { get; private set; }
    public double Bounce { get; private set; }
    public bool Absorb { get; private set; }     // If true, subtract bounce from colliding objects instead of adding

    public PhysicsMaterial(double mass=1.0, double bounce=0.0, bool absorb=false) {
        Mass = mass;
        Bounce = bounce;
        Absorb = absorb;
    }
}