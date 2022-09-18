﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatterm
{
    public interface IBuilder
    {
        public void Reset();
        public void SetAlcohol(decimal alcohol);
        public void SetWater(int water);
        public void setMilk(int milk);
        public void Mix();
        
        public void AddIngredients(string ingredients);
        
        public void Rest(int time);
    }
}
