using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }

        //public Eagle()
        //{
        //    Console.WriteLine("Eagle constructor.");
        //}
        public override void Eat()
        {
            Console.WriteLine("Eagle eating.");
        }
    }
}
