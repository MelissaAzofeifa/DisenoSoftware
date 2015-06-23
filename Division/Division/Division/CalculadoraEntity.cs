﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
   public class CalculadoraEntity
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new Exception("El divisor no debe ser cero");
            }
            return dividendo / divisor;
        }
    }
}
