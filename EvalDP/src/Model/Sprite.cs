using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    class Sprite : ISprite
    {
        public char Character { get; set; }

        public Sprite(char character)
        {
            this.Character = character;
        }
    }
}
