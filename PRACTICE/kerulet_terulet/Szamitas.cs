using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Szamitas
    {
        public float a;
        public float b;
        public float c;
        public float k;
        public float t;

        public Szamitas(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.k = 0;
            this.t = 0;
        }

        public void Szamol()
        {
            k = a + b + c;
            t = (a * b) / 2;
        }
    }
}
