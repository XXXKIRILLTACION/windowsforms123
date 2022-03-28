using System.Drawing;

namespace WindowsApp3Asteroids
{
    internal interface ICollision
    {
        Rectangle Rect { get; }
        bool Collision(ICollision obj);
    }
}