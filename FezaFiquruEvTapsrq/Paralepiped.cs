using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FezaFiquruEvTapsrq
{
    public class Paralepiped
    {
        protected int a;
        protected int b;
        protected int c;

        public Paralepiped(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Varea()
        {
            int area = a * b * c;
            return area;
        }
        public int Areatam()
        {
            int AreaTam=2*(a*b+b*c+a*c);
            return AreaTam;
        }
    }
}
