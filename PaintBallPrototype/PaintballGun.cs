using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallPrototype
{
    public class PaintballGun
    {
        //fields

        private int balls = 0;

        //properties
        public int BallsLoaded { get; private set; }
        public int MagazineSize { get; private set; } = 16;
        public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0) { balls = value; }
                Reload();
            }
        }
        //Constructor
        public PaintballGun(int balls, int magaZineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magaZineSize;
            if(!loaded) { Reload(); }
        }
        public PaintballGun() :this (16, 16, true)
        {
            Reload();
        }
        //Methods
        public bool IsEmpty() { return BallsLoaded == 0; }
        public void Reload()
        {
            if (balls > MagazineSize) { BallsLoaded = MagazineSize; }
            else { BallsLoaded = balls; }
        }
        public bool Shoot()
        {
            if(BallsLoaded == 0) { return false; }
            BallsLoaded--;
            balls--;
            return true;
        }
    }
}
