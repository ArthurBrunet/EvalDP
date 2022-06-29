using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.Throughable
{
    class Bridge : Square
    {
        private static readonly Sprite sprite = new('_');
        public Bridge() : base(true)
        {
            for (int num = 0; num < 4; num++)
            {
                SetSprite(num, sprite);
            }
        }
    }
}
