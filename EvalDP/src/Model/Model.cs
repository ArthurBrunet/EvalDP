using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    internal class Model : IModel
    {
        private IMap Map { get; set; }
        public int Height { get { return Map.Height; } }
        public int Width { get { return Map.Width; } }
        public Model()
        {
            Map = new Map(15, 59, 10);
        }

        public ISquare GetSquare(int x, int y)
        {
            return Map.GetSquare(x, y);
        }

        public List<IChild> GetChild(int x, int y)
        {
            return Map.GetChild(x,y);
        }
        public void Live()
        {
            LiveChilds();
        }
        public void LiveChilds()
        {
            Map.LiveChilds();
        }

        public void AddChild(IChild child)
        {
            Map.AddChild(child);
        }
    }
}
