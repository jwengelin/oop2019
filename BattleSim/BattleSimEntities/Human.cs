﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimEntities
{
    public class Human : GameEntity
    {
        public override string Name => "Human";
        
        
        public Human() : base (200, 50, 10)
        { }
        

        public override bool StrongAgainst(GameEntity entity)
        {
            if (entity is Monster || entity is Slime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }     
        public override bool WeakAgainst(GameEntity entity)
        {
            if (entity is Dragon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
