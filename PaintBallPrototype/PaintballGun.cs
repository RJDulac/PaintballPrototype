﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallPrototype
{
    public class PaintballGun
    {
        //fields
        public const int MAGAZINE_SIZE = 16;

        private int balls = 0;

        //properties
        public int BallsLoaded { get; private set; }
        public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0) { balls = value; }
                Reload();
            }
        }

        //Methods
        public bool IsEmpty() { return BallsLoaded == 0; }
        public void Reload()
        {
            if (balls > MAGAZINE_SIZE) { BallsLoaded = MAGAZINE_SIZE; }
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
