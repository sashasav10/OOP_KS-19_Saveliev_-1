using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class TVector3DF : TVector3D
    {
        public TVector3DF (double A1, double A2, double A3) : base(A1, A2, A3)
        {
            this.a1 = A1;
            this.a2 = A2;
            this.a3 = A3;
        }
        public override bool Equals(object obj)
        {
            TVector3DF other = obj as TVector3DF;
            if (this.a1 == other.a1 && this.a2 == other.a2 && this.a3 == other.a3) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return a1.GetHashCode() * 11 + a2.GetHashCode() * 17 + a3.GetHashCode() * 31;
        }
    }
}
