using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Factories
{
    using EvalDP.src.Model.Childs;
    class ChildFactory
    {
        private static Random random = new();

        public Child make()
        {
            int rand = new Random().Next(0, 4);
            switch (rand)
            {
                case 0:
                    return makeChildRight();
                case 1:
                    return makeChildLeft();
                case 2:
                    return makeChildDown();
                case 3:
                    return makeChildUp();
                case 4:
                    return makeChildHazard();
            }
            return makeChildHazard();
        }

        private Child makeChildRight()
        {
            return new ChildRight(random.Next(2, 58), random.Next(2, 14));
        }
        private Child makeChildLeft()
        {
            return new ChildLeft(random.Next(2, 58), random.Next(2, 14));
        }
        private Child makeChildDown()
        {
            return new ChildDown(random.Next(2, 58), random.Next(2, 14));
        }
        private Child makeChildUp()
        {
            return new ChildUp(random.Next(2, 58), random.Next(2, 14));
        }
        private Child makeChildHazard()
        {
            return new ChildHazard(random.Next(2, 58), random.Next(2, 14));
        }
    }
}
