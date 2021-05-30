using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    abstract class GameObject
    {
        public GameObject(IRenderer renderer)
        {
            Renderer = renderer;
        }
        protected IRenderer Renderer { get; set; }

        public abstract void Draw();
    }
}
