using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Model
{
    internal class Map : IMap
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public int Density;

        private ISquare[,] Squares;
        private readonly List<IChild> childs;
        private static readonly ISquare tree = new Tree();
        private static readonly ISquare ground = new Ground();

        public Map(int height, int width, int density)
        {
            Height = height;
            Width = width;
            Density = density;
            this.childs = new();
            this.InitializeRandomlySquares();
        }

        private void InitializeRandomlySquares()
        {
            this.Squares = new ISquare[Height, Width];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    ISquare square;
                    if ((x == 0) || (x == (Width - 1)) || (y == 0) || (y == (Height - 1)))
                    {
                        square = Map.tree;
                    }
                    else
                    {
                        square = this.GetRandomSquare();
                    }
                    this.Squares[y, x] = square;
                }
            }
        }

        private ISquare GetRandomSquare()
        {
            Random random = new();
            if (random.Next(0, 100) < Density)
            {
                return Map.tree;
            }
            return Map.ground;
        }
        public ISquare GetSquare(int x, int y)
        {
            if (x < Width && y < Height)
            {
                return this.Squares[y, x];
            }
            return null;
        }

        public void LiveChilds()
        {
            foreach (IChild child in this.childs)
            {
                child.Live();
            }
        }

        public List<IChild> GetChild(int x, int y)
        {
            List<IChild> result = new();

            foreach (IChild child in this.childs)
            {
                if (child.X == x && child.Y == y)
                {
                    result.Add(child);
                }
            }
            return result;
        }

        public void AddChild(IChild child)
        {
            this.childs.Add(child);
            child.Map = this;
        }
    }
}
