using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    abstract class Square : ISquare
    {
        public ISprite Sprite { get; set; }
        private readonly ISprite[] Sprites;
        public bool Throughable { get; set; }

        protected Square(bool throughable) { 
            Throughable = throughable;
            this.Sprites = new ISprite[4];
        }

        public ISprite GetSprite(int i)
        {
            return this.Sprites[i];
        }

        public void SetSprite(int i, ISprite sprite)
        {
            this.Sprites[i] = sprite;
        }
    }
}
