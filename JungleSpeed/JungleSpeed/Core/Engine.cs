using JungleSpeed.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Core
{
    class Engine : IEngine
    {
        private IManager manager;
        public Engine(IManager manager)
        {
            this.manager = manager;
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
