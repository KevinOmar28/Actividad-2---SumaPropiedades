﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2___SumaPropiedades
{
    internal class Sumar
    {
        private int num1;
        private int num2;

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int sumar()
        {
            return num1 + num2;
        }
    }
}
