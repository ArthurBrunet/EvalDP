using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    public interface IMap
    {
        int Height { get; }
        int Width { get; }
        ISquare GetSquare(int x, int y);
        List<IChild> GetChild(int x, int y);
        void LiveChilds();
        void AddChild(IChild child);
    }
}
