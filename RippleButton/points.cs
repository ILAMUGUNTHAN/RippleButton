using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RippleButton
{
    class points
    {
        public int x;
        public int y;
        public int rad;

        public points() { }
        public points(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.rad = z;
        }
    }
}
