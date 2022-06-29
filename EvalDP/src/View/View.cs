using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.View
{
    using src.Model;
    internal class View : IView
    {
        private IModel Model { get; set; }

        public View(IModel model)
        {
            Model = model;
        }

        public void Show()
        {
            for (int y = 0; y < Model.Height; y++)
            {
                Console.WriteLine("");
            }
            for (int y = 0; y < Model.Height; y++)
            {
                string line1 = "";
                string line2 = "";
                for (int x = 0; x < Model.Width; x++)
                {
                    List<IChild> childs = Model.GetChild(x, y);
                    if (childs.Count != 0)
                    {
                        line1 += childs[0].GetSprite(0).Character;
                        line1 += childs[0].GetSprite(1).Character;
                        line2 += childs[0].GetSprite(2).Character;
                        line2 += childs[0].GetSprite(3).Character;
                    }
                    else
                    {
                        line1 += Model.GetSquare(x, y).GetSprite(0).Character;
                        line1 += Model.GetSquare(x, y).GetSprite(1).Character;
                        line2 += Model.GetSquare(x, y).GetSprite(2).Character;
                        line2 += Model.GetSquare(x, y).GetSprite(3).Character;
                    }
                }
                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }
        }
    }
}
