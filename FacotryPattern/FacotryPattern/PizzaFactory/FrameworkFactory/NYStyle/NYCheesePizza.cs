﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.NYStyle
{
    class NYCheesePizza : FPizza
    {
        public NYCheesePizza()
        {
            name = "NY Style ISauce and ICheese Pizza";
            dough = "Thin Crust IDough";
            sauce = "Marinara ISauce";
            toppings.Add("Grated Reggiano ICheese");
        }
    }
}
