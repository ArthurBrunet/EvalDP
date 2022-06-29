
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDP.src.Controller
{
    using EvalDP.src.Model;
    using EvalDP.src.Model.Factories;
    using EvalDP.src.Model.Childs;
    using EvalDP.src.View;
    public class Controller : IController
    {
        private static ChildFactory childFactory = new ChildFactory();
        private IModel Model { get; set; }
        private IView View { get; set; }
        public Controller()
        {
            Model = new Model();
            View = new View(Model);
            for (int i = 0; i < 35; i++)
            {
                Model.AddChild(childFactory.make());
            }
            Model.AddChild(new ChildDemoniac(20, 10));
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
