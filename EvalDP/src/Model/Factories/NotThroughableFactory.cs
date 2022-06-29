using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Factories
{
    public class NotThroughableFactory : SquareFactory
    {
        private static ISquare tree = new Tree();

        private static ISquare rock = new Rock();

        public override ISquare makeSquare()
        {
            int rand = new Random().Next(0, 2);

            if (rand == 0)
            {
                return makeTree();
            }
            else
            {
                return makeRock();
            }
        }

        private ISquare makeTree()
        {
            return tree;
        }

        private ISquare makeRock()
        {
            return rock;
        }
    }
}
