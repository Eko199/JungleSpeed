using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    abstract class GameObject
    {
        private Position position;
        public GameObject(IRenderer renderer, Position pos)
        {
            Renderer = renderer;
            Pos = pos;
        }
        protected IRenderer Renderer { get; set; }
        public Position Pos { 
            get 
            {
                return position;
            } 
            
            set
            {
                if (value.X > 0 && value.Y > 0)
                {
                    position = value;
                } 
                else
                {
                    throw new ArgumentException("Invalid coordinates");
                }
            } 
        }

        public abstract void Draw();
    }
}
