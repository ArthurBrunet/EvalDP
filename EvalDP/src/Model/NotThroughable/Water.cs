using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model.NotThroughable
{
    class Water : Square
    {
        private static readonly Sprite sprite = new('~');
        public Water() : base(false)
        {
            for (int i = 0; i < 4; i++)
            {
                SetSprite(i, sprite);
            }
        }
    }
}
