using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();
    }
}
