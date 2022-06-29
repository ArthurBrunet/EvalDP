using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    abstract class Child : Square, IChild
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public IMap Map { get; set; }

        protected Child(int x, int y) : base(true)
        {
            X = x;
            Y = y;
            Map = null;
        }

        public abstract void Live();
        public abstract void Die();
    }
}
