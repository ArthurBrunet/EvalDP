using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    public interface IChild: ISquare
    {
        int X { get; }
        int Y { get; }
        public IMap Map { get; set; }
        void Live();
        void Die();
    }
}
