﻿using JungleSpeed.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace JungleSpeed.Models
{
    class Player : GameObject
    {
        private Queue<Card> cards;
        public Player(IRenderer renderer)
            : base(renderer)
        {
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
