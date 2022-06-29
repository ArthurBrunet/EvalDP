using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Throughable
{
    class Ground : Square
    {
        private static readonly Sprite sprite = new(' ');
        public Ground() : base(true)
        {
            for (int num = 0; num < 4; num++)
            {
                SetSprite(num, sprite);
            }
        }
    }
}
