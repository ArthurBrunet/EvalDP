
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Controller
{
    using EvalDP.src.Model;
    using EvalDP.src.Model.Childs;
    using EvalDP.src.View;
    public class Controller : IController
    {
        private IModel Model { get; set; }
        private IView View { get; set; }
        public Controller()
        {
            Model = new Model();
            View = new View(Model);
            Model.AddChild(new ChildHazard(1, 1));
            Model.AddChild(new ChildDown(10, 1));
            Model.AddChild(new ChildLeft(16, 1));
            Model.AddChild(new ChildRight(12, 1));
            Model.AddChild(new ChildUp(14, 1));
        }
        public void Loop()
        {
            do{
                View.Show();
                Model.Live();
                System.Threading.Thread.Sleep(1000);
            }while (true);
        }
    }
}
