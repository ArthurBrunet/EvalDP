using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Factories
{
    using EvalDP.src.Model.Throughable;
    public class ThroughableFactory : SquareFactory
    {

        private static ISquare ground = new Ground();
        private static ISquare bridge = new Bridge();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 100);

            if (rand <= 98)
            {
                return makeGround();
            }
            else
            {
                return makeBridge();
            }
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
