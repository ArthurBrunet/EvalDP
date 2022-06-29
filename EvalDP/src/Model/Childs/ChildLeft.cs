using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Childs
{
    class ChildLeft : Child
    {
        private static readonly Sprite sprite = new('L');
        public ChildLeft(int x, int y) : base(x, y)
        {
            this.SetSprite(0, sprite);
            this.SetSprite(1, sprite);
            this.SetSprite(2, sprite);
            this.SetSprite(3, sprite);
        }

        public override void Die()
        {
            // Nothing
        }

        public override void Live()
        {
            int newX = X;
            int newY = Y;

            if (Map.GetSquare(newX-1, newY).Throughable)
            {
                X = newX - 1;
                Y = newY;
            }
            else
            {
                switch (this.GetRandomDirection())
                {
                    case 0:
                        newY = Y == 0 ? 0 : Y - 1;
                        break;
                    case 1:
                        newX = X == Map.Width ? Map.Width : X + 1;
                        break;
                    case 2:
                        newY = Y == Map.Height ? Map.Height : Y + 1;
                        break;
                    case 3:
                        newX = X == 0 ? 0 : X - 1;
                        break;
                }
                if (Map.GetSquare(newX, newY).Throughable)
                {
                    X = newX;
                    Y = newY;
                }
            }
        }

        private int GetRandomDirection()
        {
            Random random = new();
            return random.Next(0, 4);
        }
    }
}
