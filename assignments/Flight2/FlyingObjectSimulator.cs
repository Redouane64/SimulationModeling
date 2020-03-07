using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Flight2
{
    internal struct FlyingObjectSimulator : IEnumerator<PointF>
    {
        private decimal time;

        // horizontal and vertical position.
        private decimal x;
        private decimal y;

        // start velocity.
        private decimal v0;
        
        private decimal size;
        private decimal mass;

        // velocity on X axis.
        private decimal vx;
        // velocity on Y axis.
        private decimal vy;

        // angle alpha.
        private decimal angle;

        private decimal k;

        // gravity constant.
        const decimal g = 9.81m;

        const decimal C = 0.15m;
        const decimal rho = 1.29m;

        // delta time.
        const decimal dt = 0.1m;

        // Get current position.
        public PointF Current { get; private set; }
        object IEnumerator.Current => Current;

        /// <summary>
        /// Initialize an instance with required parameters.
        /// </summary>
        public FlyingObjectSimulator(decimal height, decimal weight, decimal angle, decimal speed, decimal size)
        {
            this.time = 0;
            this.x = 0;
            this.y = height;
            this.v0 = speed;
            this.mass = weight;
            this.size = size;
            this.angle = angle;
            this.k = 0.5m * C * rho * size / this.mass;

            double a = (double)angle * Math.PI / 100;
            decimal cosa = (decimal)Math.Cos(a);
            decimal sina = (decimal)Math.Sin(a);
            vx = v0 * cosa;
            vy = v0 * sina;

            this.Current = new PointF((float)x, (float)y);
        }

        public void Dispose() { /* TODO: */ }

        public bool MoveNext()
        {
            time += dt;

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;

            this.Current = new PointF((float)x, (float)y);

            return y > 0;
        }

        public void Reset() { /* TODO: */ }
    }
}
