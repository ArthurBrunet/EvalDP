using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Factories
{

    using EvalDP.src.Model.NotThroughable;
    public class NotThroughableFactory : SquareFactory
    {
        private static ISquare tree = new Tree();

        private static ISquare rock = new Rock();

        private static ISquare water = new Water();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 3);

            if (rand == 0)
            {
                return makeTree();
            }
            else if (rand == 1)
            {
                return makeRock();
            }
            else
            {
                return makeWater();
            }
        }

        public ISquare makeTree()
        {
            return tree;
        }

        private ISquare makeRock()
        {
            return rock;
        }
        private ISquare makeWater()
        {
            return water;
        }
    }
}
