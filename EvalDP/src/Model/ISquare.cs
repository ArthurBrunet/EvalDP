using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    public interface ISquare
    {
        ISprite Sprite { get; set; }
        bool Throughable { get; set; }
        public ISprite GetSprite(int i);
        public void SetSprite(int i, ISprite sprite);
    }
}
