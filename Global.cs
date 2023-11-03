using System.Numerics;
using Raylib_cs;

namespace ZPinball;

static class Global {
    // Info
    public static string VersionString = "1.0.0-alpha";

    // Window
    public static Vector2 WindowSize = new(1280, 720);

    // Rendering
    public static bool Render3D = false;
    public static Color BackgroundColor = Color.BLACK;

    // Physics
    public static float Gravity = 5.0f;
    public static float Friction = 0.0f;

    // Debug
    public static bool DrawColliders = false;
    public static bool DrawOrigins = false;
}