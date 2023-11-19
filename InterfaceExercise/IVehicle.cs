﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Year { get; set; }
        public string Make { get; set;}
        public string Model { get; set;}
        public string  Engine { get; set;}

        
        public void Park();
        public void Reverse();
        public void Neutral();
        public void Drive();

    }
}