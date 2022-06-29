using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Factories
{
    public class ThrougableFactory : SquareFactory
    {

        private static ISquare ground = new Througable.Ground();
        private static ISquare bridge = new 

        public override ISquare makeSquare()
        {
            return makeGround();
        }

        public ISquare makeGround()
        {
            return ground;
        }

        public ISquare makeBridge()
        {
            return bridge;
        }
    }
}
