using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class TVector2DF: TVector2D
    {
        public TVector2DF(double A1, double A2) : base(A1, A2)
        {
            this.a1 = A1;
            this.a2 = A2;
        }
        public override bool Equals(object obj)
        {
            TVector2DF other = obj as TVector2DF;
            if (this.a1==other.a1&& this.a2 == other.a2) return true;
           else return false;
        }

        public override int GetHashCode()
        {
            return a1.GetHashCode()*11+a2.GetHashCode()*17;
        }
    }
}
