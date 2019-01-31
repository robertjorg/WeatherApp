﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients
{
    class Mushroom: IVeggies
    {
        public override string ToString()
        {
            return "Mushroom";
        }
    }
}
