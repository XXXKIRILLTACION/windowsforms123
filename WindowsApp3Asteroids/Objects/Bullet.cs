using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp3Asteroids.Objects
{
    class Bullet : ObjBase
    {
        private static readonly Image image = Image.FromFile(@"Images\Bullet.png");
        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public bool DeleteMe { get; set; } = false;
        public override void Update()
        {
            pos.X += dir.X;
            pos.Y += dir.Y;
            if (pos.X > Game.Size.Width)
                Reset();
        }
        public override void Reset()
        {
            DeleteMe = true;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(image, new Rectangle(pos, size));
        }
    }
}
